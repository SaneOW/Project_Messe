using AForge.Video;
using AForge.Video.DirectShow;
using Project_Messe.Datenbank.Database;
using Project_Messe.Datenbank.DatabaseKlassen;

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
            if (string.IsNullOrWhiteSpace(text_Vorname.Text) || string.IsNullOrWhiteSpace(text_Nachname.Text) || string.IsNullOrWhiteSpace(text_Straße.Text)
                || string.IsNullOrWhiteSpace(text_Hausnummer.Text) || string.IsNullOrWhiteSpace(text_Postleitzahl.Text) || string.IsNullOrWhiteSpace(text_Land.Text)
                || string.IsNullOrWhiteSpace(text_Stadt.Text))
            {
                MessageBox.Show("Bitte geben Sie die Daten vollständig ein!");
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
                StreetAddress = text_Straße.Text,
                City = text_Stadt.Text,
                PostalCode = text_Postleitzahl.Text,
                Country = text_Land.Text,
                HouseNumber = text_Hausnummer.Text,
                Picture = ImageToByteArray(currentFrame) // Hier wird das Bild als Byte-Array gespeichert
            };

            // Daten in der Datenbank speichern
            using (var context = new MesseDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }

            // Bestätigung anzeigen
            MessageBox.Show("Kundendaten gespeichert!");
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
            // Da dieses Ereignis in einem separaten Thread aufgerufen wird, müssen Sie sicherstellen,
            // dass Sie auf die PictureBox in einem threadsicheren Weg zugreifen
            if (pictureBoxVideo.InvokeRequired)
            {
                pictureBoxVideo.Invoke(new MethodInvoker(delegate
                {
                    // Erstellen Sie eine Kopie des neuen Frames aus dem Event-Argument
                    // und setzen Sie es als Bild für die PictureBox
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

        // Stellen Sie sicher, dass Sie die Kamera beim Schließen des Fensters stoppen
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
                MessageBox.Show("Bitte wählen Sie eine Kamera aus der Liste.");
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
    }
}

