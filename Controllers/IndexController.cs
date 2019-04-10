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
    public class IndexController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public IndexController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Index
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Index>>> GetIndex()
        {
            return await _context.Index.ToListAsync();
        }

        // GET: api/Index/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Index>> GetIndex(long id)
        {
            var index = await _context.Index.FindAsync(id);

            if (index == null)
            {
                return NotFound();
            }

            return index;
        }
        [HttpGet("SearchName/{name}")]
        public async Task<ActionResult<IEnumerable<Index>>> SearchName(string name)
        {
            string name_lower = name.ToLower();
            return await _context.Index.Where(x => x.Name.ToLower().Contains(name_lower)).Take(10).ToListAsync();
        }
        // PUT: api/Index/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndex(long id, Index index)
        {
            if (id != index.Nceesch)
            {
                return BadRequest();
            }

            _context.Entry(index).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndexExists(id))
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

        // POST: api/Index
        [HttpPost]
        public async Task<ActionResult<Index>> PostIndex(Index index)
        {
            _context.Index.Add(index);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (IndexExists(index.Nceesch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetIndex", new { id = index.Nceesch }, index);
        }

        // DELETE: api/Index/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Index>> DeleteIndex(long id)
        {
            var index = await _context.Index.FindAsync(id);
            if (index == null)
            {
                return NotFound();
            }

            _context.Index.Remove(index);
            await _context.SaveChangesAsync();

            return index;
        }

        private bool IndexExists(long id)
        {
            return _context.Index.Any(e => e.Nceesch == id);
        }
    }
}
