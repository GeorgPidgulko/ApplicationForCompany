using Application_For_Infopulse.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _client;
        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<Product>>("api/Products");
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            var response = await _client.PostAsJsonAsync("api/Products/", product);
            return response.IsSuccessStatusCode;            
        }       

        public async Task DeleteProductAsync(long productId)
        {
            await _client.DeleteAsync($"api/Products?productId={productId}");
        }
    }
}
