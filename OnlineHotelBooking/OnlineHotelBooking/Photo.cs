namespace OnlineHotelBooking
{
    internal class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public Photo(byte[] image)
        {
            Image = image;
        }
    }
}
