using AForge.Video;
using AForge.Video.DirectShow;
using Project_Messe.Datenbank.DatabaseKlassen;
using Project_Messe.Datenbank.Context;
using Project_Messe.Windows;

namespace Project_Messe
{
    public partial class MainWindow : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;

        public MainWindow()
        {
            InitializeComponent();
            LoadAvailableVideoDevices();
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_Vorname.Text) || string.IsNullOrWhiteSpace(text_Nachname.Text) || string.IsNullOrWhiteSpace(text_Straﬂe.Text)
                || string.IsNullOrWhiteSpace(text_Hausnummer.Text) || string.IsNullOrWhiteSpace(text_Postleitzahl.Text) || string.IsNullOrWhiteSpace(text_Land.Text)
                || string.IsNullOrWhiteSpace(text_Stadt.Text))
            {
                MessageBox.Show("Bitte geben Sie die Daten vollst‰ndig ein!");
                return;
            }

            if (currentFrame == null)
            {
                MessageBox.Show("Bitte nehmen Sie zuerst ein Foto auf.");
                return;
            }

            // Kundenobjekt erstellen
            var customer = new Customer
            {
                FirstName = text_Vorname.Text,
                LastName = text_Nachname.Text,
                StreetAddress = text_Straﬂe.Text,
                City = text_Stadt.Text,
                PostalCode = text_Postleitzahl.Text,
                Country = text_Land.Text,
                HouseNumber = text_Hausnummer.Text,
                Picture = ImageToByteArray(currentFrame), // Hier wird das Bild als Byte-Array gespeichert
                Products = new List<Product>() // Initialisieren Sie die Produktliste
            };
            using (var context = new MesseDbContext())
            {

                // Produkte basierend auf der Auswahl der Radio-Buttons hinzuf¸gen
                if (radio_Smartphones.Checked)
                {
                    var smartphoneProduct = context.Products.FirstOrDefault(p => p.ProductName == "Smartphones");
                    if (smartphoneProduct != null)
                    {
                        customer.Products.Add(smartphoneProduct);
                    }
                }

                if (radio_Laptops_yes.Checked)
                {
                    var laptopProduct = context.Products.FirstOrDefault(p => p.ProductName == "Laptops");
                    if (laptopProduct != null)
                    {
                        customer.Products.Add(laptopProduct);
                    }
                }

                if (radio_Autos_yes.Checked)
                {
                    var autoProduct = context.Products.FirstOrDefault(p => p.ProductName == "Autos");
                    if (autoProduct != null)
                    {
                        customer.Products.Add(autoProduct);
                    }
                }

                // Daten in der Datenbank speichern
                context.Customers.Add(customer);
                context.SaveChanges();

            }

            // Best‰tigung anzeigen
            MessageBox.Show("Kundendaten gespeichert!");
        }

        // Diese Methode holt das Produkt anhand des Namens aus der Datenbank.
        private Product GetProductByName(string productName)
        {
            using (var context = new MesseDbContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductName == productName);
            }
        }


        // Diese Methode konvertiert eine Bitmap in ein Byte-Array
        private byte[] ImageToByteArray(Bitmap image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private void LoadAvailableVideoDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBoxCameraList.Items.Clear();
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameraList.Items.Add(device.Name);
            }
        }



        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            if (pictureBoxVideo.InvokeRequired)
            {
                pictureBoxVideo.Invoke(new MethodInvoker(delegate
                {
                    pictureBoxVideo.Image?.Dispose(); // Vorheriges Bild freigeben, um Speicherlecks zu vermeiden
                    Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
                    pictureBoxVideo.Image = frame;
                }));
            }
            else
            {
                pictureBoxVideo.Image?.Dispose(); // Vorheriges Bild freigeben
                pictureBoxVideo.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        // Stellen Sie sicher, dass Sie die Kamera beim Schlieﬂen des Fensters stoppen
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }

        private void buttonSelectCamera_Click_1(object sender, EventArgs e)
        {

            if (comboBoxCameraList.SelectedIndex != -1)
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameraList.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("Bitte w‰hlen Sie eine Kamera aus der Liste.");
            }
        }


        private void retry_Click(object sender, EventArgs e)
        {
            buttonSelectCamera_Click_1(sender, e);
            button_Picture.Name = "button_Picture";
            button_Picture.Text = "Foto aufnehmen";
        }
        private void button_Picture_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                // Stoppen des Video-Streams
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame;

                // Button verstecken nach Knopfdruck um Retry Button anzuzeigen
                button_Picture.Visible = false;
                button_retry.Visible = true;
                // Warten, bis der Frame verarbeitet wurde
                Thread.Sleep(500);

                // Bild erfassen und anzeigen
                currentFrame = (Bitmap)pictureBoxVideo.Image.Clone();
                pictureBoxVideo.Image = currentFrame;



            }
            else
            {
                MessageBox.Show("Kamera ist nicht aktiv.");
            }
        }

        private void retry_button_Click(object sender, EventArgs e)
        {
            buttonSelectCamera_Click_1(sender, e);
            button_retry.Visible = false;
            button_Picture.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

