using System.Data;

namespace OnlineHotelBooking
{
    public partial class ReservationForm : Form
    {
        public static DateTime InDate;
        public static DateTime OutDate;
        public static DataGridView DGmatchingRoom;
        public int RowIndex;
        public static DataGridView DGactiveReserv;
        public static int HotelId;
        public static int RoomId;

        public ReservationForm(DateTime inDate, DateTime outDate, DataGridView dgMatchingRoom, int rowIndex, DataGridView dgActiveReserv,int hotelId, int roomId)
        {
            InitializeComponent();
            InDate = inDate;
            OutDate = outDate;
            DGmatchingRoom = dgMatchingRoom;
            RowIndex = rowIndex;
            DGactiveReserv = dgActiveReserv;
            HotelId = hotelId;
            RoomId = roomId;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            if (InDate.Date == DateTime.Today)
                prepaymentCheckBox.Enabled = false;
            else
                fullPaymentCheckBox.Enabled = false;
        }

        private void prepaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            reservButton.Enabled = prepaymentCheckBox.Checked;
        }

        private void fullPaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInButton.Enabled = fullPaymentCheckBox.Checked;
        }

        private void reservButton_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "" || firstNametextBox.Text == "" || (passportMTB.Text.Where(c => Char.IsDigit(c)).Count() < 10))
            {
                MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CheckIn(ReservationStatus.Забронировано);
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "" || firstNametextBox.Text == "" || (passportMTB.Text.Where(c => Char.IsDigit(c)).Count() < 10))
            {
                MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CheckIn(ReservationStatus.Проживание);
        }

        private void CheckIn(ReservationStatus status)
        {
            // если посетителя нет в базе - добавляем
            if (Program.DB.Clients.Count() < 0 || Program.DB.Clients.Where(t => t.Passport == passportMTB.Text).ToList().Count() == 0)
            {
                Program.DB.Clients.Add(new Client(passportMTB.Text, lastNameTextBox.Text, firstNametextBox.Text, fatherNametextBox.Text));
                Program.DB.SaveChanges();
            }

            Program.DB.HotelsReservationTable.Add(new HotelReservationTable(HotelId, RoomId, passportMTB.Text, InDate, OutDate, status) );

            Room room = Program.DB.Rooms.Where(t => t.Id == RoomId).ToList()[0];
            int price = room.Price;
            int prepayment = Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == HotelId && t.Category == room.RoomType).ToList()[0].Prepayment;
            int dayCount = (int)(OutDate.Date - InDate.Date).TotalDays;

            if (status == ReservationStatus.Забронировано)
            {
                Program.DB.Balance.Add(new Balance(HotelId, DateTime.Today.ToString("dd.MM.yyyy"), "Бронирование", (price * dayCount) / 100 * prepayment, Program.DB.Balance.Where(t=>t.HotelId == HotelId).ToList().Last().Sum + (price * dayCount) / 100 * prepayment));
                MessageBox.Show("Бронирование осуществлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Program.DB.Balance.Add(new Balance(HotelId, DateTime.Today.ToString("dd.MM.yyyy"), "Заселение день в день", price * dayCount, Program.DB.Balance.Where(t => t.HotelId == HotelId).ToList().Last().Sum + price * dayCount));
                MessageBox.Show("Заселение осуществлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Program.DB.SaveChanges();
            DGactiveReserv.Rows.Add([(int)DGmatchingRoom[0, RowIndex].Value, $"{lastNameTextBox.Text} {firstNametextBox.Text}", InDate.ToString("dd.MM.yyyy"), OutDate.ToString("dd.MM.yyyy"), status]);
            DGmatchingRoom.Rows.RemoveAt(RowIndex);
            Close();
        }
    }
}
