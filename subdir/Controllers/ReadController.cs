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
    }
}
