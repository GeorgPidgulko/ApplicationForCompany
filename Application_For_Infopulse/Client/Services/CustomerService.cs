using Application_For_Infopulse.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Client.Services
{
    public class CustomerService
    {
        private readonly HttpClient _client;
        public CustomerService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<Customer>>("api/Customers/GetAll");
        }

        public async Task<bool> CreateCustomerAsync(Customer customer)
        {
            var response = await _client.PostAsJsonAsync("api/Customers/", customer);
            return response.IsSuccessStatusCode;
        }
    }
}
