using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get ()
        {
            var values = await _context.Values.ToListAsync();
            if(values == null)
                return NotFound();
            return Ok(values);
            
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id == id);
            if (value == null)
                return NotFound();
            return Ok(value);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            //if (value == null)
            //    return BadRequest("Name dat not set");
            //await _context.Values.AddAsync(value);
            //await _context.SaveChangesAsync();
            //return StatusCode(201);

        }

       
    }
}
