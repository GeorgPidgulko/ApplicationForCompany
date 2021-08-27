using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_For_Infopulse.Server.Services;
using Application_For_Infopulse.Shared.Models;

namespace Application_For_Infopulse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("{action}")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _customerService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerAsync(Customer customer)
        {
            try
            {
                await _customerService.CreateCustomerAsync(customer);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Customer not created");
            }
        }
    }
}
