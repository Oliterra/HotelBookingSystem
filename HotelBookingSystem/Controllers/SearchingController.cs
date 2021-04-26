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
        private readonly IHotelsSearchService _hotelsSearchService;
        private readonly IMapper _mapper;

        public SearchingController(IHotelsSearchService hotelsSearchService, IMapper mapper)
        {
            _hotelsSearchService = hotelsSearchService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Search(HotelSearchRequestModel searchModel)
        {
            
            // List<HotelEntity>.select(x=> _mapper.Map<Hotel>(x)) -> List<Hotel>


            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.Find(new HotelsSearchModel())));
        }

        [HttpGet]
        public IActionResult GetHotelsByName(string hotelName)
        {
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.GetHotelsByName(hotelName)));
        }

        [HttpGet]
        public IActionResult GetHotelsByStarsCount (int starsCount)
        {
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.GetHotelsByStarsCount(starsCount)));
        }

        [HttpGet]
        public IActionResult GetHotelsByCountry(string hotelCountry)
        {
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.GetHotelsByCountry(hotelCountry)));
        }

        [HttpGet]
        public IActionResult GetHotelsByCity(string hotelCity)
        {
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.GetHotelsByCity(hotelCity)));
        }

        [HttpGet]
        public IActionResult GetHotelsByPrice(int priceFrom, int priceTo)
        {
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.GetHotelsByPrice(priceFrom, priceTo)));
        }
    }

    public class HotelSearchRequestModel
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Name { get; set; }
    }
}
