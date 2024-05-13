using System.Data;
using System.Management;

namespace OnlineHotelBooking
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

            // если вход осуществляется с компьютера Администратора или сотрудника - скрываем вкладку с регистрацией
            if (Program.WorkGroup == "OnlineHotelBooking" || Program.WorkGroup.StartsWith("OHB_"))
            {
                tabControl1.Controls.RemoveAt(1);
                noAccountL.Visible = registrLink.Visible = false;
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "")
            {
                warningL1.Visible = true;
                loginTB.BackColor = Color.LightCoral;
            }

            if (passwordMTB.Text.Length < 8)
            {
                passwordMTB.BackColor = Color.LightCoral;
                warningL1.Visible = true;
            }

            if (warningL1.Visible) return;

            if (Program.WorkGroup == "OnlineHotelBooking")// вход для Администраторов
            {
                if (Program.DB.Users.Where(t => t.UserType == UserType.Администратор && t.Login == loginTB.Text && t.Password == passwordMTB.Text).ToList().Count() == 1)
                {
                    confirmL.Visible = confirmMTB.Visible = confirmBtn.Visible = cancelBtn.Visible = true;
                    loginTB.Enabled = passwordMTB.Enabled = enterBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Неверные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Program.WorkGroup.StartsWith("OHB_"))// вход для сотрудников
            {
                Hotel? hotel = Program.DB.Hotels.Where(t => t.WorkGroup == Program.WorkGroup).FirstOrDefault();
                if (hotel is null)
                {
                    MessageBox.Show("Отеля еще нет в системе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User? user = Program.DB.Users.Where(t => (t.UserType == UserType.Управлюящий || t.UserType == UserType.Менеджер) && t.Login == loginTB.Text && t.Password == passwordMTB.Text && t.HotelId == hotel.Id).FirstOrDefault();

                if (user is null)
                {
                    MessageBox.Show("Неверные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (user.UserType == UserType.Управлюящий)
                {
                    if (user.HotelId == null)
                    {
                        MessageBox.Show("Логин управляющего не привязан к отелю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Program.SF = new SupervisorForm(user.Login, hotel);
                    Hide();
                    Program.SF.Show();
                }
                else if (user.UserType == UserType.Менеджер)
                {
                    Program.MF = new ManagerForm(user.Login, hotel, user.BalanceAccess);
                    Hide();
                    Program.MF.Show();
                }
            }
            else// вход для клиентов
            {
                Client? client = Program.DB.Clients.Where(t => t.Login == loginTB.Text && t.Password == passwordMTB.Text).ToList().FirstOrDefault();
                if (client is not null)
                {
                    Program.CF = new ClientsForm(client);
                    Hide();
                    Program.CF.Show();
                }
                else
                {
                    MessageBox.Show("Неверные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void loginTB_TextChanged(object sender, EventArgs e)
        {
            if (loginTB.BackColor == Color.LightCoral)
            {
                loginTB.BackColor = SystemColors.Window;
                if (passwordMTB.BackColor == SystemColors.Window)
                    warningL1.Visible = false;
            }
        }

        private void passwordMTB_TextChanged(object sender, EventArgs e)
        {
            if (passwordMTB.BackColor == Color.LightCoral && passwordMTB.Text.Length >= 8)
            {
                passwordMTB.BackColor = SystemColors.Window;
                if (loginTB.BackColor == SystemColors.Window)
                    warningL1.Visible = false;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (confirmMTB.Text.Where(c => Char.IsDigit(c)).Count() < 4)
            {
                confirmMTB.BackColor = Color.LightCoral;
                wrongCodeL.Visible = true;
                return;
            }

            if (confirmMTB.Text == DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00"))
            {
                Program.AF = new AdminForm(loginTB.Text);
                Hide();
                Program.AF.Show();
            }
            else
            {
                MessageBox.Show("Неверный код подтверждения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmMTB_TextChanged(object sender, EventArgs e)
        {
            if (confirmMTB.BackColor == Color.LightCoral && confirmMTB.Text.Where(c => Char.IsDigit(c)).Count() == 4)
            {
                confirmMTB.BackColor = SystemColors.Window;
                wrongCodeL.Visible = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            confirmL.Visible = confirmMTB.Visible = confirmBtn.Visible = cancelBtn.Visible = false;
            loginTB.Text = passwordMTB.Text = confirmMTB.Text = "";
            loginTB.Enabled = passwordMTB.Enabled = enterBtn.Enabled = true;
        }

        private void registrLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (lastNameTB.Text == "")
                lastNameTB.BackColor = Color.LightCoral;

            if (firstNameTB.Text == "")
                firstNameTB.BackColor = Color.LightCoral;

            int digitCount = docNumMTB.Text.Where(c => Char.IsDigit(c)).Count();

            if (digitCount < 10)
                docNumMTB.BackColor = Color.LightCoral;

            if (createPassTB.Text.Length < 8)
                createPassTB.BackColor = Color.LightCoral;

            if (lastNameTB.Text == "" || firstNameTB.Text == "" || digitCount < 10 || createPassTB.Text.Length < 8)
            {
                warninngL2.Visible = true;
                return;
            }

            if (Program.DB.Clients.Where(t => t.Passport == docNumMTB.Text && t.Login != null).Count() != 0)
            {
                MessageBox.Show("Клиент с этим номером паспорта уже зарегистрирован!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client client;
            if (Program.DB.Clients.Where(t => t.Passport == docNumMTB.Text).Count() != 0)
            {
                client = Program.DB.Clients.Where(t => t.Passport == docNumMTB.Text).First();
                client.IssueLogin();
                client.Password = createPassTB.Text;
            }
            else
            {
                client = new Client(docNumMTB.Text, lastNameTB.Text, firstNameTB.Text, fatherNameTB.Text, createPassTB.Text);
                Program.DB.Clients.Add(client);
            }



            Program.DB.SaveChanges();
            MessageBox.Show($"Клиенту присвоен логин {client.Login}\nСейчас Вы будете перенаправлены в личный кабинет", "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.CF = new ClientsForm(client);
            Hide();
            Program.CF.Show();
        }

        private void lastNameTB_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTB.BackColor == Color.LightCoral)
            {
                lastNameTB.BackColor = SystemColors.Window;
                int digitCount = docNumMTB.Text.Where(c => Char.IsDigit(c)).Count();
                warninngL2.Visible = firstNameTB.Text == "" || digitCount < 10 || createPassTB.Text.Length < 8;
            }
        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTB.BackColor == Color.LightCoral)
            {
                firstNameTB.BackColor = SystemColors.Window;
                int digitCount = docNumMTB.Text.Where(c => Char.IsDigit(c)).Count();
                warninngL2.Visible = lastNameTB.Text == "" || digitCount < 10 || createPassTB.Text.Length < 8;
            }
        }

        private void docMumMTB_TextChanged(object sender, EventArgs e)
        {
            if (docNumMTB.BackColor == Color.LightCoral && docNumMTB.Text.Where(c => Char.IsDigit(c)).Count() == 10)
            {
                docNumMTB.BackColor = SystemColors.Window;
                warninngL2.Visible = lastNameTB.Text == "" || firstNameTB.Text == "" || createPassTB.Text.Length < 8;
            }
        }

        private void createPassTB_TextChanged(object sender, EventArgs e)
        {
            if (createPassTB.BackColor == Color.LightCoral && createPassTB.Text.Length >= 8)
            {
                createPassTB.BackColor = SystemColors.Window;
                int digitCount = docNumMTB.Text.Where(c => Char.IsDigit(c)).Count();
                warninngL2.Visible = lastNameTB.Text == "" || firstNameTB.Text == "" || digitCount < 10;
            }
        }
    }
}
