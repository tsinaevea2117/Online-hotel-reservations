namespace OnlineHotelBooking
{
    internal class Balance
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string OperationDate { get; set; }
        public string OperationName { get; set; }
        public int OperationPrice { get; set; }
        public int Sum { get; set; }

        public Balance(int hotelId, string operationDate, string operationName, int operationPrice, int sum)
        {
            HotelId = hotelId;
            OperationDate = operationDate;
            OperationName = operationName;
            OperationPrice = operationPrice;
            Sum = sum;
        }
    }
}