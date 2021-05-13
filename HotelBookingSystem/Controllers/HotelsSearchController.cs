using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Business.ViewModels;
using Business.ViewModels.RoomBooking;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsSearchController : ControllerBase
    {
        private readonly IHotelsSearchService _hotelsSearchService;
        private readonly IMapper _mapper;
        private readonly ILogger<HotelsSearchController> _logger;

        public HotelsSearchController(IHotelsSearchService hotelsSearchService, IMapper mapper, ILogger<HotelsSearchController> logger)
        {
            _hotelsSearchService = hotelsSearchService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelsByParameters(HotelSearchRequestModel searchModel)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"There is some error in the {searchModel}");
            }

            // List<HotelEntity>.select(x=> _mapper.Map<Hotel>(x)) -> List<Hotel>
            return Ok(_mapper.Map<Hotel>(_hotelsSearchService.Find(new HotelsSearchModel())));
        }
    }
}
