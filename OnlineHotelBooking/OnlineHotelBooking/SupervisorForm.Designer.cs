namespace OnlineHotelBooking
{
    partial class SupervisorForm
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
            groupBox3 = new GroupBox();
            label6 = new Label();
            editUserTypeComboBox = new ComboBox();
            changeUserButton = new Button();
            label10 = new Label();
            editPasswordTextBox = new TextBox();
            editUserTextBox = new TextBox();
            label1 = new Label();
            delUserButton = new Button();
            label4 = new Label();
            groupBox2 = new GroupBox();
            usersListBox = new ListBox();
            groupBox1 = new GroupBox();
            userTypeComboBox = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            addUserButton = new Button();
            addPasswordTextBox = new TextBox();
            addUserTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            delRoomButton = new Button();
            groupBox4 = new GroupBox();
            capacityNumericUpDown = new NumericUpDown();
            catNumComboBox = new ComboBox();
            priceTextBox = new TextBox();
            label7 = new Label();
            numRoomTextBox = new TextBox();
            addRoomButton = new Button();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            DGroom = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewComboBoxColumn();
            tabPage3 = new TabPage();
            DGparam = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            balanceAccessCheckBox = new CheckBox();
            editBalanceAccessCheckBox = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capacityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGroom).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGparam).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сотрудники";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(editBalanceAccessCheckBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(editUserTypeComboBox);
            groupBox3.Controls.Add(changeUserButton);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(editPasswordTextBox);
            groupBox3.Controls.Add(editUserTextBox);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(delUserButton);
            groupBox3.Controls.Add(label4);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(288, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(294, 192);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Редактирование выбранного пользователя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 51);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 10;
            label6.Text = "Тип";
            // 
            // editUserTypeComboBox
            // 
            editUserTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editUserTypeComboBox.FormattingEnabled = true;
            editUserTypeComboBox.Location = new Point(60, 48);
            editUserTypeComboBox.Name = "editUserTypeComboBox";
            editUserTypeComboBox.Size = new Size(218, 23);
            editUserTypeComboBox.TabIndex = 10;
            // 
            // changeUserButton
            // 
            changeUserButton.Location = new Point(122, 159);
            changeUserButton.Name = "changeUserButton";
            changeUserButton.Size = new Size(75, 23);
            changeUserButton.TabIndex = 4;
            changeUserButton.Text = "Изменить";
            changeUserButton.UseVisualStyleBackColor = true;
            changeUserButton.Click += changeUserButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 103);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 6;
            label10.Text = "(мин. 8 символов)";
            // 
            // editPasswordTextBox
            // 
            editPasswordTextBox.Location = new Point(60, 77);
            editPasswordTextBox.Name = "editPasswordTextBox";
            editPasswordTextBox.Size = new Size(218, 23);
            editPasswordTextBox.TabIndex = 3;
            // 
            // editUserTextBox
            // 
            editUserTextBox.Location = new Point(60, 19);
            editUserTextBox.Name = "editUserTextBox";
            editUserTextBox.Size = new Size(218, 23);
            editUserTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 80);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Пароль";
            // 
            // delUserButton
            // 
            delUserButton.Location = new Point(203, 159);
            delUserButton.Name = "delUserButton";
            delUserButton.Size = new Size(75, 23);
            delUserButton.TabIndex = 2;
            delUserButton.Text = "Удалить";
            delUserButton.UseVisualStyleBackColor = true;
            delUserButton.Click += delUserButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 23);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Логин";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(usersListBox);
            groupBox2.Location = new Point(7, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 382);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Список пользователей";
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 15;
            usersListBox.Location = new Point(9, 23);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(244, 349);
            usersListBox.TabIndex = 1;
            usersListBox.SelectedIndexChanged += usersListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(balanceAccessCheckBox);
            groupBox1.Controls.Add(userTypeComboBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(addUserButton);
            groupBox1.Controls.Add(addPasswordTextBox);
            groupBox1.Controls.Add(addUserTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(288, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 184);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление пользователя";
            // 
            // userTypeComboBox
            // 
            userTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userTypeComboBox.FormattingEnabled = true;
            userTypeComboBox.Location = new Point(60, 48);
            userTypeComboBox.Name = "userTypeComboBox";
            userTypeComboBox.Size = new Size(218, 23);
            userTypeComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 51);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "Тип";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 103);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 5;
            label9.Text = "(мин. 8 символов)";
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(203, 146);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(75, 23);
            addUserButton.TabIndex = 4;
            addUserButton.Text = "Добавить";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // addPasswordTextBox
            // 
            addPasswordTextBox.Location = new Point(60, 77);
            addPasswordTextBox.Name = "addPasswordTextBox";
            addPasswordTextBox.Size = new Size(218, 23);
            addPasswordTextBox.TabIndex = 3;
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(60, 19);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(218, 23);
            addUserTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 80);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 23);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Логин";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(delRoomButton);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(DGroom);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Номера";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // delRoomButton
            // 
            delRoomButton.Location = new Point(506, 260);
            delRoomButton.Name = "delRoomButton";
            delRoomButton.Size = new Size(191, 23);
            delRoomButton.TabIndex = 5;
            delRoomButton.Text = "Удалить выбранный номер";
            delRoomButton.UseVisualStyleBackColor = true;
            delRoomButton.Click += delRoomButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(capacityNumericUpDown);
            groupBox4.Controls.Add(catNumComboBox);
            groupBox4.Controls.Add(priceTextBox);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(numRoomTextBox);
            groupBox4.Controls.Add(addRoomButton);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(506, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(267, 196);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Добавление номера";
            // 
            // capacityNumericUpDown
            // 
            capacityNumericUpDown.Location = new Point(139, 59);
            capacityNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            capacityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            capacityNumericUpDown.Name = "capacityNumericUpDown";
            capacityNumericUpDown.Size = new Size(120, 23);
            capacityNumericUpDown.TabIndex = 8;
            capacityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // catNumComboBox
            // 
            catNumComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            catNumComboBox.FormattingEnabled = true;
            catNumComboBox.Location = new Point(138, 122);
            catNumComboBox.Name = "catNumComboBox";
            catNumComboBox.Size = new Size(121, 23);
            catNumComboBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(140, 90);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(119, 23);
            priceTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 93);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 1;
            label7.Text = "Цена за сутки";
            // 
            // numRoomTextBox
            // 
            numRoomTextBox.Location = new Point(140, 29);
            numRoomTextBox.Name = "numRoomTextBox";
            numRoomTextBox.Size = new Size(119, 23);
            numRoomTextBox.TabIndex = 5;
            // 
            // addRoomButton
            // 
            addRoomButton.Location = new Point(66, 158);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(125, 23);
            addRoomButton.TabIndex = 4;
            addRoomButton.Text = "Добавить номер";
            addRoomButton.UseVisualStyleBackColor = true;
            addRoomButton.Click += addRoomButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 61);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 3;
            label8.Text = "Количество гостей";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 125);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 2;
            label11.Text = "Тип номера";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 32);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 0;
            label12.Text = "Номер комнаты";
            // 
            // DGroom
            // 
            DGroom.AllowUserToAddRows = false;
            DGroom.AllowUserToDeleteRows = false;
            DGroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGroom.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9 });
            DGroom.Location = new Point(20, 20);
            DGroom.Name = "DGroom";
            DGroom.Size = new Size(468, 382);
            DGroom.TabIndex = 3;
            DGroom.CellBeginEdit += DGroom_CellBeginEdit;
            DGroom.CellEndEdit += DGroom_CellEndEdit;
            // 
            // Column6
            // 
            Column6.HeaderText = "Номер комнаты";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Количество гостей";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Цена за сутки";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Тип номера";
            Column9.Name = "Column9";
            Column9.Resizable = DataGridViewTriState.True;
            Column9.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DGparam);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Параметры бронирования";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGparam
            // 
            DGparam.AllowUserToAddRows = false;
            DGparam.AllowUserToDeleteRows = false;
            DGparam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGparam.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4 });
            DGparam.Location = new Point(8, 14);
            DGparam.Name = "DGparam";
            DGparam.Size = new Size(563, 379);
            DGparam.TabIndex = 1;
            DGparam.CellBeginEdit += DGparam_CellBeginEdit;
            DGparam.CellEndEdit += DGparam_CellEndEdit;
            // 
            // Column1
            // 
            Column1.HeaderText = "Тип номера";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Предоплата, %";
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Срок бесплатной отмены бронирования, сут.";
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // balanceAccessCheckBox
            // 
            balanceAccessCheckBox.AutoSize = true;
            balanceAccessCheckBox.Location = new Point(6, 121);
            balanceAccessCheckBox.Name = "balanceAccessCheckBox";
            balanceAccessCheckBox.Size = new Size(245, 19);
            balanceAccessCheckBox.TabIndex = 10;
            balanceAccessCheckBox.Text = "Доступ к просмотру баланса компании";
            balanceAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // editBalanceAccessCheckBox
            // 
            editBalanceAccessCheckBox.AutoSize = true;
            editBalanceAccessCheckBox.Location = new Point(6, 121);
            editBalanceAccessCheckBox.Name = "editBalanceAccessCheckBox";
            editBalanceAccessCheckBox.Size = new Size(245, 19);
            editBalanceAccessCheckBox.TabIndex = 11;
            editBalanceAccessCheckBox.Text = "Доступ к просмотру баланса компании";
            editBalanceAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "SupervisorForm";
            Text = "Рабочее место управляющего отелем - ";
            FormClosing += SupervisorForm_FormClosing;
            Load += SupervisorForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capacityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGroom).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGparam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private Button changeUserButton;
        private Label label10;
        private TextBox editPasswordTextBox;
        private TextBox editUserTextBox;
        private Label label1;
        private Button delUserButton;
        private Label label4;
        private GroupBox groupBox2;
        private ListBox usersListBox;
        private GroupBox groupBox1;
        private Label label9;
        private Button addUserButton;
        private TextBox addPasswordTextBox;
        private TextBox addUserTextBox;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label6;
        private ComboBox editUserTypeComboBox;
        private ComboBox userTypeComboBox;
        private Label label5;
        private Button delRoomButton;
        private GroupBox groupBox4;
        private NumericUpDown capacityNumericUpDown;
        private ComboBox catNumComboBox;
        private TextBox priceTextBox;
        private Label label7;
        private TextBox numRoomTextBox;
        private Button addRoomButton;
        private Label label8;
        private Label label11;
        private Label label12;
        private DataGridView DGroom;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewComboBoxColumn Column9;
        private DataGridView DGparam;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private CheckBox editBalanceAccessCheckBox;
        private CheckBox balanceAccessCheckBox;
    }
}