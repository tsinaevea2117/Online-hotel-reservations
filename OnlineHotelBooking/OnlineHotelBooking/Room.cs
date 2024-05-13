namespace OnlineHotelBooking
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int Number { get; set; }
        public RoomType RoomType { get; set; }
        public int Сapacity { get; set; }// вместимость, чел.
        public int Price { get; set; }// цена за сутки

        public Room() { }

        public Room(int hotelId, int number, RoomType roomType, int сapacity, int price)
        {
            HotelId = hotelId;
            Number = number;
            RoomType = roomType;
            Сapacity = сapacity;
            Price = price;
        }
    }

    public enum RoomType
    {
        Эконом = 0,
        Стандарт,
        Комфорт,
        Люкс
    }

}
