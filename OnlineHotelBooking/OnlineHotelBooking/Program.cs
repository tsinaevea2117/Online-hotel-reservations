using System.Management;

namespace OnlineHotelBooking
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }

        public static readonly string WorkGroup = GetWorkGroup();// имя рабочей группы компьютера, с которого осуществляется вход в сервис

        public static ApplicationContext DB = new ApplicationContext();

        public static AdminForm AF;
        public static SupervisorForm SF;
        public static ClientsForm CF;
        public static ManagerForm MF;
        public static ReservationForm RF;
        public static ChangeDateForm ChangeDateForm;

        private static string GetWorkGroup()
        {
            /* в конфигурации debug этот метод будет возвращать требуемое нам значение рабочей группы для тестирования программы.
             в конфигурации release этот метод будет возвращать истинное значение рабочей группы для полнофункциональной работы программы. */
#if DEBUG
            //return "OnlineHotelBooking";
            return "home";
             //return "OHB_msk";
#endif
            ManagementObject computer_system = new ManagementObject(string.Format("Win32_ComputerSystem.Name='{0}'", Environment.MachineName));
            return (string)computer_system["Workgroup"];
        }
    }
}