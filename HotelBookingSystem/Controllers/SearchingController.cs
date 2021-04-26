using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Business.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchingController : ControllerBase
    {
        private readonly ISearchingService _searchingService;
        private readonly IMapper _mapper;

        public SearchingController(ISearchingService searchingService, IMapper mapper)
        {
            _searchingService = searchingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetHotelsByName(string hotelName)
        {
            return Ok(_mapper.Map<Hotel>(_searchingService.GetHotelsByName(hotelName)));
        }

        [HttpGet]
        public IActionResult GetHotelsByStarsCount (int starsCount)
        {
            return Ok(_mapper.Map<Hotel>(_searchingService.GetHotelsByStarsCount(starsCount)));
        }

        [HttpGet]
        public IActionResult GetHotelsByCountry(string hotelCountry)
        {
            return Ok(_mapper.Map<Hotel>(_searchingService.GetHotelsByCountry(hotelCountry)));
        }

        [HttpGet]
        public IActionResult GetHotelsByCity(string hotelCity)
        {
            return Ok(_mapper.Map<Hotel>(_searchingService.GetHotelsByCity(hotelCity)));
        }

        [HttpGet]
        public IActionResult GetHotelsByPrice(int priceFrom, int priceTo)
        {
            return Ok(_mapper.Map<Hotel>(_searchingService.GetHotelsByPrice(priceFrom, priceTo)));
        }
    }
}
