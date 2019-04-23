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
        [HttpGet("SearchZip/{zip}")]
        public async Task<ActionResult<IEnumerable<Index>>> SearchZip(string zip)
        {
            decimal zipcode;
            if (!decimal.TryParse(zip, out zipcode))
                return BadRequest();
            return await _context.Index.Where(x => x.Zip.HasValue && x.Zip.Value == zipcode).ToListAsync();
        }
        [HttpGet("SearchName/{name}")]
        public async Task<ActionResult<IEnumerable<Index>>> SearchName(string name)
        {
            string name_lower = name.ToLower();
            return await _context.Index.Where(x => x.Name.ToLower().Contains(name_lower)).Take(10).ToListAsync();
        }
    }
}
