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
    public class AgendamentoController : ControllerBase
    {
        private readonly SafeSpaceContext _context;

        public AgendamentoController(SafeSpaceContext context)
        {
            _context = context;
        }

        // GET: api/Agendamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agendamento>>> GetAgendamento()
        {
            return await _context.Agendamento.ToListAsync();
        }

        // GET: api/Agendamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agendamento>> GetAgendamento(Guid id)
        {
            var agendamento = await _context.Agendamento.FindAsync(id);

            if (agendamento == null)
            {
                return NotFound();
            }

            return agendamento;
        }

        // PUT: api/Agendamento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamento(Guid id, Agendamento agendamento)
        {
            if (id != agendamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(agendamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendamentoExists(id))
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

        // POST: api/Agendamento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Agendamento>> PostAgendamento(Agendamento agendamento)
        {
            _context.Agendamento.Add(agendamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgendamento", new { id = agendamento.Id }, agendamento);
        }

        // DELETE: api/Agendamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamento(Guid id)
        {
            var agendamento = await _context.Agendamento.FindAsync(id);
            if (agendamento == null)
            {
                return NotFound();
            }

            _context.Agendamento.Remove(agendamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendamentoExists(Guid id)
        {
            return _context.Agendamento.Any(e => e.Id == id);
        }
    }
}
