namespace OnlineHotelBooking
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public bool BalanceAccess { get; set; } = false;
        public string? MobileNum { get; set; }// мобильный номер пользователя с правами "администратор" для получения кода для входа
        public int? HotelId { get; set; }

        public User() { }


        // конструктор для администратора
        public User(string login, string password, UserType userType, string mobileNum)
        {
            Login = login;
            Password = password;
            UserType = userType;
            MobileNum = mobileNum;
        }

        // конструктор для управляющего
        public User(string login, string password, UserType userType, int? hotelId)
        {
            Login = login;
            Password = password;
            UserType = userType;
            HotelId = hotelId;
        }

        // конструктор длч менеджера
        public User(string login, string password, UserType userType, int? hotelId, bool balanceAccess)
        {
            Login = login;
            Password = password;
            UserType = userType;
            HotelId = hotelId;
            BalanceAccess = balanceAccess;
        }
    }

    internal enum UserType
    {
        Администратор = 0,
        Управлюящий,
        Менеджер
    }
}
