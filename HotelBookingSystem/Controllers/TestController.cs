using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly HotelContext _context;
        public TestController(HotelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelEntity>>> GetHotelEntity()
        {
            return await _context.Hotels.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelEntity>> GetHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(Guid id, HotelEntity hotel)
        {
            hotel.Id = id;

            _context.Entry(hotel).State = EntityState.Modified;

            await _context.SaveChangesAsync();
                
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<HotelEntity>> PostDCandidate(HotelEntity hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<HotelEntity>> DeleteHotel(Guid id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

            return hotel;
        }
    }
}

