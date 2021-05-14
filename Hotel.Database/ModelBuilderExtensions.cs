using System;
using System.Collections.Generic;
using System.Text;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<HotelEntity>().HasData(

                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Fitzrovia Hotel",
                    StarsNumber = 4,
                    Country = "Great Britan",
                    City = "London",
                    MinRoomPrice = 99,
                    Address = "20-28 Bolsover Street, Westminster, London, W1W 5NB, United Kingdom",
                    IsFavorite = false,
                    IsFreeRooms = true
                },
                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Scandic Ishavshotel",
                    StarsNumber = 4,
                    Country = "Norway",
                    City = "Tromso",
                    MinRoomPrice = 165,
                    Address = "Fredrik Langesgt. 2, 9250 Tromso, Norway",
                    IsFavorite = false,
                    IsFreeRooms = true
                },

                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Elysées Ceramic",
                    StarsNumber = 3,
                    Country = "France",
                    City = "Paris",
                    MinRoomPrice = 93,
                    Address = "34, Avenue de Wagram, 8th arrondissement: Champs - Elysees, 75008 Paris, France",
                    IsFavorite = false,
                    IsFreeRooms = true
                },

                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Park Inn by Radisson Berlin Alexanderplatz",
                    StarsNumber = 4,
                    Country = "Germany",
                    City = "Berlin",
                    MinRoomPrice = 136,
                    Address = "Alexanderplatz 7, Mitte, 10178 Berlin, Germany",
                    IsFavorite = false,
                    IsFreeRooms = true
                },

                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Fiesta Americana Guadalajara",
                    StarsNumber = 4,
                    Country = "Mexico",
                    City = "Guadalajara",
                    MinRoomPrice = 42,
                    Address = "Avenida Aurelio Aceves Numero 225 Colonia Vallarte Poniente, 43110 Guadalajara, Mexico",
                    IsFavorite = false,
                    IsFreeRooms = true
                }
            );
        }
    }
}
