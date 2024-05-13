using System.Data;

namespace OnlineHotelBooking
{
    public partial class AdminForm : Form
    {
        User UserForChange;
        bool RemoveUser = false;
        Hotel HotelForChange;

        public AdminForm(string login)
        {
            InitializeComponent();

            Text += login;

            UpdateUsersDG();

            userTypeComboBox.DataSource = new[] { UserType.Администратор, UserType.Управлюящий };
            userTypeComboBox.SelectedIndex = -1;

            hotelsCB.DataSource = Program.DB.Hotels.Select(t => $"{t.Name} {t.Address}").ToList();
            hotelsCB.SelectedIndex = -1;

            UpdateHotelsDG();

            supervisorsCLB.Items.AddRange(Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий && t.HotelId == null).Select(t => t.Login).ToArray());
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void userTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mobileNumMTB.Enabled = userTypeComboBox.SelectedIndex == 0;
            hotelsCB.Enabled = userTypeComboBox.SelectedIndex == 1;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userTypeComboBox.SelectedIndex == -1 || ((UserType)userTypeComboBox.SelectedItem == UserType.Администратор && (mobileNumMTB.Text.Where(c => Char.IsDigit(c)).Count() < 11)) ||
                addUserTextBox.Text == "" || addPasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Заполнены не все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((UserType)userTypeComboBox.SelectedItem == UserType.Администратор)
            {
                if (Program.DB.Users.Where(t => t.UserType == UserType.Администратор && t.Login == addUserTextBox.Text).Count() == 1)
                {
                    MessageBox.Show($"Администратор с логином {addUserTextBox.Text} уже существует в системе!\nЗадайте другой логин.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.DB.Users.Add(new User(addUserTextBox.Text, addPasswordTextBox.Text, UserType.Администратор, mobileNumMTB.Text));
                Program.DB.SaveChanges();
            }
            else if ((UserType)userTypeComboBox.SelectedItem == UserType.Управлюящий)
            {
                if (Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий && t.Login == addUserTextBox.Text).Count() == 1)
                {
                    MessageBox.Show($"Управляющий с логином {addUserTextBox.Text} уже закреплен за отелем!\nЗадайте другой логин.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.DB.Users.Add(new User(addUserTextBox.Text, addPasswordTextBox.Text, UserType.Управлюящий, hotelsCB.SelectedIndex == -1 ? null : Program.DB.Hotels.ToList()[hotelsCB.SelectedIndex].Id));
                Program.DB.SaveChanges();
                if (hotelsCB.SelectedIndex == -1)
                {
                    supervisorsCLB.Items.Add(addUserTextBox.Text);
                }
                else
                {
                    UpdateHotelsDG();
                }
            }

            UpdateUsersDG();
            MessageBox.Show($"Добавлен пользователь типа {(UserType)userTypeComboBox.SelectedItem} с логином {addUserTextBox.Text}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanAddUserFormItems();
        }

        private void cleanBtn_Click(object sender, EventArgs e) => CleanAddUserFormItems();

        private void CleanAddUserFormItems()
        {
            userTypeComboBox.SelectedIndex = hotelsCB.SelectedIndex = -1;
            mobileNumMTB.Text = addUserTextBox.Text = addPasswordTextBox.Text = "";
        }

        private void usersDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                editUserGroupBox.Enabled = true;
                UserForChange = Program.DB.Users.ToList()[e.RowIndex];
                editUserTextBox.Text = UserForChange.Login;
                editPasswordTextBox.Text = UserForChange.Password;
                editMobileNumMTB.Text = UserForChange.MobileNum;
                editMobileNumMTB.Enabled = UserForChange.UserType == UserType.Администратор;
            }
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            if (UserForChange.UserType == UserType.Управлюящий && UserForChange.Password == editPasswordTextBox.Text)
            {
                MessageBox.Show($"Нет измененных данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (UserForChange.UserType == UserType.Администратор && UserForChange.Password == editPasswordTextBox.Text && UserForChange.MobileNum == editMobileNumMTB.Text)
            {
                MessageBox.Show($"Нет измененных данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (UserForChange.UserType == UserType.Управлюящий)
            {
                if (MessageBox.Show($"Подтверждаете изменение данных?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UserForChange.Password = editPasswordTextBox.Text;
                    Program.DB.SaveChanges();
                    MessageBox.Show($"Данные успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (UserForChange.UserType == UserType.Администратор)
            {
                if (MessageBox.Show($"Для внесения изменений в административную учетную запись введите код подтверждения", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    confirmL.Visible = confirmMTB.Visible = confirmBtn.Visible = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) => CleanEditUserFormItems();

        private void delUserButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Подтверждаете удаление пользователя {UserForChange.Login}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (UserForChange.UserType == UserType.Управлюящий || UserForChange.UserType==UserType.Менеджер)
                {
                    Program.DB.Users.Remove(UserForChange);
                    Program.DB.SaveChanges();
                    UpdateUsersDG();
                    MessageBox.Show($"Пользователь удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanEditUserFormItems();
                }
                else if (UserForChange.UserType == UserType.Администратор)
                {
                    if (MessageBox.Show($"Для внесения изменений в административную учетную запись введите код подтверждения", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        confirmL.Visible = confirmMTB.Visible = confirmBtn.Visible = true;
                        RemoveUser = true;
                    }
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (confirmMTB.Text == DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00"))
            {
                if (RemoveUser)
                {
                    if (Program.DB.Users.Where(t => t.UserType == UserType.Администратор).Count() == 1)
                    {
                        MessageBox.Show("В системе должен присутствовать как минимум один пользователь с административными правами", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Program.DB.Users.Remove(UserForChange);
                        Program.DB.SaveChanges();
                        UpdateUsersDG();
                        MessageBox.Show($"Пользователь удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanEditUserFormItems();
                        return;
                    }
                }
                else
                {
                    UserForChange.Password = editPasswordTextBox.Text;
                    UserForChange.MobileNum = editMobileNumMTB.Text;
                    Program.DB.SaveChanges();
                    MessageBox.Show($"Данные успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanEditUserFormItems();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный код подтверждения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanEditUserFormItems()
        {
            editUserTextBox.Text = editPasswordTextBox.Text = editMobileNumMTB.Text = confirmMTB.Text = "";
            editMobileNumMTB.Enabled = false;
            confirmL.Visible = confirmMTB.Visible = confirmBtn.Visible = false;
            RemoveUser = false;
            editUserGroupBox.Enabled = false;
        }

        private void addHotelRB_CheckedChanged(object sender, EventArgs e)
        {
            addHotelBtn.Visible = addHotelRB.Checked;
            saveBtn.Visible = delHotelBtn.Visible = editHotelRB.Checked;

            if (addHotelRB.Checked)
                CleanAddHotelFormItems();
            else
            {
                if (HotelForChange == null)
                    HotelForChange = Program.DB.Hotels.ToList()[hotelsDG.SelectedCells[0].RowIndex];
                hotelNameTB.Text = HotelForChange.Name;
                hotelAddressTB.Text = HotelForChange.Address;
                hotelWorkgroupTB.Text = HotelForChange.WorkGroup;
            }

            UpdateSupervisorList();
        }

        private void addHotelBtn_Click(object sender, EventArgs e)
        {
            if (hotelNameTB.Text == "" || hotelAddressTB.Text == "" || !hotelWorkgroupTB.Text.StartsWith("OHB_"))
            {
                MessageBox.Show($"Не заполнены обязательные поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.DB.Hotels.Where(t => t.Address == hotelAddressTB.Text).Count() == 1)
            {
                MessageBox.Show($"В системе уже зарегистрирован отель с указанным адресом", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.DB.Hotels.Where(t => t.WorkGroup == hotelWorkgroupTB.Text).Count() == 1)
            {
                MessageBox.Show($"Рабочая группа {hotelWorkgroupTB.Text} зарезервирована за другим отелем\nУкажите другое наименование", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hotel hotel = new Hotel(hotelNameTB.Text, hotelAddressTB.Text, hotelWorkgroupTB.Text);
            Program.DB.Hotels.Add(hotel);
            Program.DB.SaveChanges();

            // заполнение значениями по умолчанию
            Program.DB.RoomCategoryReservationParameters.AddRange(
                    new RoomCategoryReservationParameters(hotel.Id, RoomType.Люкс, 20, 5),
                 new RoomCategoryReservationParameters(hotel.Id, RoomType.Комфорт, 15, 10),
                 new RoomCategoryReservationParameters(hotel.Id, RoomType.Стандарт, 10, 10),
                 new RoomCategoryReservationParameters(hotel.Id, RoomType.Эконом, 5, 15));

            // стартовая запись для баланса
            Program.DB.Balance.Add(new Balance(hotel.Id, DateTime.Today.ToString("dd.MM.yyyy"), "Начало работы", 0, 0));

            Program.DB.SaveChanges();

            MessageBox.Show($"Отель {hotel.Name} успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            hotelsDG.Rows.Add([hotel.Name, hotel.Address, hotel.WorkGroup, supervisorsCLB.CheckedItems.Count]);

            foreach (string login in supervisorsCLB.CheckedItems)
                Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий && t.HotelId == null && t.Login == login).ToList()[0].HotelId = hotel.Id;
            Program.DB.SaveChanges();

            UpdateUsersDG();

            CleanAddHotelFormItems();

            UpdateSupervisorList();

            hotelsCB.DataSource = Program.DB.Hotels.Select(t => $"{t.Name} {t.Address}").ToList();
            hotelsCB.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (hotelNameTB.Text == "" || hotelAddressTB.Text == "" || !hotelWorkgroupTB.Text.StartsWith("OHB_"))
            {
                MessageBox.Show($"Не заполнены обязательные поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.DB.Hotels.Where(t => t.Address == hotelAddressTB.Text && t.Id != HotelForChange.Id).Count() == 1)
            {
                MessageBox.Show($"В системе уже зарегистрирован отель с указанным адресом", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.DB.Hotels.Where(t => t.WorkGroup == hotelWorkgroupTB.Text && t.Id != HotelForChange.Id).Count() == 1)
            {
                MessageBox.Show($"Рабочая группа {hotelWorkgroupTB.Text} зарезервирована за другим отелем\nУкажите другое наименование", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HotelForChange.Name = hotelNameTB.Text;
            HotelForChange.Address = hotelAddressTB.Text;
            HotelForChange.WorkGroup = hotelWorkgroupTB.Text;

            List<User> users = new List<User>();
            foreach (User user in Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий))
                if (user.HotelId == HotelForChange.Id || user.HotelId == null)
                    users.Add(user);

            for (int i = 0; i < supervisorsCLB.Items.Count; i++)
                if (supervisorsCLB.GetItemChecked(i))
                    users[i].HotelId = supervisorsCLB.GetItemChecked(i) ? HotelForChange.Id : null;
            Program.DB.SaveChanges();
            HotelForChange = null;
            UpdateHotelsDG();
            UpdateUsersDG();
        }

        private void delHotelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Подтверждаете удаление отеля {HotelForChange.Name}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (User user in Program.DB.Users.Where(t => t.HotelId == HotelForChange.Id).ToList())
                    user.HotelId = null;

                Program.DB.Remove(HotelForChange);

                Program.DB.SaveChanges();
                HotelForChange = null;

                MessageBox.Show($"Отель удален из системы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateUsersDG();
                UpdateHotelsDG();
                CleanAddHotelFormItems();
                UpdateSupervisorList();
            }
        }

        private void hotelsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (editHotelRB.Checked && e.RowIndex > -1)
            {
                HotelForChange = Program.DB.Hotels.ToList()[e.RowIndex];
                hotelNameTB.Text = HotelForChange.Name;
                hotelAddressTB.Text = HotelForChange.Address;
                hotelWorkgroupTB.Text = HotelForChange.WorkGroup;

                UpdateSupervisorList();
            }
        }

        private void CleanAddHotelFormItems()
        {
            hotelNameTB.Text = hotelAddressTB.Text = "";
            hotelWorkgroupTB.Text = "OHB_";
        }

        private void UpdateUsersDG()
        {
            usersDG.Rows.Clear();
            foreach (User user in Program.DB.Users)
                usersDG.Rows.Add([user.Login, user.UserType, Program.DB.Hotels.Where(t => t.Id == user.HotelId).FirstOrDefault()?.Name]);
        }

        private void UpdateHotelsDG()
        {
            hotelsDG.Rows.Clear();
            foreach (Hotel hotel in Program.DB.Hotels)
                hotelsDG.Rows.Add([hotel.Name, hotel.Address, hotel.WorkGroup, Program.DB.Users.Where(t => t.HotelId == hotel.Id).Count()]);
        }

        private void UpdateSupervisorList()
        {
            supervisorsCLB.Items.Clear();
            if (addHotelRB.Checked)
            {
                supervisorsCLB.Items.AddRange(Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий && t.HotelId == null).Select(t => t.Login).ToArray());
            }
            else
            {
                HotelForChange ??= Program.DB.Hotels.ToList()[hotelsDG.SelectedCells[0].RowIndex];

                foreach (User user in Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий))
                {
                    if (user.HotelId == HotelForChange.Id)
                        supervisorsCLB.Items.Add(user.Login, true);
                    else if (user.HotelId == null)
                        supervisorsCLB.Items.Add(user.Login);
                }
            }
        }
    }
}
