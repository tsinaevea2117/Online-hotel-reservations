namespace OnlineHotelBooking
{
    internal class HotelReservationTable
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string ClientId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public ReservationStatus Status { get; set; }

        public HotelReservationTable(int hotelId, int roomId, string clientId, DateTime checkInDate, DateTime checkOutDate, ReservationStatus status)
        {
            HotelId = hotelId;
            RoomId = roomId;
            ClientId = clientId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }
    }

    enum ReservationStatus
    {
        Забронировано = 0,
        Проживание,
        Завершено,
        Отменено
    }
}
