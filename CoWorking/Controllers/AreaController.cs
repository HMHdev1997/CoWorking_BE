using CoWorking.Biz;
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
    public class AreaController : Controller
    {
        private readonly IReponsitoryWapper _repository;
        private readonly ILogger<AreaController> _logger;
        public AreaController(IReponsitoryWapper repository, ILogger<AreaController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Biz.Model.Area.New model)
        {
            try
            {
                var item = await _repository.Area.CreateAync(model);
                return Ok(item);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Create User Error");
                return BadRequest(ex.Message);

            }
        }

    }
}
