using CoWorking.Biz;
using CoWorking.Biz.Model.CategoryOffice;
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
    public class CategoryOfficeController : Controller
    {
        private readonly IReponsitoryWapper _repository;
        private readonly ILogger<CategoryOfficeController> _logger;
        public CategoryOfficeController(IReponsitoryWapper repository, ILogger<CategoryOfficeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var item = await _repository.CategoryOffice.GetById(id);
                return Ok(item);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Category get {id} Office");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Biz.Model.CategoryOffice.New model)
        {
            try
            {
                var item = await _repository.CategoryOffice.CreateAync(model);
                return Ok(item);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Create User Error");
                return BadRequest(ex.Message);

            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Edit model)
        {
            try
            {
                var item = await _repository.CategoryOffice.UpdateAync(model);
                return Ok(item);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Update Category Error");
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _repository.CategoryOffice.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, $"Delete Category Error");
                return BadRequest(ex.Message);
            }
        }

    }
}
