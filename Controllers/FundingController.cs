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

        // PUT: api/Funding/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFunding(string id, Funding funding)
        {
            if (id != funding.Ncesid)
            {
                return BadRequest();
            }

            _context.Entry(funding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FundingExists(id))
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

        // POST: api/Funding
        [HttpPost]
        public async Task<ActionResult<Funding>> PostFunding(Funding funding)
        {
            _context.Funding.Add(funding);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FundingExists(funding.Ncesid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFunding", new { id = funding.Ncesid }, funding);
        }

        // DELETE: api/Funding/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Funding>> DeleteFunding(string id)
        {
            var funding = await _context.Funding.FindAsync(id);
            if (funding == null)
            {
                return NotFound();
            }

            _context.Funding.Remove(funding);
            await _context.SaveChangesAsync();

            return funding;
        }

        private bool FundingExists(string id)
        {
            return _context.Funding.Any(e => e.Ncesid == id);
        }
    }
}
