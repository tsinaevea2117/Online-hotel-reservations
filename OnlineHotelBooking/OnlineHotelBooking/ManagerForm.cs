using System.Data;

namespace OnlineHotelBooking
{
    public partial class ManagerForm : Form
    {
        Hotel Hotel;
        Room Room;

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        public ManagerForm(string login, Hotel hotel, bool balanceAccess)
        {
            InitializeComponent();
            Hotel = hotel;
            Text += $"{login} - {hotel.Name}";

            if (!balanceAccess)
                tabControl1.TabPages.RemoveAt(3);

            inDateTimePicker.MinDate = DateTime.Today;
            outDateTimePicker.MinDate = DateTime.Today.AddDays(1);
            inDateTimePicker.MaxDate = outDateTimePicker.MaxDate = DateTime.Today.AddDays(180);

            roomCategoryCheckedLB.DataSource = Enum.GetValues(typeof(RoomType));
            for (int i = 0; i < roomCategoryCheckedLB.Items.Count; roomCategoryCheckedLB.SetItemChecked(i++, true)) ;

            ((DataGridViewComboBoxColumn)DGmatchingRoom.Columns[4]).DataSource = Enum.GetValues(typeof(RoomType));
            ((DataGridViewComboBoxColumn)DGmatchingRoom.Columns[4]).ValueType = typeof(RoomType);

            ((DataGridViewComboBoxColumn)DGactiveReserv.Columns[4]).DataSource = Enum.GetValues(typeof(ReservationStatus));
            ((DataGridViewComboBoxColumn)DGactiveReserv.Columns[4]).ValueType = typeof(ReservationStatus);

            ((DataGridViewComboBoxColumn)DGarchive.Columns[4]).DataSource = Enum.GetValues(typeof(ReservationStatus));
            ((DataGridViewComboBoxColumn)DGarchive.Columns[4]).ValueType = typeof(ReservationStatus);

            List<HotelReservationTable> outDates = Program.DB.HotelsReservationTable.Where(t => t.Status == ReservationStatus.Проживание && t.CheckOutDate.Date < DateTime.Today.Date).ToList();
            for (int i = 0; i < outDates.Count; outDates[i++].Status = ReservationStatus.Завершено) ;
            Program.DB.SaveChanges();

            foreach (var entry in Program.DB.HotelsReservationTable.Where(t=>t.HotelId == Hotel.Id))
            {
                Client client = Program.DB.Clients.Where(t => t.Passport == entry.ClientId).ToList()[0];

                if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                {
                    DGactiveReserv.Rows.Add([
                        Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                }
                else// Отменено || Завершено
                {
                    DGarchive.Rows.Add([
                        Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                }
            }
        }

        private void inDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            outDateTimePicker.MinDate = inDateTimePicker.Value.AddDays(1);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (roomCategoryCheckedLB.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Укажите тип номера", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DGmatchingRoom.Rows.Clear();

            List<Room> matchingRooms = new List<Room>();

            foreach (Room room in Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id))
            {
                // если комната вместимостью не меньше требуемой и тип номера подходит
                if (room.Сapacity >= guestsCountNumericUpDown.Value && roomCategoryCheckedLB.CheckedItems.Contains(room.RoomType))
                {
                    // если в списке бронирований есть записи с этой комнатой
                    if (Program.DB.HotelsReservationTable.Count() > 0 && Program.DB.HotelsReservationTable.Where(t => t.RoomId == room.Id).ToArray().Count() > 0)
                    {
                        bool isFree = true;// изначально считаем комнату свободной
                        foreach (var entry in Program.DB.HotelsReservationTable.Where(t => t.RoomId == room.Id))
                        {
                            // но если в списке бронирований эта комната занята И пересекается с требуемыми датами
                            if ((entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание) &&
                                ((inDateTimePicker.Value >= entry.CheckInDate && inDateTimePicker.Value < entry.CheckOutDate) || (outDateTimePicker.Value > entry.CheckInDate && outDateTimePicker.Value <= entry.CheckOutDate)))
                            {
                                isFree = false;// значит комната занята
                                break;// прекращаем перебор записей с этой комнатой
                            }
                        }
                        if (!isFree)
                            continue;// и переходим к следующей комнате
                    }
                    // если в списке бронирований эта комната не фигурирует - значит свободна
                    matchingRooms.Add(room);
                }
            }

            if (matchingRooms.Count() > 0)
            {
                foreach (Room room in matchingRooms)
                    DGmatchingRoom.Rows.Add([ room.Number,
                        room.Сapacity,
                        room.Price * (int)(outDateTimePicker.Value.Date - inDateTimePicker.Value.Date).TotalDays,
                        room.Price / 100 * Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId==Hotel.Id && t.Category == room.RoomType).Select(t => t.Prepayment).ToList()[0] * (int)(outDateTimePicker.Value.Date - inDateTimePicker.Value.Date).TotalDays,
                        room.RoomType]);
            }
            else
                MessageBox.Show("Не нашлось номера по заданным параметрам", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DGmatchingRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Program.RF = new ReservationForm(inDateTimePicker.Value, outDateTimePicker.Value, DGmatchingRoom, e.RowIndex, DGactiveReserv, Hotel.Id, Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == (int)DGmatchingRoom[0, e.RowIndex].Value).Select(t => t.Id).ToList()[0]);
                Program.RF.ShowDialog();
            }
        }

        private void DGactiveReserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Room room = Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == (int)DGactiveReserv[0, e.RowIndex].Value).ToList()[0];

