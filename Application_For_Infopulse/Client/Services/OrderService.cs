using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Application_For_Infopulse.Shared.Models;
using Newtonsoft.Json;

namespace Application_For_Infopulse.Client.Services
{
    public class OrderService
    {
        private readonly HttpClient _client;
        public OrderService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<Order>>("api/Orders/GetAll");
        }

        public async Task<Order> GetAsync(long orderId)
        {

            var response = await _client.GetAsync($"api/Orders/Get?orderId={orderId}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Order>(json);
            }
            return null;
        }

        public async Task<List<string>> GetStatuses()
        {
            return await _client.GetFromJsonAsync<List<string>>("api/Orders/GetStatuses");
        }

        public async Task<bool> CreateOrderAsync(Order order)
        {          
            order.CustomerId = order.Customer.Id;
            order.Customer = null;

            var response = await _client.PostAsJsonAsync("api/Orders/", order);
            return response.IsSuccessStatusCode;
        }    
        
        public async Task<bool> UpdateOrderAsync(Order order)
        {          
            order.CustomerId = order.Customer.Id;
            order.Customer = null;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            string json = JsonConvert.SerializeObject(order, settings);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
      

            var response = await _client.PutAsync("api/Orders/", content);
            return response.IsSuccessStatusCode;
        }
    }
}
