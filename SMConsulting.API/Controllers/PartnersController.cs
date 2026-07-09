using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Member;
using SMConsulting.BL.DTOs.Partner;
using SMConsulting.BL.Services.Abstracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles ="1")]
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController(IPartnerService _service) : ControllerBase
    {
        // GET: api/<PartnersController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        // GET api/<PartnersController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        // POST api/<PartnersController>
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PartnerCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        // PUT api/<PartnersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] PartnerUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        // DELETE api/<PartnersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}
