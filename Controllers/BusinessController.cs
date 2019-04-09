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
    public class BusinessController : ControllerBase
    {
        private readonly seniorprojectContext _context;

        public BusinessController(seniorprojectContext context)
        {
            _context = context;
        }

        // GET: api/Business
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> GetBussines()
        {
            return await _context.Bussines.ToListAsync();
        }

        // GET: api/Business/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Business>> GetBusiness(decimal id)
        {
            var business = await _context.Bussines.FindAsync(id);

            if (business == null)
            {
                return NotFound();
            }

            return business;
        }

        // PUT: api/Business/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusiness(decimal id, Business business)
        {
            if (id != business.ZipCode)
            {
                return BadRequest();
            }

            _context.Entry(business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessExists(id))
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

        // POST: api/Business
        [HttpPost]
        public async Task<ActionResult<Business>> PostBusiness(Business business)
        {
            _context.Bussines.Add(business);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BusinessExists(business.ZipCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBusiness", new { id = business.ZipCode }, business);
        }

        // DELETE: api/Business/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Business>> DeleteBusiness(decimal id)
        {
            var business = await _context.Bussines.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }

            _context.Bussines.Remove(business);
            await _context.SaveChangesAsync();

            return business;
        }

        private bool BusinessExists(decimal id)
        {
            return _context.Bussines.Any(e => e.ZipCode == id);
        }
    }
}
