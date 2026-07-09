using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Team;
using SMConsulting.BL.Services.Abstracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles = "1")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController(ITeamService _service) : ControllerBase
    {
        // GET: api/Teams
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        // POST: api/Teams
        [HttpPost]
        public async Task<IActionResult> Create(TeamCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        // PUT: api/Teams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TeamUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}