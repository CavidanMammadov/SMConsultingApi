using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Services;
using SMConsulting.BL.Services.Abstracts;

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles = "1")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController(IServiceService _service) : ControllerBase
    {
        // GET: api/Services
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        // GET: api/Services/GetWithPagination?page=1&take=10
        [HttpGet("GetWithPagination")]
        [AllowAnonymous]
        public async Task<IActionResult> GetWithPagination(int page, int take)
        {
            var data = await _service.GetWithPagination(page,take);
            return Ok(data);
        }

        // GET: api/Services/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        // POST: api/Services
        [HttpPost]
        public async Task<IActionResult> Create(ServiceCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        // PUT: api/Services/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ServiceUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        // DELETE: api/Services/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}