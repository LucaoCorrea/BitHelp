using BitHelpAPI.Data;
using BitHelpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BitHelpAPI.Controllers
{
    [ApiController]
    [Route("api/ticket/[controller]")]
    public class TicketController : ControllerBase
    {

        private readonly AppDbContext _context; 

        public TicketController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] TicketModel ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ticket.CreatedAt = DateTime.UtcNow;
            ticket.UpdatedAt = DateTime.UtcNow;

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = ticket.Id }, ticket);
        }

        [HttpPost("{id}")]
        public IActionResult GetById(int id)
        {
            var ticket = _context.Tickets.Find(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
