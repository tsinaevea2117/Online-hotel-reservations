namespace OnlineHotelBooking
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkGroup { get; set; }

        public Hotel()
        { }

        public Hotel(string name, string address, string workGroup)
        {
            Name = name;
            Address = address;
            WorkGroup = workGroup;
        }
    }
}
