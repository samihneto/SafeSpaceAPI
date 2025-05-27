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
    public class UsuarioSSController : ControllerBase
    {
        private readonly SafeSpaceContext _context;

        public UsuarioSSController(SafeSpaceContext context)
        {
            _context = context;
        }

        // GET: api/UsuarioSS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioSS>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/UsuarioSS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioSS>> GetUsuarioSS(Guid id)
        {
            var usuarioSS = await _context.Usuarios.FindAsync(id);

            if (usuarioSS == null)
            {
                return NotFound();
            }

            return usuarioSS;
        }

        // PUT: api/UsuarioSS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioSS(Guid id, UsuarioSS usuarioSS)
        {
            if (id != usuarioSS.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuarioSS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioSSExists(id))
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

        // POST: api/UsuarioSS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioSS>> PostUsuarioSS(UsuarioSS usuarioSS)
        {
            _context.Usuarios.Add(usuarioSS);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuarioSS", new { id = usuarioSS.Id }, usuarioSS);
        }

        // DELETE: api/UsuarioSS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioSS(Guid id)
        {
            var usuarioSS = await _context.Usuarios.FindAsync(id);
            if (usuarioSS == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuarioSS);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioSSExists(Guid id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
