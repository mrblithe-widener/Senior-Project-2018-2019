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
    public class ReadController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public ReadController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Read>>> GetRead()
        {
            return await _context.Read.ToListAsync();
        }

        // GET: api/Read/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Read>> GetRead(long id)
        {
            var read = await _context.Read.FindAsync(id);

            if (read == null)
            {
                return NotFound();
            }

            return read;
        }

        // PUT: api/Read/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRead(long id, Read read)
        {
            if (id != read.ReadNcessch)
            {
                return BadRequest();
            }

            _context.Entry(read).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReadExists(id))
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

        // POST: api/Read
        [HttpPost]
        public async Task<ActionResult<Read>> PostRead(Read read)
        {
            _context.Read.Add(read);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ReadExists(read.ReadNcessch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRead", new { id = read.ReadNcessch }, read);
        }

        // DELETE: api/Read/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Read>> DeleteRead(long id)
        {
            var read = await _context.Read.FindAsync(id);
            if (read == null)
            {
                return NotFound();
            }

            _context.Read.Remove(read);
            await _context.SaveChangesAsync();

            return read;
        }

        private bool ReadExists(long id)
        {
            return _context.Read.Any(e => e.ReadNcessch == id);
        }
    }
}
