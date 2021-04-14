using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Database.Entities;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    public class HotelController : Controller // использует только интерфейс IHotelRepository, что позволяет изменить источник данных не меняя при этом контроллера
    {
        IHotelRepository HotelRepository;

        public HotelController(IHotelRepository hotelRepository)
        {
            HotelRepository = hotelRepository;
        }

        [HttpGet(Name = "GetAllItems")]
        public IEnumerable<HotelEntity> Get()
        {
            return HotelRepository.Get();
        }

        [HttpGet("{id}", Name = "GetHotelEntity")]
        public IActionResult Get(int Id)
        {
            HotelEntity hotelEntity = HotelRepository.Get(Id);

            if (hotelEntity == null)
            {
                return NotFound();
            }

            return new ObjectResult(hotelEntity);
        }

        [HttpPost]
        public IActionResult Create([FromBody] HotelEntity hotelEntity)
        {
            if (hotelEntity == null)
            {
                return BadRequest();
            }
            HotelRepository.Create(hotelEntity);
            return CreatedAtRoute("GetHotelEntity", new { id = hotelEntity.Id }, hotelEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int Id, [FromBody] HotelEntity updatedHotelEntity)
        {
            if (updatedHotelEntity == null || updatedHotelEntity.Id != Id)
            {
                return BadRequest();
            }

            var hotelEntity = HotelRepository.Get(Id);
            if (hotelEntity == null)
            {
                return NotFound();
            }

            HotelRepository.Update(updatedHotelEntity);
            return RedirectToRoute("GetAllItems");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var deletedHotelEntity = HotelRepository.Delete(Id);

            if (deletedHotelEntity == null)
            {
                return BadRequest();
            }

            return new ObjectResult(deletedHotelEntity);
        }
    }
}

