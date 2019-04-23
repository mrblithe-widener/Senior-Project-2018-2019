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
   }
}
