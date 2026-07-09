using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.CardSpecifications;
using SMConsulting.BL.Services.Abstracts;

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles = "1")]
    [Route("api/[controller]")]
    [ApiController]
    public class CardSpecificationsController(ICardSpecificationService _service) : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CardSpecificationCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] CardSpecificationUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}