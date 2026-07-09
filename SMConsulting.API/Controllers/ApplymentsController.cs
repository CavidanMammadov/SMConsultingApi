using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Applyment;
using SMConsulting.BL.Services.Abstracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles = "1")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplymentsController(IApplymentService _service) : ControllerBase
    {
        // GET: api/<ApplymentsController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll() 
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("GetWithPagination")]
        [AllowAnonymous]
        public async Task<IActionResult> GetWithPagination(int page, int take) 
        {
            var data = await _service.GetWithPagination(page, take);
            return Ok(data);
        }

        // GET api/<ApplymentsController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await  _service.GetByIdAsync(id));
        }

        // POST api/<ApplymentsController>
        [HttpPost]
        public async Task<IActionResult> Create(ApplymentCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        // PUT api/<ApplymentsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ApplymentUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        // DELETE api/<ApplymentsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}
