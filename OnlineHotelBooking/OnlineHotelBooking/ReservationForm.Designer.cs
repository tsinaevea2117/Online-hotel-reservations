namespace OnlineHotelBooking
{
    partial class ReservationForm
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
            checkInButton = new Button();
            fullPaymentCheckBox = new CheckBox();
            reservButton = new Button();
            prepaymentCheckBox = new CheckBox();
            label5 = new Label();
            lastNameTextBox = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            firstNametextBox = new TextBox();
            fatherNametextBox = new TextBox();
            passportMTB = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkInButton
            // 
            checkInButton.Enabled = false;
            checkInButton.Location = new Point(180, 212);
            checkInButton.Name = "checkInButton";
            checkInButton.Size = new Size(108, 23);
            checkInButton.TabIndex = 19;
            checkInButton.Text = "Заселить";
            checkInButton.UseVisualStyleBackColor = true;
            checkInButton.Click += checkInButton_Click;
            // 
            // fullPaymentCheckBox
            // 
            fullPaymentCheckBox.AutoSize = true;
            fullPaymentCheckBox.Location = new Point(12, 216);
            fullPaymentCheckBox.Name = "fullPaymentCheckBox";
            fullPaymentCheckBox.Size = new Size(137, 19);
            fullPaymentCheckBox.TabIndex = 18;
            fullPaymentCheckBox.Text = "Оплачено полность";
            fullPaymentCheckBox.UseVisualStyleBackColor = true;
            fullPaymentCheckBox.CheckedChanged += fullPaymentCheckBox_CheckedChanged;
            // 
            // reservButton
            // 
            reservButton.Enabled = false;
            reservButton.Location = new Point(180, 167);
            reservButton.Name = "reservButton";
            reservButton.Size = new Size(108, 23);
            reservButton.TabIndex = 17;
            reservButton.Text = "Забронировать";
            reservButton.UseVisualStyleBackColor = true;
            reservButton.Click += reservButton_Click;
            // 
            // prepaymentCheckBox
            // 
            prepaymentCheckBox.AutoSize = true;
            prepaymentCheckBox.Location = new Point(12, 171);
            prepaymentCheckBox.Name = "prepaymentCheckBox";
            prepaymentCheckBox.Size = new Size(138, 19);
            prepaymentCheckBox.TabIndex = 16;
            prepaymentCheckBox.Text = "Внесена предоплата";
            prepaymentCheckBox.UseVisualStyleBackColor = true;
            prepaymentCheckBox.CheckedChanged += prepaymentCheckBox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(76, 16);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(126, 23);
            lastNameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 130);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Паспорт";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 20;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 21;
            label2.Text = "Отчество";
            // 
            // firstNametextBox
            // 
            firstNametextBox.Location = new Point(76, 45);
            firstNametextBox.Name = "firstNametextBox";
            firstNametextBox.Size = new Size(126, 23);
            firstNametextBox.TabIndex = 22;
            // 
            // fatherNametextBox
            // 
            fatherNametextBox.Location = new Point(76, 75);
            fatherNametextBox.Name = "fatherNametextBox";
            fatherNametextBox.Size = new Size(126, 23);
            fatherNametextBox.TabIndex = 23;
            // 
            // passportMTB
            // 
            passportMTB.Location = new Point(76, 127);
            passportMTB.Mask = "00 00 000000";
            passportMTB.Name = "passportMTB";
            passportMTB.Size = new Size(126, 23);
            passportMTB.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 101);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 26;
            label3.Text = "(при наличии)";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 255);
            Controls.Add(label3);
            Controls.Add(passportMTB);
            Controls.Add(fatherNametextBox);
            Controls.Add(firstNametextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkInButton);
            Controls.Add(fullPaymentCheckBox);
            Controls.Add(reservButton);
            Controls.Add(prepaymentCheckBox);
            Controls.Add(label5);
            Controls.Add(lastNameTextBox);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ReservationForm";
            Text = "Подтверждение бронирования и заселение";
            Load += ReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkInButton;
        private CheckBox fullPaymentCheckBox;
        private Button reservButton;
        private CheckBox prepaymentCheckBox;
        private Label label5;
        private TextBox lastNameTextBox;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox firstNametextBox;
        private TextBox fatherNametextBox;
        private MaskedTextBox mobileNumMTB;
        private MaskedTextBox passportMTB;
        private Label label3;
    }
}