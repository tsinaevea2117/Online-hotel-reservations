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

        public static readonly string WorkGroup = GetWorkGroup();// ��� ������� ������ ����������, � �������� �������������� ���� � ������

        public static ApplicationContext DB = new ApplicationContext();

        public static AdminForm AF;
        public static SupervisorForm SF;
        public static ClientsForm CF;
        public static ManagerForm MF;
        public static ReservationForm RF;
        public static ChangeDateForm ChangeDateForm;

        private static string GetWorkGroup()
        {
            /* � ������������ debug ���� ����� ����� ���������� ��������� ��� �������� ������� ������ ��� ������������ ���������.
             � ������������ release ���� ����� ����� ���������� �������� �������� ������� ������ ��� ������������������� ������ ���������. */
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