using CoWorking.Biz;
using CoWorking.Biz.Model.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoWorking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IReponsitoryWapper _repository;
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(IReponsitoryWapper repository, ILogger<CustomerController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(New model)
        {
            try
            {
                var result = await _repository.Customer.CreateAync(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Customer create Error");
                return BadRequest(ex.Message);
            }
        }

    }
}
