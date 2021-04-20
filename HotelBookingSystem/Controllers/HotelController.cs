using Business.Interfaces;
using Business.Models;
using Business.Services;
using HotelBookingSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Serilog;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        private readonly ILogger<HotelController> _logger;
        
        public HotelController(IHotelService hotelService, ILogger<HotelController> logger)
        {
            _hotelService = hotelService;
            _logger = logger;
        }

        [Route("GetExceptioInfo")]
        [HttpGet]
        public IEnumerable<string> GetExeptionInfo() //экшн-метод, чтобы пробросить исключение
        {
            string[] arrRetValues = null;
            if (arrRetValues.Length > 0)
            {

            }
            return arrRetValues;
        }

        [HttpGet("{id}", Name = "GetHotelEntity")]
        public IActionResult Get(Guid hotelId)
        {
            HotelModel hotel = _hotelService.GetHotelById(hotelId);
            if (hotel == null)
            {
                _logger.LogWarning("Hotel is not found");
                return NotFound();
            }
            return new ObjectResult(hotel);
        }

        [HttpPost]
        public IActionResult Create([FromBody] HotelModel hotel)
        {
            if (hotel == null)
            {
                _logger.LogWarning("Hotel is not found");
                return BadRequest();
            }
            _hotelService.AddHotel(hotel);
            return CreatedAtRoute("GetHotelModel", new { id = hotel.Id}, hotel);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] HotelModel updatedHotel)
        {
            if (updatedHotel == null || updatedHotel.Id != id)
            {
                _logger.LogWarning("Hotel is not found");
                return BadRequest();
            }

            var hotel = _hotelService.Get(id);
            if (hotel == null)
            {
                _logger.LogWarning("Hotel is not found");
                return NotFound();
            }

            _hotelService.UpdateHotel(updatedHotel);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid hotelId)
        {
            var hotel = _hotelService.Get(hotelId);
            if (hotel == null)
            {
                _logger.LogWarning("Hotel is not found");
                return NotFound();
            }

            _hotelService.DeleteHotel(hotelId);
            return new NoContentResult();
        }
    }
}
