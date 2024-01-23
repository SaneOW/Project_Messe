using Project_Messe.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Project_Messe.Services
{
    internal class CustomerApiClient
    {
        private readonly HttpClient _httpClient;

        public CustomerApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5042/");
        }

        public async Task SendCustomerToServerAsync(CustomerDto customerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Customers", customerDto);
            response.EnsureSuccessStatusCode(); // Wirft eine Ausnahme, wenn der HTTP-Statuscode im Fehlerbereich ist

            // Optional: Rückgabe der Antwort oder anderer Daten
            // var createdCustomer = await response.Content.ReadFromJsonAsync<CustomerDto>();
            // return createdCustomer;
        }
    }
}
