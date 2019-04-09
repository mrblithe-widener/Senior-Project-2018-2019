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
    public class Title1Controller : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public Title1Controller(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Title1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Title1>>> GetTitle1()
        {
            return await _context.Title1.ToListAsync();
        }

        // GET: api/Title1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Title1>> GetTitle1(decimal id)
        {
            var title1 = await _context.Title1.FindAsync(id);

            if (title1 == null)
            {
                return NotFound();
            }

            return title1;
        }

        // PUT: api/Title1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitle1(decimal id, Title1 title1)
        {
            if (id != title1.Ncessch)
            {
                return BadRequest();
            }

            _context.Entry(title1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Title1Exists(id))
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

        // POST: api/Title1
        [HttpPost]
        public async Task<ActionResult<Title1>> PostTitle1(Title1 title1)
        {
            _context.Title1.Add(title1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Title1Exists(title1.Ncessch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTitle1", new { id = title1.Ncessch }, title1);
        }

        // DELETE: api/Title1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Title1>> DeleteTitle1(decimal id)
        {
            var title1 = await _context.Title1.FindAsync(id);
            if (title1 == null)
            {
                return NotFound();
            }

            _context.Title1.Remove(title1);
            await _context.SaveChangesAsync();

            return title1;
        }

        private bool Title1Exists(decimal id)
        {
            return _context.Title1.Any(e => e.Ncessch == id);
        }
    }
}
