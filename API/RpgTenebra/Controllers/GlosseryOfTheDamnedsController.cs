using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgTenebra.Models;
using RpgTenebra.Models.VampireM5;

namespace RpgTenebra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlosseryOfTheDamnedsController : ControllerBase
    {
        private readonly TenebraContext _context;

        public GlosseryOfTheDamnedsController(TenebraContext context)
        {
            _context = context;
        }

        // GET: api/GlosseryOfTheDamneds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlosseryOfTheDamned>>> GetGlosseryOfTheDamned()
        {
            return await _context.GlosseryOfTheDamned.ToListAsync();
        }

        // GET: api/GlosseryOfTheDamneds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlosseryOfTheDamned>> GetGlosseryOfTheDamned(int id)
        {
            var glosseryOfTheDamned = await _context.GlosseryOfTheDamned.FindAsync(id);

            if (glosseryOfTheDamned == null)
            {
                return NotFound();
            }

            return glosseryOfTheDamned;
        }

        // PUT: api/GlosseryOfTheDamneds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlosseryOfTheDamned(int id, GlosseryOfTheDamned glosseryOfTheDamned)
        {
            if (id != glosseryOfTheDamned.GodId)
            {
                return BadRequest();
            }

            _context.Entry(glosseryOfTheDamned).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlosseryOfTheDamnedExists(id))
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

        // POST: api/GlosseryOfTheDamneds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GlosseryOfTheDamned>> PostGlosseryOfTheDamned(GlosseryOfTheDamned glosseryOfTheDamned)
        {
            _context.GlosseryOfTheDamned.Add(glosseryOfTheDamned);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlosseryOfTheDamned", new { id = glosseryOfTheDamned.GodId }, glosseryOfTheDamned);
        }

        // DELETE: api/GlosseryOfTheDamneds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GlosseryOfTheDamned>> DeleteGlosseryOfTheDamned(int id)
        {
            var glosseryOfTheDamned = await _context.GlosseryOfTheDamned.FindAsync(id);
            if (glosseryOfTheDamned == null)
            {
                return NotFound();
            }

            _context.GlosseryOfTheDamned.Remove(glosseryOfTheDamned);
            await _context.SaveChangesAsync();

            return glosseryOfTheDamned;
        }

        private bool GlosseryOfTheDamnedExists(int id)
        {
            return _context.GlosseryOfTheDamned.Any(e => e.GodId == id);
        }
    }
}
