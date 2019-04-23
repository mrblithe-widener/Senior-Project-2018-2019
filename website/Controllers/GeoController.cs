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
    }
}
