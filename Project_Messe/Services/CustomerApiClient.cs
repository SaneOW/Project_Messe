using Newtonsoft.Json;
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


        }
        public async Task<List<CustomerDto>> GetCustomerDataAsync()
        {
            using (var client = new HttpClient())
            {
                string url = "http://localhost:5042/api/Customers"; // URL der API anpassen
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CustomerDto>>(jsonString);
                }
                else
                {
                    // Fehlerbehandlung, wenn API nicht erfolgreich ist
                    throw new InvalidOperationException(response.ReasonPhrase);
                }
            }
        }
        public async Task<List<CustomerDto>> SearchCustomerByNameAsync(string name)
        {
            string url = $"http://localhost:5042/api/Customers/search?name={Uri.EscapeDataString(name)}"; // URL der API anpassen

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CustomerDto>>(jsonString);
                }
                else
                {
                    // Fehlerbehandlung, wenn API nicht erfolgreich ist
                    throw new InvalidOperationException(response.ReasonPhrase);
                }
            }
        }

    }
}
