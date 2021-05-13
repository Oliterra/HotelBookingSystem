using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Business.Services;
using Business.ViewModels;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Policy;

namespace WebAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;

        public HotelController(IHotelService hotelService, IMapper mapper)
        {
            _hotelService = hotelService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            var hotels = await _hotelService.GetAllHotels();

            return Ok(hotels
                .Select(h => _mapper.Map<Hotel>(h))
                .AsQueryable());
        }

        [HttpGet]
        [Route("getHotel")]
        public async Task<IActionResult> GetHotel([FromRoute] Guid id)
        {
            HotelModel hotel = await _hotelService.GetHotel(id);
            return Ok(_mapper.Map<Hotel>(hotel));
        }

        [HttpPost]
        [Route("addHotel")]
        public async Task<IActionResult> AddHotel([FromBody] Hotel addHotel)
        {
            await _hotelService.AddHotel(_mapper.Map<HotelModel>(addHotel));
            return Created("", new { Message = "Hotel was added" });
        }

        [HttpDelete]
        [Route("deleteHotel/{id}")]
        public async Task<IActionResult> DeleteHotel([FromRoute] Guid id)
        {
            await _hotelService.DeleteHotel(id);
            return NoContent();
        }

        [HttpPatch]
        [Route("updateHotel/{id}")]
        public async Task<IActionResult> UpdateHotel([FromRoute] Guid id, [FromBody] Hotel updatedHotel)
        {
            await _hotelService.UpdateHotel(id, _mapper.Map<HotelModel>(updatedHotel));
            return NoContent();
        }
    }
}
