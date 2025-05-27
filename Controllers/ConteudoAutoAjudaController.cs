using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeSpaceAPI.Domain.Entities;
using SafeSpaceAPI.Infrastructure.Context;

namespace SafeSpaceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConteudoAutoAjudaController : ControllerBase
    {
        private readonly SafeSpaceContext _context;

        public ConteudoAutoAjudaController(SafeSpaceContext context)
        {
            _context = context;
        }

        // GET: api/ConteudoAutoAjuda
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConteudoAutoAjuda>>> GetConteudoAutoAjuda()
        {
            return await _context.ConteudoAutoAjuda.ToListAsync();
        }

        // GET: api/ConteudoAutoAjuda/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConteudoAutoAjuda>> GetConteudoAutoAjuda(Guid id)
        {
            var conteudoAutoAjuda = await _context.ConteudoAutoAjuda.FindAsync(id);

            if (conteudoAutoAjuda == null)
            {
                return NotFound();
            }

            return conteudoAutoAjuda;
        }

        // PUT: api/ConteudoAutoAjuda/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConteudoAutoAjuda(Guid id, ConteudoAutoAjuda conteudoAutoAjuda)
        {
            if (id != conteudoAutoAjuda.Id)
            {
                return BadRequest();
            }

            _context.Entry(conteudoAutoAjuda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConteudoAutoAjudaExists(id))
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

        // POST: api/ConteudoAutoAjuda
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConteudoAutoAjuda>> PostConteudoAutoAjuda(ConteudoAutoAjuda conteudoAutoAjuda)
        {
            _context.ConteudoAutoAjuda.Add(conteudoAutoAjuda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConteudoAutoAjuda", new { id = conteudoAutoAjuda.Id }, conteudoAutoAjuda);
        }

        // DELETE: api/ConteudoAutoAjuda/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConteudoAutoAjuda(Guid id)
        {
            var conteudoAutoAjuda = await _context.ConteudoAutoAjuda.FindAsync(id);
            if (conteudoAutoAjuda == null)
            {
                return NotFound();
            }

            _context.ConteudoAutoAjuda.Remove(conteudoAutoAjuda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConteudoAutoAjudaExists(Guid id)
        {
            return _context.ConteudoAutoAjuda.Any(e => e.Id == id);
        }
    }
}
