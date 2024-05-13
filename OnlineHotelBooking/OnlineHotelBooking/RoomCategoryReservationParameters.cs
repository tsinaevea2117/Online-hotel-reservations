namespace OnlineHotelBooking
{
    internal class RoomCategoryReservationParameters
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public RoomType Category { get; set; }// категория номера
        public int Prepayment { get; set; }// предоплата за номер; не возвращается после окончания срока бесплатной отмены
        public int FreeCancellationPeriod { get; set; }// срок бесплатной отмены

        public RoomCategoryReservationParameters(int hotelId, RoomType category, int prepayment, int freeCancellationPeriod)
        {
            HotelId = hotelId;
            Category = category;
            Prepayment = prepayment;
            FreeCancellationPeriod = freeCancellationPeriod;
        }
    }
}
