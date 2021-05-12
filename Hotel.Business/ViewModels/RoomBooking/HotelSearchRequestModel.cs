namespace Business.ViewModels.RoomBooking
{
    public class HotelSearchRequestModel
    {
        public string Country { get; set; }

        public string City { get; set; }

        public int MinRoomPrice { get; set; }
    }
}
