using CoWorking.Biz;
using CoWorking.Biz.Model.Office;
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
    public class OfficeController : Controller
    {
        private readonly IReponsitoryWapper _repository;
        private readonly ILogger<OfficeController> _logger;
        public OfficeController(IReponsitoryWapper repository, ILogger<OfficeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        //GET: OfficeController/
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var Office = await _repository.Office.GetById(id);
                return Ok(Office);

            }
            catch (Exception ex)
            {

                _logger.LogInformation(ex, $"Office get {id} ");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{search}")]
        public async Task<IActionResult> SearchOffice(string search)
        {
            try
            {
                var result = await _repository.Office.GetSearch(search);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Office get search {search}");
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetPage")]
        public async Task<IActionResult> GetByPage(int page, int pageSize)
        {
            var item = await _repository.Office.GetPageAync(page, pageSize);
            return Ok(item);

        }
        [HttpPost("CreateOffice")]
        public async Task<IActionResult> CreateOffice(New model)
        {
            try
            {
                var result = await _repository.Office.CreateAync(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Office create Error");
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateOffice")]
        public async Task<IActionResult> Update(Edit model)
        {
            try
            {
                var item = await _repository.Office.UpdateAync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Update Office Error");
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                await _repository.Office.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Delete Office Error");
                return BadRequest(ex.Message);
            }
        }

    }
}