                HotelReservationTable entryTable = Program.DB.HotelsReservationTable.Where(t => t.RoomId == room.Id && t.CheckInDate.Date == DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value)).ToList()[0];

                if (e.ColumnIndex == 5)// заселение
                {
                    if (DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value) == DateTime.Today && (ReservationStatus)DGactiveReserv[4, e.RowIndex].Value == ReservationStatus.Забронировано)
                    {
                        if (MessageBox.Show("Подтвердить, что доплата произведена и заселить?", "Подтверждение заселения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DGactiveReserv[4, e.RowIndex].Value = ReservationStatus.Проживание;
                            entryTable.Status = ReservationStatus.Проживание;

                            //Room room = Program.DB.Rooms.Where(t => t.Id == Hotel.Id && t.Number == (int)DGactiveReserv[0, e.RowIndex].Value).ToList()[0];
                            int price = room.Price;
                            int prepayment = Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == Hotel.Id && t.Category == room.RoomType).ToList()[0].Prepayment;
                            int dayCount = (int)(DateTime.Parse((string)DGactiveReserv[3, e.RowIndex].Value).Date - DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value).Date).TotalDays;
                            Program.DB.Balance.Add(new Balance(Hotel.Id, DateTime.Today.ToString("dd.MM.yyyy"), "Доплата при заселении", (price - price / 100 * prepayment) * dayCount, Program.DB.Balance.Where(t => t.HotelId == Hotel.Id).ToList().Last().Sum + (price - price / 100 * prepayment) * dayCount));

                            Program.DB.SaveChanges();
                            MessageBox.Show("Заселение осуществлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            return;
                    }
                    else
                    {
                        if (entryTable.Status == ReservationStatus.Забронировано)
                            MessageBox.Show("Дата заселения еще не наступила", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (entryTable.Status == ReservationStatus.Проживание)
                            MessageBox.Show("Номер уже заселен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (e.ColumnIndex == 6)// отмена
                {
                    RoomType roomCategory = room.RoomType;

                    // бесплатный период отмены - возвращаем залог
                    if (DateTime.Today <= entryTable.CheckInDate.AddDays(-Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == Hotel.Id && t.Category == roomCategory).Select(r => r.FreeCancellationPeriod).ToList()[0]))
                    {
                        if (MessageBox.Show("Подтверждаете отмену бронирования?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            entryTable.Status = ReservationStatus.Отменено;
                            int price = room.Price;
                            int prepayment = Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == Hotel.Id && t.Category == room.RoomType).ToList()[0].Prepayment;
                            int dayCount = (int)(DateTime.Parse((string)DGactiveReserv[3, e.RowIndex].Value).Date - DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value).Date).TotalDays;
                            Program.DB.Balance.Add(new Balance(Hotel.Id, DateTime.Today.ToString("dd.MM.yyyy"), "Возврат предоплаты", -(price / 100 * prepayment) * dayCount, Program.DB.Balance.Where(t => t.HotelId == Hotel.Id).ToList().Last().Sum - (price / 100 * prepayment) * dayCount));

                            MessageBox.Show("Бронирование отменено до окончания срока бесплатной отмены.\nЗалог возвращен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            return;
                    }
                    else// платный период отмены - залог не возвращается
                    {
                        if (entryTable.Status == ReservationStatus.Забронировано)
                        {
                            if (MessageBox.Show("Подтверждаете отмену бронирования?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                entryTable.Status = ReservationStatus.Отменено;
                                MessageBox.Show("Бронирование отменено после окончания срока бесплатной отмены.\nЗалог не возвращен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                return;
                        }
                        else if (entryTable.Status == ReservationStatus.Проживание)
                        {
                            if (MessageBox.Show("Подтверждаете выезд?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                entryTable.Status = ReservationStatus.Завершено;
                                MessageBox.Show("Проживание завершено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                return;
                        }
                    }
                    Program.DB.SaveChanges();
                    DGarchive.Rows.Add([DGactiveReserv[0, e.RowIndex].Value, DGactiveReserv[1, e.RowIndex].Value, DGactiveReserv[2, e.RowIndex].Value, DGactiveReserv[3, e.RowIndex].Value, entryTable.Status]);
                    DGactiveReserv.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 7)// изменение дат
                {
                    Program.ChangeDateForm = new ChangeDateForm(DGactiveReserv, e.RowIndex, Hotel, 0);
                    Program.ChangeDateForm.ShowDialog();
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 3)
            {
                balanceLabel.Text = Program.DB.Balance.Where(t => t.HotelId == Hotel.Id).ToList().Last().Sum.ToString("0 000");
                DGbalance.Rows.Clear();

                foreach (Balance balance in Program.DB.Balance.Where(t => t.HotelId == Hotel.Id))
                    DGbalance.Rows.Add([balance.OperationDate, balance.OperationName, balance.OperationPrice, balance.Sum]);
            }
        }

        private void numFilterTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DGactiveReserv.Rows.Clear();

                if (numFilterTB.Text == "")
                {
                    foreach (var entry in Program.DB.HotelsReservationTable)
                    {
                        Client client = Program.DB.Clients.Where(t => t.Passport == entry.ClientId).ToList()[0];

                        if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                        {
                            DGactiveReserv.Rows.Add([
                                Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                        }
                    }
                }
                else
                {
                    int roomId = -1;
                    if (Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == Convert.ToInt32(numFilterTB.Text)).Count() != 0)
                        roomId = Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id && t.Number == Convert.ToInt32(numFilterTB.Text)).ToList()[0].Id;
                    else
                    {
                        DGactiveReserv.Rows.Clear();
                        return;
                    }


                    foreach (var entry in Program.DB.HotelsReservationTable.Where(t => t.RoomId == roomId))
                    {
                        Client client = Program.DB.Clients.Where(t => t.Passport == entry.ClientId).ToList()[0];

                        if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                        {
                            DGactiveReserv.Rows.Add([
                                Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                        }
                    }
                }
            }
        }

        private void clientFilterTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DGactiveReserv.Rows.Clear();

                if (clientFilterTB.Text == "")
                {
                    foreach (var entry in Program.DB.HotelsReservationTable)
                    {
                        Client client = Program.DB.Clients.Where(t => t.Passport == entry.ClientId).ToList()[0];

                        if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                        {
                            DGactiveReserv.Rows.Add([
                                Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                        }
                    }
                }
                else
                {
                    Client? client;

                    if (Program.DB.Clients.Where(t => t.LastName + " " + t.FirstName == clientFilterTB.Text).Count() != 0)
                        client = Program.DB.Clients.Where(t => t.LastName + " " + t.FirstName == clientFilterTB.Text).ToList()[0];
                    else
                    {
                        DGactiveReserv.Rows.Clear();
                        return;
                    }

                    foreach (var entry in Program.DB.HotelsReservationTable.Where(t => t.ClientId == client.Passport))
                    {
                        if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                        {
                            DGactiveReserv.Rows.Add([
                                Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        $"{client.LastName} {client.FirstName}",
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                        }
                    }
                }
            }
        }
    }
}
