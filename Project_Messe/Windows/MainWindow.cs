using Project_Messe.Datenbank.Database;
using Project_Messe.Datenbank.DatabaseKlassen;

namespace Project_Messe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
                // PhotoPath wird später hinzugefügt
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
    }
}
