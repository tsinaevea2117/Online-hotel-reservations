namespace OnlineHotelBooking
{
    partial class ClientsForm
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
            DGmatchingRoom = new DataGridView();
            Column12 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewComboBoxColumn();
            Column11 = new DataGridViewButtonColumn();
            searchButton = new Button();
            label4 = new Label();
            roomCategoryCheckedLB = new CheckedListBox();
            guestsCountNumericUpDown = new NumericUpDown();
            label3 = new Label();
            outDateTimePicker = new DateTimePicker();
            label2 = new Label();
            inDateTimePicker = new DateTimePicker();
            label1 = new Label();
            tabPage2 = new TabPage();
            DGactiveReserv = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            Column13 = new DataGridViewButtonColumn();
            Column14 = new DataGridViewButtonColumn();
            tabPage3 = new TabPage();
            DGarchive = new DataGridView();
            Column15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            tabPage4 = new TabPage();
            addMobileBtn = new Button();
            mobileNumMTB = new MaskedTextBox();
            label6 = new Label();
            changePasswordBtn = new Button();
            uploadPhotoBtn = new Button();
            pictureBox1 = new PictureBox();
            createPassTB = new TextBox();
            label10 = new Label();
            fatherNameTB = new TextBox();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            clientIdL = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGmatchingRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestsCountNumericUpDown).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGactiveReserv).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGarchive).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DGmatchingRoom);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(roomCategoryCheckedLB);
            tabPage1.Controls.Add(guestsCountNumericUpDown);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(outDateTimePicker);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(inDateTimePicker);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Подбор номера";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGmatchingRoom
            // 
            DGmatchingRoom.AllowUserToAddRows = false;
            DGmatchingRoom.AllowUserToDeleteRows = false;
            DGmatchingRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGmatchingRoom.Columns.AddRange(new DataGridViewColumn[] { Column12, Column6, Column7, Column8, Column10, Column9, Column11 });
            DGmatchingRoom.Location = new Point(8, 61);
            DGmatchingRoom.Name = "DGmatchingRoom";
            DGmatchingRoom.ReadOnly = true;
            DGmatchingRoom.Size = new Size(634, 353);
            DGmatchingRoom.TabIndex = 19;
            DGmatchingRoom.CellContentClick += DGmatchingRoom_CellContentClick;
            // 
            // Column12
            // 
            Column12.HeaderText = "Отель";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Номер комнаты";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 70;
            // 
            // Column7
            // 
            Column7.HeaderText = "Количество гостей";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Цена";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 80;
            // 
            // Column10
            // 
            Column10.HeaderText = "Предоплата";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 80;
            // 
            // Column9
            // 
            Column9.HeaderText = "Тип номера";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 80;
            // 
            // Column11
            // 
            Column11.HeaderText = "Бронь";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Text = "→";
            Column11.UseColumnTextForButtonValue = true;
            Column11.Width = 50;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(654, 127);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(93, 23);
            searchButton.TabIndex = 18;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 14);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 17;
            label4.Text = "Типы номеров";
            // 
            // roomCategoryCheckedLB
            // 
            roomCategoryCheckedLB.FormattingEnabled = true;
            roomCategoryCheckedLB.Location = new Point(654, 32);
            roomCategoryCheckedLB.Name = "roomCategoryCheckedLB";
            roomCategoryCheckedLB.Size = new Size(120, 76);
            roomCategoryCheckedLB.TabIndex = 16;
            // 
            // guestsCountNumericUpDown
            // 
            guestsCountNumericUpDown.Location = new Point(360, 32);
            guestsCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            guestsCountNumericUpDown.Name = "guestsCountNumericUpDown";
            guestsCountNumericUpDown.Size = new Size(120, 23);
            guestsCountNumericUpDown.TabIndex = 15;
            guestsCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 12);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 14;
            label3.Text = "Количество гостей";
            // 
            // outDateTimePicker
            // 
            outDateTimePicker.Location = new Point(184, 32);
            outDateTimePicker.Name = "outDateTimePicker";
            outDateTimePicker.Size = new Size(160, 23);
            outDateTimePicker.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 14);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 12;
            label2.Text = "Дата выселения";
            // 
            // inDateTimePicker
            // 
            inDateTimePicker.Location = new Point(8, 32);
            inDateTimePicker.Name = "inDateTimePicker";
            inDateTimePicker.Size = new Size(160, 23);
            inDateTimePicker.TabIndex = 11;
            inDateTimePicker.ValueChanged += inDateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 10;
            label1.Text = "Дата заселения";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DGactiveReserv);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Активные бронирования";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGactiveReserv
            // 
            DGactiveReserv.AllowUserToAddRows = false;
            DGactiveReserv.AllowUserToDeleteRows = false;
            DGactiveReserv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGactiveReserv.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column13, Column14 });
            DGactiveReserv.Location = new Point(8, 6);
            DGactiveReserv.Name = "DGactiveReserv";
            DGactiveReserv.ReadOnly = true;
            DGactiveReserv.Size = new Size(776, 404);
            DGactiveReserv.TabIndex = 1;
            DGactiveReserv.CellContentClick += DGactiveReserv_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Отель";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер комнаты";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "Дата заселения";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Дата выселения";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "Статус";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 120;
            // 
            // Column13
            // 
            Column13.HeaderText = "Отмена";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Text = "Х";
            Column13.UseColumnTextForButtonValue = true;
            Column13.Width = 70;
            // 
            // Column14
            // 
            Column14.HeaderText = "Изм. даты";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Text = "...";
            Column14.UseColumnTextForButtonValue = true;
            Column14.Width = 40;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DGarchive);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Архив";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGarchive
            // 
            DGarchive.AllowUserToAddRows = false;
            DGarchive.AllowUserToDeleteRows = false;
            DGarchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGarchive.Columns.AddRange(new DataGridViewColumn[] { Column15, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewComboBoxColumn1 });
            DGarchive.Location = new Point(8, 13);
            DGarchive.Name = "DGarchive";
            DGarchive.ReadOnly = true;
            DGarchive.Size = new Size(776, 397);
            DGarchive.TabIndex = 2;
            // 
            // Column15
            // 
            Column15.HeaderText = "Отель";
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Номер комнаты";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Дата заселения";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Дата выселения";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.HeaderText = "Статус";
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.ReadOnly = true;
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewComboBoxColumn1.Width = 120;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(addMobileBtn);
            tabPage4.Controls.Add(mobileNumMTB);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(changePasswordBtn);
            tabPage4.Controls.Add(uploadPhotoBtn);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(createPassTB);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(fatherNameTB);
            tabPage4.Controls.Add(firstNameTB);
            tabPage4.Controls.Add(lastNameTB);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(clientIdL);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Личный кабинет";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // addMobileBtn
            // 
            addMobileBtn.Location = new Point(157, 149);
            addMobileBtn.Name = "addMobileBtn";
            addMobileBtn.Size = new Size(85, 23);
            addMobileBtn.TabIndex = 28;
            addMobileBtn.Text = "Сохранить";
            addMobileBtn.UseVisualStyleBackColor = true;
            addMobileBtn.Click += addMobileBtn_Click;
            // 
            // mobileNumMTB
            // 
            mobileNumMTB.Location = new Point(18, 150);
            mobileNumMTB.Mask = "+7 (000) 000-00-00";
            mobileNumMTB.Name = "mobileNumMTB";
            mobileNumMTB.Size = new Size(133, 23);
            mobileNumMTB.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 134);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 26;
            label6.Text = "Мобильный";
            // 
            // changePasswordBtn
            // 
            changePasswordBtn.Location = new Point(157, 207);
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.Size = new Size(85, 23);
            changePasswordBtn.TabIndex = 25;
            changePasswordBtn.Text = "Применить";
            changePasswordBtn.UseVisualStyleBackColor = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
            // 
            // uploadPhotoBtn
            // 
            uploadPhotoBtn.Location = new Point(583, 185);
            uploadPhotoBtn.Name = "uploadPhotoBtn";
            uploadPhotoBtn.Size = new Size(107, 23);
            uploadPhotoBtn.TabIndex = 24;
            uploadPhotoBtn.Text = "Загрузить фото";
            uploadPhotoBtn.UseVisualStyleBackColor = true;
            uploadPhotoBtn.Click += uploadPhotoBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(583, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // createPassTB
            // 
            createPassTB.BorderStyle = BorderStyle.FixedSingle;
            createPassTB.Location = new Point(18, 207);
            createPassTB.Name = "createPassTB";
            createPassTB.Size = new Size(133, 23);
            createPassTB.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 189);
            label10.Name = "label10";
            label10.Size = new Size(257, 15);
            label10.TabIndex = 16;
            label10.Text = "Задать новый пароль (минимум 8 символов)";
            // 
            // fatherNameTB
            // 
            fatherNameTB.BorderStyle = BorderStyle.FixedSingle;
            fatherNameTB.Location = new Point(18, 92);
            fatherNameTB.Name = "fatherNameTB";
            fatherNameTB.ReadOnly = true;
            fatherNameTB.Size = new Size(133, 23);
            fatherNameTB.TabIndex = 20;
            // 
            // firstNameTB
            // 
            firstNameTB.BorderStyle = BorderStyle.FixedSingle;
            firstNameTB.Location = new Point(157, 38);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.ReadOnly = true;
            firstNameTB.Size = new Size(133, 23);
            firstNameTB.TabIndex = 19;
            // 
            // lastNameTB
            // 
            lastNameTB.BorderStyle = BorderStyle.FixedSingle;
            lastNameTB.Location = new Point(18, 38);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.ReadOnly = true;
            lastNameTB.Size = new Size(133, 23);
            lastNameTB.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 74);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 15;
            label9.Text = "Отчество";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 20);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 14;
            label8.Text = "Имя";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 20);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Фамилия";
            // 
            // clientIdL
            // 
            clientIdL.AutoSize = true;
            clientIdL.Location = new Point(654, 13);
            clientIdL.Name = "clientIdL";
            clientIdL.Size = new Size(17, 15);
            clientIdL.TabIndex = 1;
            clientIdL.Text = "id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 13);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "ID клиента";
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ClientsForm";
            Text = "Сервис бронирования отелей - ";
            FormClosing += ClientsForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGmatchingRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestsCountNumericUpDown).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGactiveReserv).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGarchive).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DGmatchingRoom;
        private Button searchButton;
        private Label label4;
        private CheckedListBox roomCategoryCheckedLB;
        private NumericUpDown guestsCountNumericUpDown;
        private Label label3;
        private DateTimePicker outDateTimePicker;
        private Label label2;
        private DateTimePicker inDateTimePicker;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView DGactiveReserv;
        private DataGridView DGarchive;
        private TabPage tabPage4;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewComboBoxColumn Column9;
        private DataGridViewButtonColumn Column11;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewComboBoxColumn Column5;
        private DataGridViewButtonColumn Column13;
        private DataGridViewButtonColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private Label clientIdL;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox createPassTB;
        private Label label10;
        private TextBox fatherNameTB;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button changePasswordBtn;
        private Button uploadPhotoBtn;
        private Label label6;
        private Button addMobileBtn;
        private MaskedTextBox mobileNumMTB;
    }
}