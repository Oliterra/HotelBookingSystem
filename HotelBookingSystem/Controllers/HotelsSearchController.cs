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

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsSearchController : ControllerBase
    {
        private readonly IHotelsSearchService _hotelsSearchService;
        private readonly IMapper _mapper;

        public HotelsSearchController(IHotelsSearchService hotelsSearchService, IMapper mapper)
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
    }
}
