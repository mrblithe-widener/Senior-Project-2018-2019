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
    }
}
