using System.Data;

namespace OnlineHotelBooking
{
    public partial class SupervisorForm : Form
    {
        Hotel Hotel;
        User UserForChange;
        object cellValueBeforeEditing;

        public SupervisorForm(string login, Hotel hotel)
        {
            InitializeComponent();
            Hotel = hotel;
            Text += $"{login} - {hotel.Name}";

            userTypeComboBox.DataSource = new[] { UserType.Управлюящий, UserType.Менеджер };
            userTypeComboBox.SelectedIndex = -1;

            editUserTypeComboBox.DataSource = new[] { UserType.Управлюящий, UserType.Менеджер };
            editUserTypeComboBox.SelectedIndex = -1;

            ((DataGridViewComboBoxColumn)DGroom.Columns[3]).DataSource = Enum.GetValues(typeof(RoomType));
            ((DataGridViewComboBoxColumn)DGroom.Columns[3]).ValueType = typeof(RoomType);

            catNumComboBox.DataSource = Enum.GetValues(typeof(RoomType));
        }

        private void SupervisorForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            foreach (User user in Program.DB.Users.Where(t => t.HotelId == Hotel.Id))
                usersListBox.Items.Add(user.Login);

            foreach (Room room in Program.DB.Rooms.Where(t => t.HotelId == Hotel.Id).ToList())
                DGroom.Rows.Add([room.Number, room.Сapacity, room.Price, room.RoomType]);

