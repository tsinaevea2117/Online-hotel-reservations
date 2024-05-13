namespace OnlineHotelBooking
{
    partial class AdminForm
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
            editUserGroupBox = new GroupBox();
            confirmBtn = new Button();
            confirmMTB = new MaskedTextBox();
            cancelBtn = new Button();
            delUserButton = new Button();
            confirmL = new Label();
            label7 = new Label();
            editMobileNumMTB = new MaskedTextBox();
            changeUserButton = new Button();
            label10 = new Label();
            editPasswordTextBox = new TextBox();
            editUserTextBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            usersDG = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            cleanBtn = new Button();
            hotelsCB = new ComboBox();
            label14 = new Label();
            mobileNumMTB = new MaskedTextBox();
            label6 = new Label();
            userTypeComboBox = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            addUserButton = new Button();
            addPasswordTextBox = new TextBox();
            addUserTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            editHotelRB = new RadioButton();
            addHotelRB = new RadioButton();
            groupBox4 = new GroupBox();
            delHotelBtn = new Button();
            saveBtn = new Button();
            hotelWorkgroupTB = new TextBox();
            addHotelBtn = new Button();
            label13 = new Label();
            supervisorsCLB = new CheckedListBox();
            label12 = new Label();
            hotelAddressTB = new TextBox();
            hotelNameTB = new TextBox();
            label11 = new Label();
            label8 = new Label();
            hotelsDG = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            editUserGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDG).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelsDG).BeginInit();
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
            tabControl1.Size = new Size(800, 499);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(editUserGroupBox);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // editUserGroupBox
            // 
            editUserGroupBox.Controls.Add(confirmBtn);
            editUserGroupBox.Controls.Add(confirmMTB);
            editUserGroupBox.Controls.Add(cancelBtn);
            editUserGroupBox.Controls.Add(delUserButton);
            editUserGroupBox.Controls.Add(confirmL);
            editUserGroupBox.Controls.Add(label7);
            editUserGroupBox.Controls.Add(editMobileNumMTB);
            editUserGroupBox.Controls.Add(changeUserButton);
            editUserGroupBox.Controls.Add(label10);
            editUserGroupBox.Controls.Add(editPasswordTextBox);
            editUserGroupBox.Controls.Add(editUserTextBox);
            editUserGroupBox.Controls.Add(label1);
            editUserGroupBox.Controls.Add(label4);
            editUserGroupBox.Enabled = false;
            editUserGroupBox.Location = new Point(518, 243);
            editUserGroupBox.Name = "editUserGroupBox";
            editUserGroupBox.Size = new Size(266, 221);
            editUserGroupBox.TabIndex = 12;
            editUserGroupBox.TabStop = false;
            editUserGroupBox.Text = "Редактирование выбранного пользователя";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(94, 185);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 18;
            confirmBtn.Text = "ОК";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Visible = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // confirmMTB
            // 
            confirmMTB.Location = new Point(43, 186);
            confirmMTB.Mask = "0000";
            confirmMTB.Name = "confirmMTB";
            confirmMTB.Size = new Size(45, 23);
            confirmMTB.TabIndex = 17;
            confirmMTB.Visible = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(185, 185);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(73, 23);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // delUserButton
            // 
            delUserButton.Location = new Point(94, 156);
            delUserButton.Name = "delUserButton";
            delUserButton.Size = new Size(164, 23);
            delUserButton.TabIndex = 2;
            delUserButton.Text = "Удалить пользователя";
            delUserButton.UseVisualStyleBackColor = true;
            delUserButton.Click += delUserButton_Click;
            // 
            // confirmL
            // 
            confirmL.AutoSize = true;
            confirmL.Location = new Point(10, 189);
            confirmL.Name = "confirmL";
            confirmL.Size = new Size(27, 15);
            confirmL.TabIndex = 16;
            confirmL.Text = "Код";
            confirmL.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 103);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 14;
            label7.Text = "Мобильный";
            // 
            // editMobileNumMTB
            // 
            editMobileNumMTB.Enabled = false;
            editMobileNumMTB.Location = new Point(94, 100);
            editMobileNumMTB.Mask = "+7 (000) 000-00-00";
            editMobileNumMTB.Name = "editMobileNumMTB";
            editMobileNumMTB.Size = new Size(164, 23);
            editMobileNumMTB.TabIndex = 11;
            // 
            // changeUserButton
            // 
            changeUserButton.Location = new Point(94, 128);
            changeUserButton.Name = "changeUserButton";
            changeUserButton.Size = new Size(164, 23);
            changeUserButton.TabIndex = 4;
            changeUserButton.Text = "Сохранить изменения";
            changeUserButton.UseVisualStyleBackColor = true;
            changeUserButton.Click += changeUserButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(90, 79);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 6;
            label10.Text = "(мин. 8 символов)";
            // 
            // editPasswordTextBox
            // 
            editPasswordTextBox.Location = new Point(94, 53);
            editPasswordTextBox.Name = "editPasswordTextBox";
            editPasswordTextBox.Size = new Size(164, 23);
            editPasswordTextBox.TabIndex = 3;
            // 
            // editUserTextBox
            // 
            editUserTextBox.Enabled = false;
            editUserTextBox.Location = new Point(94, 25);
            editUserTextBox.Name = "editUserTextBox";
            editUserTextBox.Size = new Size(164, 23);
            editUserTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 29);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Логин";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(usersDG);
            groupBox2.Location = new Point(8, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 456);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Список пользователей";
            // 
            // usersDG
            // 
            usersDG.AllowUserToAddRows = false;
            usersDG.AllowUserToDeleteRows = false;
            usersDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDG.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column8 });
            usersDG.Location = new Point(6, 22);
            usersDG.Name = "usersDG";
            usersDG.ReadOnly = true;
            usersDG.RowHeadersVisible = false;
            usersDG.Size = new Size(492, 417);
            usersDG.TabIndex = 2;
            usersDG.CellContentClick += usersDG_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Логин";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.HeaderText = "Тип";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Отель";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 220;
            // 
            // Column8
            // 
            Column8.HeaderText = "Редакт.";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "→";
            Column8.UseColumnTextForButtonValue = true;
            Column8.Width = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cleanBtn);
            groupBox1.Controls.Add(hotelsCB);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(mobileNumMTB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(userTypeComboBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(addUserButton);
            groupBox1.Controls.Add(addPasswordTextBox);
            groupBox1.Controls.Add(addUserTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(518, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 229);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление пользователя";
            // 
            // cleanBtn
            // 
            cleanBtn.Location = new Point(94, 194);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(75, 23);
            cleanBtn.TabIndex = 13;
            cleanBtn.Text = "Очистить";
            cleanBtn.UseVisualStyleBackColor = true;
            cleanBtn.Click += cleanBtn_Click;
            // 
            // hotelsCB
            // 
            hotelsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            hotelsCB.Enabled = false;
            hotelsCB.FormattingEnabled = true;
            hotelsCB.Location = new Point(94, 83);
            hotelsCB.Name = "hotelsCB";
            hotelsCB.Size = new Size(164, 23);
            hotelsCB.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 86);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 11;
            label14.Text = "Отель";
            // 
            // mobileNumMTB
            // 
            mobileNumMTB.Enabled = false;
            mobileNumMTB.Location = new Point(94, 54);
            mobileNumMTB.Mask = "+7 (000) 000-00-00";
            mobileNumMTB.Name = "mobileNumMTB";
            mobileNumMTB.Size = new Size(164, 23);
            mobileNumMTB.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 115);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 8;
            label6.Text = "Логин";
            // 
            // userTypeComboBox
            // 
            userTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userTypeComboBox.FormattingEnabled = true;
            userTypeComboBox.Location = new Point(94, 25);
            userTypeComboBox.Name = "userTypeComboBox";
            userTypeComboBox.Size = new Size(164, 23);
            userTypeComboBox.TabIndex = 7;
            userTypeComboBox.SelectedIndexChanged += userTypeComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 28);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 6;
            label5.Text = "Тип";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(90, 167);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 5;
            label9.Text = "(мин. 8 символов)";
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(183, 194);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(75, 23);
            addUserButton.TabIndex = 4;
            addUserButton.Text = "Добавить";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // addPasswordTextBox
            // 
            addPasswordTextBox.Location = new Point(94, 141);
            addPasswordTextBox.Name = "addPasswordTextBox";
            addPasswordTextBox.Size = new Size(164, 23);
            addPasswordTextBox.TabIndex = 3;
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(94, 112);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(164, 23);
            addUserTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 144);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Мобильный";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(editHotelRB);
            tabPage2.Controls.Add(addHotelRB);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(hotelsDG);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отели";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // editHotelRB
            // 
            editHotelRB.AutoSize = true;
            editHotelRB.Location = new Point(228, 321);
            editHotelRB.Name = "editHotelRB";
            editHotelRB.Size = new Size(219, 19);
            editHotelRB.TabIndex = 5;
            editHotelRB.Text = "Редактирование выбранного отеля";
            editHotelRB.UseVisualStyleBackColor = true;
            // 
            // addHotelRB
            // 
            addHotelRB.AutoSize = true;
            addHotelRB.Checked = true;
            addHotelRB.Location = new Point(19, 321);
            addHotelRB.Name = "addHotelRB";
            addHotelRB.Size = new Size(183, 19);
            addHotelRB.TabIndex = 4;
            addHotelRB.TabStop = true;
            addHotelRB.Text = "Добавление отеля в систему";
            addHotelRB.UseVisualStyleBackColor = true;
            addHotelRB.CheckedChanged += addHotelRB_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(delHotelBtn);
            groupBox4.Controls.Add(hotelWorkgroupTB);
            groupBox4.Controls.Add(addHotelBtn);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(supervisorsCLB);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(hotelAddressTB);
            groupBox4.Controls.Add(hotelNameTB);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(saveBtn);
            groupBox4.Location = new Point(8, 346);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(746, 117);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // delHotelBtn
            // 
            delHotelBtn.Location = new Point(610, 47);
            delHotelBtn.Name = "delHotelBtn";
            delHotelBtn.Size = new Size(100, 58);
            delHotelBtn.TabIndex = 11;
            delHotelBtn.Text = "Удалить отель из системы";
            delHotelBtn.UseVisualStyleBackColor = true;
            delHotelBtn.Visible = false;
            delHotelBtn.Click += delHotelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(504, 47);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(88, 58);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Сохранить изменения";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Visible = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // hotelWorkgroupTB
            // 
            hotelWorkgroupTB.Location = new Point(111, 82);
            hotelWorkgroupTB.Name = "hotelWorkgroupTB";
            hotelWorkgroupTB.Size = new Size(204, 23);
            hotelWorkgroupTB.TabIndex = 9;
            hotelWorkgroupTB.Text = "OHB_";
            // 
            // addHotelBtn
            // 
            addHotelBtn.Location = new Point(504, 47);
            addHotelBtn.Name = "addHotelBtn";
            addHotelBtn.Size = new Size(88, 23);
            addHotelBtn.TabIndex = 8;
            addHotelBtn.Text = "Добавить";
            addHotelBtn.UseVisualStyleBackColor = true;
            addHotelBtn.Click += addHotelBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(340, 24);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 7;
            label13.Text = "Управляющие";
            // 
            // supervisorsCLB
            // 
            supervisorsCLB.FormattingEnabled = true;
            supervisorsCLB.Location = new Point(340, 47);
            supervisorsCLB.Name = "supervisorsCLB";
            supervisorsCLB.Size = new Size(144, 58);
            supervisorsCLB.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 85);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 4;
            label12.Text = "Рабочая группа";
            // 
            // hotelAddressTB
            // 
            hotelAddressTB.Location = new Point(111, 53);
            hotelAddressTB.Name = "hotelAddressTB";
            hotelAddressTB.Size = new Size(204, 23);
            hotelAddressTB.TabIndex = 3;
            // 
            // hotelNameTB
            // 
            hotelNameTB.Location = new Point(111, 24);
            hotelNameTB.Name = "hotelNameTB";
            hotelNameTB.Size = new Size(204, 23);
            hotelNameTB.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 56);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 1;
            label11.Text = "Адрес";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 27);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 0;
            label8.Text = "Название";
            // 
            // hotelsDG
            // 
            hotelsDG.AllowUserToAddRows = false;
            hotelsDG.AllowUserToDeleteRows = false;
            hotelsDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hotelsDG.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7 });
            hotelsDG.Location = new Point(8, 6);
            hotelsDG.MultiSelect = false;
            hotelsDG.Name = "hotelsDG";
            hotelsDG.ReadOnly = true;
            hotelsDG.Size = new Size(746, 309);
            hotelsDG.TabIndex = 0;
            hotelsDG.CellClick += hotelsDG_CellClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "Название";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Адрес";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 250;
            // 
            // Column6
            // 
            Column6.HeaderText = "Рабочая группа";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "Количество управляющих";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "Рабочее место администратора сервиса - ";
            FormClosing += AdminForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            editUserGroupBox.ResumeLayout(false);
            editUserGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersDG).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelsDG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox editUserGroupBox;
        private Button changeUserButton;
        private Label label10;
        private TextBox editPasswordTextBox;
        private TextBox editUserTextBox;
        private Label label1;
        private Button delUserButton;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label9;
        private Button addUserButton;
        private TextBox addPasswordTextBox;
        private TextBox addUserTextBox;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private ComboBox userTypeComboBox;
        private Label label5;
        private MaskedTextBox mobileNumMTB;
        private Label label6;
        private DataGridView usersDG;
        private DataGridView hotelsDG;
        private GroupBox groupBox4;
        private Label label12;
        private TextBox hotelAddressTB;
        private TextBox hotelNameTB;
        private Label label11;
        private Label label8;
        private Label label13;
        private CheckedListBox supervisorsCLB;
        private Button addHotelBtn;
        private RadioButton editHotelRB;
        private RadioButton addHotelRB;
        private TextBox hotelWorkgroupTB;
        private ComboBox hotelsCB;
        private Label label14;
        private Button saveBtn;
        private Button cleanBtn;
        private Label label7;
        private MaskedTextBox editMobileNumMTB;
        private Button cancelBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column8;
        private MaskedTextBox confirmMTB;
        private Label confirmL;
        private Button confirmBtn;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button delHotelBtn;
    }
}