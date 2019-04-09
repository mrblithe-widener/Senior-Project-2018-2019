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
    public class TeacherRatiosController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public TeacherRatiosController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/TeacherRatios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherRatios>>> GetTeacherRatios()
        {
            return await _context.TeacherRatios.ToListAsync();
        }

        // GET: api/TeacherRatios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherRatios>> GetTeacherRatios(decimal id)
        {
            var teacherRatios = await _context.TeacherRatios.FindAsync(id);

            if (teacherRatios == null)
            {
                return NotFound();
            }

            return teacherRatios;
        }

        // PUT: api/TeacherRatios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacherRatios(decimal id, TeacherRatios teacherRatios)
        {
            if (id != teacherRatios.Ncessch)
            {
                return BadRequest();
            }

            _context.Entry(teacherRatios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherRatiosExists(id))
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

        // POST: api/TeacherRatios
        [HttpPost]
        public async Task<ActionResult<TeacherRatios>> PostTeacherRatios(TeacherRatios teacherRatios)
        {
            _context.TeacherRatios.Add(teacherRatios);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeacherRatiosExists(teacherRatios.Ncessch))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeacherRatios", new { id = teacherRatios.Ncessch }, teacherRatios);
        }

        // DELETE: api/TeacherRatios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherRatios>> DeleteTeacherRatios(decimal id)
        {
            var teacherRatios = await _context.TeacherRatios.FindAsync(id);
            if (teacherRatios == null)
            {
                return NotFound();
            }

            _context.TeacherRatios.Remove(teacherRatios);
            await _context.SaveChangesAsync();

            return teacherRatios;
        }

        private bool TeacherRatiosExists(decimal id)
        {
            return _context.TeacherRatios.Any(e => e.Ncessch == id);
        }
    }
}
