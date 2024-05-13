namespace OnlineHotelBooking
{
    partial class ChangeDateForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            changeDateButton = new Button();
            label2 = new Label();
            label1 = new Label();
            outDateTimePicker = new DateTimePicker();
            inDateTimePicker = new DateTimePicker();
            outMonthCalendar = new MonthCalendar();
            inMonthCalendar = new MonthCalendar();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 114);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 21;
            label6.Text = "Выберите дату выселения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 114);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 20;
            label5.Text = "Выберите дату заселения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 41);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 19;
            label4.Text = "по";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 41);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 18;
            label3.Text = "с";
            // 
            // changeDateButton
            // 
            changeDateButton.Location = new Point(157, 312);
            changeDateButton.Name = "changeDateButton";
            changeDateButton.Size = new Size(160, 49);
            changeDateButton.TabIndex = 17;
            changeDateButton.Text = "Изменить период бронирования";
            changeDateButton.UseVisualStyleBackColor = true;
            changeDateButton.Click += changeDateButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 86);
            label2.Name = "label2";
            label2.Size = new Size(315, 15);
            label2.TabIndex = 16;
            label2.Text = "Доступные даты для изменения периода бронирования";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 15;
            label1.Text = "Текущий период бронирования";
            // 
            // outDateTimePicker
            // 
            outDateTimePicker.Location = new Point(222, 35);
            outDateTimePicker.Name = "outDateTimePicker";
            outDateTimePicker.Size = new Size(141, 23);
            outDateTimePicker.TabIndex = 14;
            // 
            // inDateTimePicker
            // 
            inDateTimePicker.Location = new Point(35, 35);
            inDateTimePicker.Name = "inDateTimePicker";
            inDateTimePicker.Size = new Size(141, 23);
            inDateTimePicker.TabIndex = 13;
            // 
            // outMonthCalendar
            // 
            outMonthCalendar.Location = new Point(280, 138);
            outMonthCalendar.MaxSelectionCount = 1;
            outMonthCalendar.Name = "outMonthCalendar";
            outMonthCalendar.ShowToday = false;
            outMonthCalendar.TabIndex = 12;
            // 
            // inMonthCalendar
            // 
            inMonthCalendar.Location = new Point(36, 138);
            inMonthCalendar.MaxSelectionCount = 1;
            inMonthCalendar.Name = "inMonthCalendar";
            inMonthCalendar.ShowToday = false;
            inMonthCalendar.TabIndex = 11;
            // 
            // ChangeDateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 382);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(changeDateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outDateTimePicker);
            Controls.Add(inDateTimePicker);
            Controls.Add(outMonthCalendar);
            Controls.Add(inMonthCalendar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ChangeDateForm";
            Text = "Изменение периода бронирования";
            Load += ChangeDateForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button changeDateButton;
        private Label label2;
        private Label label1;
        private DateTimePicker outDateTimePicker;
        private DateTimePicker inDateTimePicker;
        private MonthCalendar outMonthCalendar;
        private MonthCalendar inMonthCalendar;
    }
}