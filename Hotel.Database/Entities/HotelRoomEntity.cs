namespace Hotel.Database.Entities
{
    public class HotelRoomEntity
    {
        public int Id { get; set; }
        public string HotelCorpus { get; set; }
        public int RoomsCount { get; set; }
        public string RoomType { get; set; }
        public int Area { get; set; }
        public int Price { get; set; }
        public int Floor { get; set; }
        public string Facilities { get; set; }
        public string FurnitureType { get; set; }
        public string BedCount { get; set; }
        public string BedType { get; set; }
        public string ViewFromTheWindow { get; set; }
        public bool IsForChildren {get; set;}
        public bool IsFree { get; set; }
    }
}
