using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeniorProjectWebsite.Models;

namespace SeniorProjectWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public MathController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Math
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeniorProjectWebsite.Models.Math>>> GetMath()
        {
            return await _context.Math.ToListAsync();
        }

        // GET: api/Math/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeniorProjectWebsite.Models.Math>> GetMath(long id)
        {
            var math = await _context.Math.FindAsync(id);

            if (math == null)
            {
                return NotFound();
            }

            return math;
        }

        // PUT: api/Math/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMath(long id, SeniorProjectWebsite.Models.Math math)
        {
            if (id != math.MathNcessch)
            {
                return BadRequest();
            }

            _context.Entry(math).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MathExists(id))
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

        // POST: api/Math
        [HttpPost]
        public async Task<ActionResult<SeniorProjectWebsite.Models.Math>> PostMath(SeniorProjectWebsite.Models.Math math)
        {
            _context.Math.Add(math);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MathExists(math.MathNcessch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMath", new { id = math.MathNcessch }, math);
        }

        // DELETE: api/Math/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SeniorProjectWebsite.Models.Math>> DeleteMath(long id)
        {
            var math = await _context.Math.FindAsync(id);
            if (math == null)
            {
                return NotFound();
            }

            _context.Math.Remove(math);
            await _context.SaveChangesAsync();

            return math;
        }

        private bool MathExists(long id)
        {
            return _context.Math.Any(e => e.MathNcessch == id);
        }
    }
}
