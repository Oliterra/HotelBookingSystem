/*using System;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Business.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Policy;

namespace WebAPI.Controllers.Admin
{
    [Authorize(Policy = Policies.SuperOnly)]
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalServiceController : ControllerBase
    {
        private readonly IAdditionalServiceService _addServ;
        private readonly IMapper _mapper;

        public AdditionalServiceController(IAdditionalServiceService addServ, IMapper mapper)
        {
            _addServ = addServ;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getAdditionalServices/{id}")]
        public async Task<IActionResult> GetAdditionalServices([FromRoute] Guid id)
        {
            AdditionalServiceModel additionalService = await _addServ.GetAdditionalService(id);
            return Ok(_mapper.Map<AdditionalService>(additionalService));
        }

        [HttpPost]
        [Route("addAdditionalService")]
        public async Task<IActionResult> AddAdditionalService([FromBody] AdditionalService addAddServ)
        {
            await _addServ.AddAdditionalService(_mapper.Map<AdditionalServiceModel>(addAddServ));
            return Created("", new { Message = "Additional service was added" });
        }

        [HttpDelete]
        [Route("deleteAdditionalService/{id}")]
        public async Task<IActionResult> DeleteAdditionalService([FromRoute] Guid id)
        {
            await _addServ.DeleteAdditionalService(id);
            return NoContent();
        }

        [HttpPatch]
        [Route("updateAdditionalService/{id}")]
        public async Task<IActionResult> UpdateAdditionalService([FromRoute] Guid id, [FromBody] AdditionalService updatedAdditionalService)
        {
            await _addServ.UpdateAdditionalService(id, _mapper.Map<AdditionalServiceModel>(updatedAdditionalService));
            return NoContent();
        }
    }
}*/
