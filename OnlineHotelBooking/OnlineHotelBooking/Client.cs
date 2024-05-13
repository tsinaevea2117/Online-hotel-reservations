using System.ComponentModel.DataAnnotations;

namespace OnlineHotelBooking
{
    public class Client
    {
        [Key]
        public string Passport { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? FatherName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? MobileNum { get; set; }
        public int? PhotoId { get; set; }

        // конструктор клиента, когда его регистрирует менеджер
        public Client(string passport, string lastName, string firstName, string fatherName)
        {
            Passport = passport;
            LastName = lastName;
            FirstName = firstName;
            FatherName = fatherName;
        }

        // конструктор клиента, самостоятельная регистрация
        public Client(string passport, string lastName, string firstName, string fatherName, string password)
        {
            Passport = passport;
            LastName = lastName;
            FirstName = firstName;
            FatherName = fatherName;
            Password = password;
            IssueLogin();
        }

        // Логин имеет формат ФамилияИО. Если в базе клиентов есть такой же логин, то в конце прибавляется чмсло, например, ФамилияИО1
        public void IssueLogin()
        {
            string login = $"{LastName}{FirstName[0]}{(String.IsNullOrEmpty(FatherName) ? "" : FatherName[0])}";
            int identicalLoginsCount = Program.DB.Clients.Where(t => t.Login == login).Count();
            Login = identicalLoginsCount == 0 ? login : $"{login}{identicalLoginsCount}";
        }
    }
}
