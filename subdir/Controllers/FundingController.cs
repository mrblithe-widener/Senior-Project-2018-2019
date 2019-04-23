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
    public class FundingController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public FundingController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Funding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funding>>> GetFunding()
        {
            return await _context.Funding.ToListAsync();
        }

        // GET: api/Funding/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Funding>> GetFunding(string id)
        {
            var funding = await _context.Funding.FindAsync(id);

            if (funding == null)
            {
                return NotFound();
            }

            return funding;
        }
    }
}
