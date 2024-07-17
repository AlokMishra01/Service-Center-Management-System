using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service_Center_Management_System.Data;
using Service_Center_Management_System.Data.Entities;

namespace Service_Center_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BodyTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BodyType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BodyType>>> GetBodyTypes()
        {
            return await _context.BodyTypes.ToListAsync();
        }

        // GET: api/BodyType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BodyType>> GetBodyType(Guid id)
        {
            var bodyType = await _context.BodyTypes.FindAsync(id);

            if (bodyType == null)
            {
                return NotFound();
            }

            return bodyType;
        }

        // PUT: api/BodyType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBodyType(Guid id, BodyType bodyType)
        {
            if (id != bodyType.Id)
            {
                return BadRequest();
            }

            _context.Entry(bodyType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodyTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BodyType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BodyType>> PostBodyType(BodyType bodyType)
        {
            _context.BodyTypes.Add(bodyType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBodyType", new { id = bodyType.Id }, bodyType);
        }

        // DELETE: api/BodyType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodyType(Guid id)
        {
            var bodyType = await _context.BodyTypes.FindAsync(id);
            if (bodyType == null)
            {
                return NotFound();
            }

            _context.BodyTypes.Remove(bodyType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BodyTypeExists(Guid id)
        {
            return _context.BodyTypes.Any(e => e.Id == id);
        }
    }
}