            foreach (var parameter in Program.DB.RoomCategoryReservationParameters.Where(t=>t.HotelId == Hotel.Id))
                DGparam.Rows.Add([parameter.Category, parameter.Prepayment, parameter.FreeCancellationPeriod]);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (addUserTextBox.Text == "" || addPasswordTextBox.Text.Length < 8 || userTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Данные введены не полностью", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.DB.Users.Where(d => d.Login == addUserTextBox.Text && d.HotelId == Hotel.Id).Count() > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.DB.Users.Add(new User(addUserTextBox.Text, addPasswordTextBox.Text, (UserType)userTypeComboBox.SelectedItem, Hotel.Id, balanceAccessCheckBox.Checked));
            Program.DB.SaveChanges();
            usersListBox.Items.Add(addUserTextBox.Text);

            MessageBox.Show($"Пользователь {addUserTextBox.Text} успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            addUserTextBox.Text = addPasswordTextBox.Text = "";
            userTypeComboBox.SelectedIndex = -1;
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex == -1) return;
            groupBox3.Enabled = true;
            editUserTextBox.Text = usersListBox.SelectedItem.ToString();
            UserForChange = Program.DB.Users.Where(d => d.Login == usersListBox.SelectedItem.ToString() && d.HotelId == Hotel.Id).ToArray()[0];
            editUserTypeComboBox.SelectedItem = UserForChange.UserType;
            editBalanceAccessCheckBox.Checked = UserForChange.BalanceAccess;
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            if (editUserTextBox.Text != "" && UserForChange.Login != editUserTextBox.Text)
            {
                UserForChange.Login = editUserTextBox.Text;
                usersListBox.Items[usersListBox.SelectedIndex] = editUserTextBox.Text;
                Program.DB.SaveChanges();
            }

            if (editPasswordTextBox.Text.Length >= 8 && UserForChange.Password != editPasswordTextBox.Text)
            {
                UserForChange.Password = editPasswordTextBox.Text;
                Program.DB.SaveChanges();
                editPasswordTextBox.Clear();
            }

            if (editUserTypeComboBox.SelectedIndex != -1)
            {
                UserForChange.UserType = (UserType)editUserTypeComboBox.SelectedItem;
                Program.DB.SaveChanges();
            }

            if (UserForChange.BalanceAccess != editBalanceAccessCheckBox.Checked)
            {
                UserForChange.BalanceAccess = editBalanceAccessCheckBox.Checked;
                Program.DB.SaveChanges();
            }

            MessageBox.Show("Данные обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delUserButton_Click(object sender, EventArgs e)
        {
            if (UserForChange.UserType == UserType.Управлюящий && Program.DB.Users.Where(t => t.UserType == UserType.Управлюящий && t.HotelId == Hotel.Id).Count() == 1)
            {
                MessageBox.Show($"Последнего пользователя с правами \"Управляющий\" может удалить только пользователь с правами \"Админисратор\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.DB.Users.Remove(UserForChange);
            Program.DB.SaveChanges();
            UserForChange = null;

            usersListBox.Items.Remove(usersListBox.Items[usersListBox.SelectedIndex]);
            editUserTextBox.Clear();
            editUserTypeComboBox.SelectedIndex = -1;

            MessageBox.Show("Пользователь удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGroom_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellValueBeforeEditing = DGroom[e.ColumnIndex, e.RowIndex].Value;
        }

        private void DGroom_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DGroom[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
            {
                MessageBox.Show("Эта ячейка должна быть заполнена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DGroom[e.ColumnIndex, e.RowIndex].Value = cellValueBeforeEditing;
                return;
            }

            Room room;
            if (e.ColumnIndex == 0)
                room = Program.DB.Rooms.Where(t => t.Number == Convert.ToInt32(cellValueBeforeEditing) && t.HotelId == Hotel.Id).ToList()[0];// редактирование номера комнаты
            else
                room = Program.DB.Rooms.Where(t => t.Number == Convert.ToInt32(DGroom[0, e.RowIndex].Value) && t.HotelId == Hotel.Id).ToList()[0];

            if (e.ColumnIndex == 0)
            {
                if (Program.DB.Rooms.Where(t => t.Number == Convert.ToInt32(DGroom[0, e.RowIndex].Value) && t.HotelId == Hotel.Id).Count() == 1)
                {
                    MessageBox.Show("Комната с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DGroom[e.ColumnIndex, e.RowIndex].Value = cellValueBeforeEditing;
                    return;
                }
                room.Number = Convert.ToInt32(DGroom[e.ColumnIndex, e.RowIndex].Value);
            }
            else if (e.ColumnIndex == 1)
                room.Сapacity = Convert.ToInt32(DGroom[e.ColumnIndex, e.RowIndex].Value);
            else if (e.ColumnIndex == 2)
                room.Price = Convert.ToInt32(DGroom[e.ColumnIndex, e.RowIndex].Value);
            else if (e.ColumnIndex == 3)
                room.RoomType = (RoomType)DGroom[e.ColumnIndex, e.RowIndex].Value;

            Program.DB.SaveChanges();
            MessageBox.Show("Данные обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (numRoomTextBox.Text == "" || priceTextBox.Text == "" || catNumComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Данные введены не полностью", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.DB.Rooms.Where(t => t.Number == Convert.ToInt32(numRoomTextBox.Text) && t.HotelId == Hotel.Id).Count() == 1)
            {
                MessageBox.Show("Комната с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Room room = new Room(Hotel.Id, Convert.ToInt32(numRoomTextBox.Text), (RoomType)catNumComboBox.SelectedIndex, Convert.ToInt32(capacityNumericUpDown.Value), Convert.ToInt32(priceTextBox.Text));
            Program.DB.Rooms.Add(room);
            Program.DB.SaveChanges();

            DGroom.Rows.Add([room.Number, room.Сapacity, room.Price, room.RoomType]);
            MessageBox.Show($"Комната с номером {room.Number} успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numRoomTextBox.Text = priceTextBox.Text = "";
            capacityNumericUpDown.Value = 1;
            catNumComboBox.SelectedIndex = -1;
        }

        private void delRoomButton_Click(object sender, EventArgs e)
        {
            Room rooom = Program.DB.Rooms.Where(d => d.Number == (int)DGroom[0, DGroom.CurrentRow.Index].Value && d.HotelId == Hotel.Id).First();
            Program.DB.Rooms.Remove(rooom);
            Program.DB.SaveChanges();
            DGroom.Rows.RemoveAt(DGroom.CurrentRow.Index);
            MessageBox.Show("Комната удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGparam_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellValueBeforeEditing = DGparam[e.ColumnIndex, e.RowIndex].Value;
        }

        private void DGparam_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty((string)DGparam[e.ColumnIndex, e.RowIndex].Value))
            {
                MessageBox.Show("Эта ячейка должна быть заполнена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DGparam[e.ColumnIndex, e.RowIndex].Value = cellValueBeforeEditing;
                return;
            }

            var parameter = Program.DB.RoomCategoryReservationParameters.Where(t=>t.HotelId == Hotel.Id && t.Category == (RoomType)DGparam[0, e.RowIndex].Value).First();

            if (e.ColumnIndex == 1)
                parameter.Prepayment = Convert.ToInt32(DGparam[1, e.RowIndex].Value);
            else if (e.ColumnIndex == 2)
                parameter.FreeCancellationPeriod = Convert.ToInt32(DGparam[2, e.RowIndex].Value);

            Program.DB.SaveChanges();
            MessageBox.Show("Данные обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
