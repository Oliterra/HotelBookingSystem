/*using Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    internal sealed class Configuration : DbMigrationsConfiguration<HotelContext>

    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(HotelContext context)
        {
            if (!context.Hotels.Any())

            {
                var hotels = new List<HotelEntity>
                {
                    new HotelEntity
                    {
                        Name = "Fitzrovia Hotel",
                        StarsCount = 4,
                        Country = "Great Britan",
                        City = "London",
                        PriceFrom = 99,
                        PriceTo = 192,
                        Address = "20-28 Bolsover Street, Westminster, London, W1W 5NB, United Kingdom",
                        IsFavorite = false,
                        IsFreeRooms = true
                    },

                    new HotelEntity
                    {
                        Name = "Scandic Ishavshotel",
                        StarsCount = 4,
                        Country = "Norway",
                        City = "Tromso",
                        PriceFrom = 165,
                        PriceTo = 198,
                        Address = "Fredrik Langesgt. 2, 9250 Tromso, Norway",
                        IsFavorite = false,
                        IsFreeRooms = true
                    },

                    new HotelEntity
                    {
                        Name = "Elysées Ceramic",
                        StarsCount = 3,
                        Country = "France",
                        City = "Paris",
                        PriceFrom = 93,
                        PriceTo = 249,
                        Address = "34, Avenue de Wagram, 8th arrondissement: Champs - Elysees, 75008 Paris, France",
                        IsFavorite = false,
                        IsFreeRooms = true
                    },

                    new HotelEntity
                    {
                        Name = "Park Inn by Radisson Berlin Alexanderplatz",
                        StarsCount = 4,
                        Country = "Germany",
                        City = "Berlin",
                        PriceFrom = 136,
                        PriceTo = 323,
                        Address = "Alexanderplatz 7, Mitte, 10178 Berlin, Germany",
                        IsFavorite = false,
                        IsFreeRooms = true
                    },

                    new HotelEntity
                    {
                        Name = "Fiesta Americana Guadalajara",
                        StarsCount = 4,
                        Country = "Mexico",
                        City = "Guadalajara",
                        PriceFrom = 42,
                        PriceTo = 233,
                        Address = "Avenida Aurelio Aceves Numero 225 Colonia Vallarte Poniente, 43110 Guadalajara, Mexico",
                        IsFavorite = false,
                        IsFreeRooms = true
                    },
                    context.SaveChanges();
                }
            }
        }
    }
}
*/
