using System.Data;

namespace OnlineHotelBooking
{
    public partial class ChangeDateForm : Form
    {
        public static DataGridView DG;
        public int RowIndex;
        public Hotel Hotel;
        public int RoomNumColumnIndex;

        public ChangeDateForm(DataGridView dg, int rowIndex, Hotel hotel, int roomNumColumnIndex)
        {
            InitializeComponent();
            DG = dg;
            RowIndex = rowIndex;
            Hotel = hotel;
            RoomNumColumnIndex = roomNumColumnIndex;
        }

        private void ChangeDateForm_Load_1(object sender, EventArgs e)
        {
            inDateTimePicker.Value = inDateTimePicker.MinDate = inDateTimePicker.MaxDate = DateTime.Parse((string)DG[2, RowIndex].Value);
            outDateTimePicker.Value = outDateTimePicker.MinDate = outDateTimePicker.MaxDate = DateTime.Parse((string)DG[3, RowIndex].Value);

            inMonthCalendar.MaxDate = outDateTimePicker.Value.AddDays(-1);
            outMonthCalendar.MinDate = inDateTimePicker.Value.AddDays(1);

            List<DateTime> boldDate = new List<DateTime>();
            for (DateTime date = inDateTimePicker.Value; date <= outDateTimePicker.Value; date = date.AddDays(1))
                boldDate.Add(date);

            inMonthCalendar.BoldedDates = outMonthCalendar.BoldedDates = boldDate.ToArray();

            Room room = Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == (int)DG[RoomNumColumnIndex, RowIndex].Value).ToList()[0];

            DateTime maxOutDayBeforeCurentInDay = Program.DB.HotelsReservationTable
              .Where(t => t.RoomId == room.Id)
              .Select(r => r.CheckOutDate)
              .Where(q => q.Date < inDateTimePicker.Value)
              .OrderBy(y => y.Date)
              .LastOrDefault();

            if (maxOutDayBeforeCurentInDay.Year != 1)
                inMonthCalendar.MinDate = maxOutDayBeforeCurentInDay;
            else
                inMonthCalendar.MinDate = DateTime.Today;

            DateTime minInDayAfterCurentOutDay = Program.DB.HotelsReservationTable
                .Where(t => t.RoomId == room.Id)
                .Select(r => r.CheckInDate)
                .Where(q => q.Date > outDateTimePicker.Value)
                .OrderBy(y => y.Date)
                .FirstOrDefault();

            if (minInDayAfterCurentOutDay.Year != 1)
                outMonthCalendar.MaxDate = minInDayAfterCurentOutDay;
        }

        private void changeDateButton_Click_1(object sender, EventArgs e)
        {
            Room room = Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == (int)DG[RoomNumColumnIndex, RowIndex].Value).ToList()[0];

            HotelReservationTable entryTable = Program.DB.HotelsReservationTable.Where(t => t.RoomId == room.Id && t.CheckInDate.Date == DateTime.Parse((string)DG[2, RowIndex].Value)).ToList()[0];
            entryTable.CheckInDate = inMonthCalendar.SelectionRange.Start;
            entryTable.CheckOutDate = outMonthCalendar.SelectionRange.Start;
            DG[2, RowIndex].Value = entryTable.CheckInDate.ToString("dd.MM.yyyy");
            DG[3, RowIndex].Value = entryTable.CheckOutDate.ToString("dd.MM.yyyy");
            Program.DB.SaveChanges();
            MessageBox.Show("Даты мзменены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
