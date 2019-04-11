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
   }
}
