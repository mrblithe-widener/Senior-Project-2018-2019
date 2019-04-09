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
    public class GeoController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public GeoController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Geo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Geo>>> GetGeo()
        {
            return await _context.Geo.ToListAsync();
        }

        // GET: api/Geo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Geo>> GetGeo(decimal id)
        {
            var geo = await _context.Geo.FindAsync(id);

            if (geo == null)
            {
                return NotFound();
            }

            return geo;
        }

        // PUT: api/Geo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeo(decimal id, Geo geo)
        {
            if (id != geo.Ncessch)
            {
                return BadRequest();
            }

            _context.Entry(geo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeoExists(id))
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

        // POST: api/Geo
        [HttpPost]
        public async Task<ActionResult<Geo>> PostGeo(Geo geo)
        {
            _context.Geo.Add(geo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GeoExists(geo.Ncessch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGeo", new { id = geo.Ncessch }, geo);
        }

        // DELETE: api/Geo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Geo>> DeleteGeo(decimal id)
        {
            var geo = await _context.Geo.FindAsync(id);
            if (geo == null)
            {
                return NotFound();
            }

            _context.Geo.Remove(geo);
            await _context.SaveChangesAsync();

            return geo;
        }

        private bool GeoExists(decimal id)
        {
            return _context.Geo.Any(e => e.Ncessch == id);
        }
    }
}
