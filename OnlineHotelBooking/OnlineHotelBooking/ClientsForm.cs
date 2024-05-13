using System.Data;

namespace OnlineHotelBooking
{
    public partial class ClientsForm : Form
    {
        Client Client;
        List<int> MatchingHotelsIds = new List<int>();
        List<int> ActiveHotelsIds = new List<int>();

        private void ClientsForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        public ClientsForm(Client client)
        {
            InitializeComponent();
            Client = client;
            Text += $"{client.LastName} {client.FirstName}";

            inDateTimePicker.MinDate = DateTime.Today;
            outDateTimePicker.MinDate = DateTime.Today.AddDays(1);
            inDateTimePicker.MaxDate = outDateTimePicker.MaxDate = DateTime.Today.AddDays(180);

            roomCategoryCheckedLB.DataSource = Enum.GetValues(typeof(RoomType));
            for (int i = 0; i < roomCategoryCheckedLB.Items.Count; roomCategoryCheckedLB.SetItemChecked(i++, true)) ;

            ((DataGridViewComboBoxColumn)DGmatchingRoom.Columns[5]).DataSource = Enum.GetValues(typeof(RoomType));
            ((DataGridViewComboBoxColumn)DGmatchingRoom.Columns[5]).ValueType = typeof(RoomType);

            ((DataGridViewComboBoxColumn)DGactiveReserv.Columns[4]).DataSource = Enum.GetValues(typeof(ReservationStatus));
            ((DataGridViewComboBoxColumn)DGactiveReserv.Columns[4]).ValueType = typeof(ReservationStatus);

            ((DataGridViewComboBoxColumn)DGarchive.Columns[4]).DataSource = Enum.GetValues(typeof(ReservationStatus));
            ((DataGridViewComboBoxColumn)DGarchive.Columns[4]).ValueType = typeof(ReservationStatus);

            List<HotelReservationTable> outDates = Program.DB.HotelsReservationTable.Where(t => t.ClientId == client.Passport && t.Status == ReservationStatus.Проживание && t.CheckOutDate.Date < DateTime.Today.Date).ToList();
            for (int i = 0; i < outDates.Count; outDates[i++].Status = ReservationStatus.Завершено) ;
            Program.DB.SaveChanges();

            foreach (var entry in Program.DB.HotelsReservationTable.Where(t => t.ClientId == client.Passport))
            {
                if (entry.Status == ReservationStatus.Забронировано || entry.Status == ReservationStatus.Проживание)
                {
                    DGactiveReserv.Rows.Add([
                        Program.DB.Hotels.Where(t=>t.Id == entry.HotelId).ToList()[0].Name,
                        Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);

                    ActiveHotelsIds.Add(entry.HotelId);
                }
                else// Отменено || Завершено
                {
                    DGarchive.Rows.Add([
                        Program.DB.Hotels.Where(t=>t.Id == entry.HotelId).ToList()[0].Name,
                        Program.DB.Rooms.Where(t=>t.Id == entry.RoomId).ToList()[0].Number,
                        entry.CheckInDate.ToString("dd.MM.yyyy"),
                        entry.CheckOutDate.ToString("dd.MM.yyyy"),
                        entry.Status]);
                }
            }

            lastNameTB.Text = Client.LastName;
            firstNameTB.Text = Client.FirstName;
            fatherNameTB.Text = Client.FatherName;
            clientIdL.Text = Client.Passport;
            mobileNumMTB.Text = Client.MobileNum;

            if (Client.PhotoId is not null)
            {
                MemoryStream ms = new MemoryStream(Program.DB.Photos.Where(t => t.Id == Client.PhotoId).First().Image);
                Image img = Image.FromStream(ms);
                this.pictureBox1.Image = img;
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

            foreach (Room room in Program.DB.Rooms)
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
                {
                    DGmatchingRoom.Rows.Add([
                       Program.DB.Hotels.Where(t=>t.Id ==  room.HotelId).ToList()[0].Name,
                        room.Number,
                        room.Сapacity,
                        room.Price * (int)(outDateTimePicker.Value.Date - inDateTimePicker.Value.Date).TotalDays,
                        room.Price / 100 * Program.DB.RoomCategoryReservationParameters.Where(t =>  t.HotelId==room.HotelId && t.Category == room.RoomType).Select(t => t.Prepayment).ToList()[0] * (int)(outDateTimePicker.Value.Date - inDateTimePicker.Value.Date).TotalDays,
                        room.RoomType]);

                    MatchingHotelsIds.Add(room.HotelId);
                }
            }
            else
                MessageBox.Show("Не нашлось номера по заданным параметрам", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DGmatchingRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show($"За бронирование будет списано {(int)DGmatchingRoom[4, e.RowIndex].Value} руб., продлжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Room room = Program.DB.Rooms.Where(t => t.HotelId == MatchingHotelsIds[e.RowIndex] && t.Number == (int)DGmatchingRoom[1, e.RowIndex].Value).ToList()[0];

            int dayCount = (int)(outDateTimePicker.Value.Date - inDateTimePicker.Value.Date).TotalDays;

            Program.DB.HotelsReservationTable.Add(new HotelReservationTable(MatchingHotelsIds[e.RowIndex], room.Id, Client.Passport, inDateTimePicker.Value.Date, outDateTimePicker.Value.Date, ReservationStatus.Забронировано));
            Program.DB.Balance.Add(new Balance(room.HotelId, DateTime.Today.ToString("dd.MM.yyyy"), "Бронирование", (int)DGmatchingRoom[4, e.RowIndex].Value, Program.DB.Balance.Where(t => t.HotelId == room.HotelId).ToList().Last().Sum + (int)DGmatchingRoom[4, e.RowIndex].Value));
            Program.DB.SaveChanges();

            DGactiveReserv.Rows.Add([(string)DGmatchingRoom[0, e.RowIndex].Value, room.Number, inDateTimePicker.Value.Date.ToString("dd.MM.yyyy"), outDateTimePicker.Value.Date.ToString("dd.MM.yyyy"), ReservationStatus.Забронировано]);
            ActiveHotelsIds.Add(MatchingHotelsIds[e.RowIndex]);

            DGmatchingRoom.Rows.RemoveAt(e.RowIndex);
            MatchingHotelsIds.RemoveAt(e.RowIndex);
            MessageBox.Show("Бронирование осуществлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGactiveReserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Room room = Program.DB.Rooms.Where(t => t.HotelId == ActiveHotelsIds[e.RowIndex] && t.Number == Convert.ToInt32(DGactiveReserv[1, e.RowIndex].Value)).ToList()[0];

                HotelReservationTable entryTable = Program.DB.HotelsReservationTable.Where(t => t.HotelId == ActiveHotelsIds[e.RowIndex] && t.RoomId == room.Id && t.CheckInDate.Date == DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value)).ToList()[0];

                if (e.ColumnIndex == 5)// отмена
                {
                    RoomType roomCategory = room.RoomType;

                    // бесплатный период отмены - возвращаем залог
                    if (DateTime.Today <= entryTable.CheckInDate.AddDays(-Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == room.HotelId && t.Category == roomCategory).Select(r => r.FreeCancellationPeriod).ToList()[0]))
                    {
                        if (MessageBox.Show("Подтверждаете отмену бронирования?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            entryTable.Status = ReservationStatus.Отменено;

                            int price = room.Price;
                            int prepayment = Program.DB.RoomCategoryReservationParameters.Where(t => t.HotelId == room.HotelId && t.Category == room.RoomType).ToList()[0].Prepayment;
                            int dayCount = (int)(DateTime.Parse((string)DGactiveReserv[3, e.RowIndex].Value).Date - DateTime.Parse((string)DGactiveReserv[2, e.RowIndex].Value).Date).TotalDays;
                            Program.DB.Balance.Add(new Balance(room.HotelId, DateTime.Today.ToString("dd.MM.yyyy"), "Возврат предоплаты", -(price / 100 * prepayment) * dayCount, Program.DB.Balance.Where(t => t.HotelId == room.HotelId).ToList().Last().Sum - (price / 100 * prepayment) * dayCount));

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
                    ActiveHotelsIds.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 6)// изменение дат
                {
                    Program.ChangeDateForm = new ChangeDateForm(DGactiveReserv, e.RowIndex, Program.DB.Hotels.Where(t => t.Id == ActiveHotelsIds[e.RowIndex]).ToList()[0], 1);
                    Program.ChangeDateForm.ShowDialog();
                }
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (createPassTB.Text.Length < 8)
            {
                MessageBox.Show("Минимальная длина пароля - 8 символов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client.Password = createPassTB.Text;
            Program.DB.SaveChanges();
        }

        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Photo Files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] image_bytes = File.ReadAllBytes(ofd.FileName);

                Photo photo = new Photo(image_bytes);
                Program.DB.Photos.Add(photo);
                Program.DB.SaveChanges();
                Client.PhotoId = photo.Id;
                Program.DB.SaveChanges();

                MemoryStream ms = new MemoryStream(Program.DB.Photos.Where(t => t.Id == Client.PhotoId).First().Image);
                Image img = Image.FromStream(ms);
                this.pictureBox1.Image = img;
            }
        }

        private void addMobileBtn_Click(object sender, EventArgs e)
        {
            if (mobileNumMTB.Text.Where(c => Char.IsDigit(c)).Count() < 11)
            {
                MessageBox.Show("Номер введен не полностью", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client.MobileNum = mobileNumMTB.Text;
            Program.DB.SaveChanges();
            MessageBox.Show("Номер добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
