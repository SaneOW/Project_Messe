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
                // Schritt 1: Daten aus der Client-Datenbank abrufen
                var customers = await _customerService.GetAllCustomerDataAsync();

                // Schritt 2: Daten in DTOs konvertieren und Duplikate entfernen
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

                // Schritt 3: DTOs an den Server senden
                foreach (var customerDto in customerDtos)
                {
                    await _customerApiClient.SendCustomerToServerAsync(customerDto);
                }

                // Schritt 4: Datenbanktabellen löschen
                await _customerService.DeleteAllCustomersAsync();

                MessageBox.Show("Daten erfolgreich gesendet und Datenbanktabellen gelöscht!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

