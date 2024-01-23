using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_Messe.Datenbank.Context;
using Project_Messe.Datenbank.DatabaseKlassen;
using Project_Messe.Dto;
using Project_Messe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Messe.Windows
{
    public partial class WorkerWindow : Form

    {
        private readonly CustomerServices _customerService;
        private readonly CustomerApiClient _customerApiClient;
        public WorkerWindow()
        {
            InitializeComponent();
            _customerService = new CustomerServices();
            _customerApiClient = new CustomerApiClient(new HttpClient());
        }

        private async void button_sendData_Click(object sender, EventArgs e)
        {
            try
            {
                //  Daten aus der Client-Datenbank abrufen
                var customers = await _customerService.GetAllCustomerDataAsync();

                // Daten in DTOs konvertieren und Duplikate entfernen
                var customerDtos = customers.Select(c => new CustomerDto
                {
                    LastName = c.LastName,
                    FirstName = c.FirstName,
                    StreetAddress = c.StreetAddress,
                    HouseNumber = c.HouseNumber,
                    City = c.City,
                    PostalCode = c.PostalCode,
                    Country = c.Country,
                    Picture = c.Picture,
                    ProductIds = c.Products.Select(p => p.ProductId).ToList()
                }).Distinct().ToList();

                // DTOs an den Server senden
                foreach (var customerDto in customerDtos)
                {
                    await _customerApiClient.SendCustomerToServerAsync(customerDto);
                }

                // Datenbanktabellen löschen
                await _customerService.DeleteAllCustomersAsync();

                MessageBox.Show("Daten erfolgreich gesendet und Datenbanktabellen gelöscht!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button_DatenAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                var customerDtos = await _customerApiClient.GetCustomerDataAsync();

                // DataGridView vorbereiten
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;

                // Spalten für die DataGridView erstellen (alle relevanten Felder)
                dataGridView1.Columns.Add("FirstName", "Vorname");
                dataGridView1.Columns.Add("LastName", "Nachname");
                dataGridView1.Columns.Add("StreetAddress", "Straße");
                dataGridView1.Columns.Add("HouseNumber", "Hausnummer");
                dataGridView1.Columns.Add("City", "Stadt");
                dataGridView1.Columns.Add("PostalCode", "PLZ");
                dataGridView1.Columns.Add("Country", "Land");

                // Spalte für das Bild hinzufügen
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.HeaderText = "Bild";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch; // Stretch-Modus
                dataGridView1.Columns.Add(imageColumn);

                foreach (var customerDto in customerDtos)
                {
                    // Bild aus Byte-Array erstellen
                    Image image;
                    using (var ms = new MemoryStream(customerDto.Picture))
                    {
                        image = Image.FromStream(ms);
                    }

                    // DataGridViewRow erstellen und Daten setzen
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.FirstName });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.LastName });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.StreetAddress });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.HouseNumber });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.City });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.PostalCode });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.Country });
                    row.Cells.Add(new DataGridViewImageCell { Value = image });

                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = textBoxSearch.Text;


                var searchResults = await _customerApiClient.SearchCustomerByNameAsync(searchName);


                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;


                dataGridView1.Columns.Add("FirstName", "Vorname");
                dataGridView1.Columns.Add("LastName", "Nachname");
                dataGridView1.Columns.Add("StreetAddress", "Straße");
                dataGridView1.Columns.Add("HouseNumber", "Hausnummer");
                dataGridView1.Columns.Add("City", "Stadt");
                dataGridView1.Columns.Add("PostalCode", "PLZ");
                dataGridView1.Columns.Add("Country", "Land");

                // Spalte für das Bild hinzufügen
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.HeaderText = "Bild";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.Columns.Add(imageColumn);

                foreach (var customerDto in searchResults)
                {
                    // Bild aus Byte-Array erstellen
                    Image image;
                    using (var ms = new MemoryStream(customerDto.Picture))
                    {
                        image = Image.FromStream(ms);
                    }

                    // DataGridViewRow erstellen und Daten setzen
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.FirstName });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.LastName });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.StreetAddress });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.HouseNumber });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.City });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.PostalCode });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = customerDto.Country });
                    row.Cells.Add(new DataGridViewImageCell { Value = image });

                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainWindow().ShowDialog();
        }
    }
}

