namespace OnlineHotelBooking
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cancelBtn = new Button();
            confirmMTB = new MaskedTextBox();
            passwordMTB = new MaskedTextBox();
            registrLink = new LinkLabel();
            noAccountL = new Label();
            wrongCodeL = new Label();
            confirmBtn = new Button();
            confirmL = new Label();
            warningL1 = new Label();
            enterBtn = new Button();
            loginTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            warninngL2 = new Label();
            createPassTB = new TextBox();
            registerBtn = new Button();
            docNumMTB = new MaskedTextBox();
            label11 = new Label();
            label10 = new Label();
            fatherNameTB = new TextBox();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cancelBtn);
            tabPage1.Controls.Add(confirmMTB);
            tabPage1.Controls.Add(passwordMTB);
            tabPage1.Controls.Add(registrLink);
            tabPage1.Controls.Add(noAccountL);
            tabPage1.Controls.Add(wrongCodeL);
            tabPage1.Controls.Add(confirmBtn);
            tabPage1.Controls.Add(confirmL);
            tabPage1.Controls.Add(warningL1);
            tabPage1.Controls.Add(enterBtn);
            tabPage1.Controls.Add(loginTB);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Вход в систему";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.None;
            cancelBtn.BackColor = Color.PeachPuff;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Location = new Point(524, 205);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(63, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Visible = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // confirmMTB
            // 
            confirmMTB.Anchor = AnchorStyles.None;
            confirmMTB.BorderStyle = BorderStyle.FixedSingle;
            confirmMTB.Location = new Point(455, 175);
            confirmMTB.Mask = "0000";
            confirmMTB.Name = "confirmMTB";
            confirmMTB.Size = new Size(133, 23);
            confirmMTB.TabIndex = 4;
            confirmMTB.Visible = false;
            confirmMTB.TextChanged += confirmMTB_TextChanged;
            // 
            // passwordMTB
            // 
            passwordMTB.Anchor = AnchorStyles.None;
            passwordMTB.BorderStyle = BorderStyle.FixedSingle;
            passwordMTB.Location = new Point(316, 176);
            passwordMTB.Name = "passwordMTB";
            passwordMTB.PasswordChar = '*';
            passwordMTB.Size = new Size(133, 23);
            passwordMTB.TabIndex = 2;
            passwordMTB.TextChanged += passwordMTB_TextChanged;
            // 
            // registrLink
            // 
            registrLink.Anchor = AnchorStyles.None;
            registrLink.AutoSize = true;
            registrLink.Location = new Point(392, 246);
            registrLink.Name = "registrLink";
            registrLink.Size = new Size(119, 15);
            registrLink.TabIndex = 7;
            registrLink.TabStop = true;
            registrLink.Text = "Зарегистрироваться";
            registrLink.LinkClicked += registrLink_LinkClicked;
            // 
            // noAccountL
            // 
            noAccountL.Anchor = AnchorStyles.None;
            noAccountL.AutoSize = true;
            noAccountL.Location = new Point(312, 246);
            noAccountL.Name = "noAccountL";
            noAccountL.Size = new Size(83, 15);
            noAccountL.TabIndex = 10;
            noAccountL.Text = "Нет аккаунта?";
            // 
            // wrongCodeL
            // 
            wrongCodeL.Anchor = AnchorStyles.None;
            wrongCodeL.AutoSize = true;
            wrongCodeL.ForeColor = Color.Red;
            wrongCodeL.Location = new Point(455, 231);
            wrongCodeL.Name = "wrongCodeL";
            wrongCodeL.Size = new Size(163, 15);
            wrongCodeL.TabIndex = 9;
            wrongCodeL.Text = "Введите код подтверждения!";
            wrongCodeL.Visible = false;
            // 
            // confirmBtn
            // 
            confirmBtn.Anchor = AnchorStyles.None;
            confirmBtn.BackColor = Color.LightGreen;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Location = new Point(455, 205);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(63, 23);
            confirmBtn.TabIndex = 5;
            confirmBtn.Text = "OK";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Visible = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // confirmL
            // 
            confirmL.Anchor = AnchorStyles.None;
            confirmL.AutoSize = true;
            confirmL.Location = new Point(455, 158);
            confirmL.Name = "confirmL";
            confirmL.Size = new Size(115, 15);
            confirmL.TabIndex = 6;
            confirmL.Text = "Код подтверждения";
            confirmL.Visible = false;
            // 
            // warningL1
            // 
            warningL1.Anchor = AnchorStyles.None;
            warningL1.AutoSize = true;
            warningL1.ForeColor = Color.Red;
            warningL1.Location = new Point(312, 231);
            warningL1.Name = "warningL1";
            warningL1.Size = new Size(120, 15);
            warningL1.TabIndex = 5;
            warningL1.Text = "Заполните все поля!";
            warningL1.Visible = false;
            // 
            // enterBtn
            // 
            enterBtn.Anchor = AnchorStyles.None;
            enterBtn.BackColor = Color.LightGreen;
            enterBtn.FlatStyle = FlatStyle.Flat;
            enterBtn.Location = new Point(316, 205);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(133, 23);
            enterBtn.TabIndex = 3;
            enterBtn.Text = "Войти";
            enterBtn.UseVisualStyleBackColor = false;
            enterBtn.Click += enterBtn_Click;
            // 
            // loginTB
            // 
            loginTB.Anchor = AnchorStyles.None;
            loginTB.BackColor = SystemColors.Window;
            loginTB.BorderStyle = BorderStyle.FixedSingle;
            loginTB.Location = new Point(316, 132);
            loginTB.Name = "loginTB";
            loginTB.Size = new Size(133, 23);
            loginTB.TabIndex = 1;
            loginTB.TextChanged += loginTB_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(316, 158);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(316, 114);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(warninngL2);
            tabPage2.Controls.Add(createPassTB);
            tabPage2.Controls.Add(registerBtn);
            tabPage2.Controls.Add(docNumMTB);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(fatherNameTB);
            tabPage2.Controls.Add(firstNameTB);
            tabPage2.Controls.Add(lastNameTB);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Регистрация";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // warninngL2
            // 
            warninngL2.Anchor = AnchorStyles.None;
            warninngL2.AutoSize = true;
            warninngL2.ForeColor = Color.Red;
            warninngL2.Location = new Point(44, 288);
            warninngL2.Name = "warninngL2";
            warninngL2.Size = new Size(120, 15);
            warninngL2.TabIndex = 13;
            warninngL2.Text = "Заполните все поля!";
            warninngL2.Visible = false;
            // 
            // createPassTB
            // 
            createPassTB.BorderStyle = BorderStyle.FixedSingle;
            createPassTB.Location = new Point(44, 223);
            createPassTB.Name = "createPassTB";
            createPassTB.Size = new Size(133, 23);
            createPassTB.TabIndex = 12;
            createPassTB.TextChanged += createPassTB_TextChanged;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.PaleGreen;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(44, 262);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(133, 23);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "Зарегистрироваться";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // docNumMTB
            // 
            docNumMTB.BorderStyle = BorderStyle.FixedSingle;
            docNumMTB.Location = new Point(44, 164);
            docNumMTB.Mask = "00 00 000000";
            docNumMTB.Name = "docNumMTB";
            docNumMTB.Size = new Size(133, 23);
            docNumMTB.TabIndex = 11;
            docNumMTB.TextChanged += docMumMTB_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 146);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 8;
            label11.Text = "Номер паспорта";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 205);
            label10.Name = "label10";
            label10.Size = new Size(181, 15);
            label10.TabIndex = 6;
            label10.Text = "Пароль (минимум 8 символов)";
            // 
            // fatherNameTB
            // 
            fatherNameTB.BorderStyle = BorderStyle.FixedSingle;
            fatherNameTB.Location = new Point(44, 108);
            fatherNameTB.Name = "fatherNameTB";
            fatherNameTB.Size = new Size(133, 23);
            fatherNameTB.TabIndex = 10;
            // 
            // firstNameTB
            // 
            firstNameTB.BorderStyle = BorderStyle.FixedSingle;
            firstNameTB.Location = new Point(183, 54);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(133, 23);
            firstNameTB.TabIndex = 9;
            firstNameTB.TextChanged += firstNameTB_TextChanged;
            // 
            // lastNameTB
            // 
            lastNameTB.BorderStyle = BorderStyle.FixedSingle;
            lastNameTB.Location = new Point(44, 54);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(133, 23);
            lastNameTB.TabIndex = 8;
            lastNameTB.TextChanged += lastNameTB_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 90);
            label9.Name = "label9";
            label9.Size = new Size(141, 15);
            label9.TabIndex = 2;
            label9.Text = "Отчество (при наличии)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(183, 36);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 1;
            label8.Text = "Имя";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 36);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 0;
            label7.Text = "Фамилия";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AuthForm";
            Text = "Авторизация в системе";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Button enterBtn;
        private TextBox loginTB;
        private Label label2;
        private Label confirmL;
        private Label warningL1;
        private Label wrongCodeL;
        private Button confirmBtn;
        private LinkLabel registrLink;
        private Label noAccountL;
        private MaskedTextBox docNumMTB;
        private Label label11;
        private Label label10;
        private TextBox fatherNameTB;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button registerBtn;
        private MaskedTextBox passwordMTB;
        private TextBox createPassTB;
        private MaskedTextBox confirmMTB;
        private Button cancelBtn;
        private Label warninngL2;
    }
}