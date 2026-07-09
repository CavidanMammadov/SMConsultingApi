using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Blog;
using SMConsulting.BL.Services.Abstracts;

namespace SMConsulting.API.Controllers
{
    [Authorize(Roles = "1")]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IBlogService _service) : ControllerBase
    {
        // GET: api/Blogs
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        // GET: api/Blogs/GetWithPagination?page=1&take=10
        [HttpGet("GetWithPagination")]
        [AllowAnonymous]
        public async Task<IActionResult> GetWithPagination(int page, int take)
        {
            var data = await _service.GetWithPagination(page, take);
            return Ok(data);
        }

        // GET: api/Blogs/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        // POST: api/Blogs
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BlogCreateDto dto)
        {
            var data = await _service.CreateAsync(dto);
            return Ok(data);
        }

        // PUT: api/Blogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] BlogUpdateDto dto)
        {
            var data = await _service.UpdateAsync(id, dto);
            return Ok(data);
        }

        // DELETE: api/Blogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Removed");
        }
    }
}