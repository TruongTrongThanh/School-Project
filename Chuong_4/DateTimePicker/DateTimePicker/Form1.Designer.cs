namespace DateTimePicker
{
    partial class Form1
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
            this.DayLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTimePickerLabel = new System.Windows.Forms.Label();
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateDateTimePickerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(121, 73);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(41, 17);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "Ngày";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(121, 112);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(49, 17);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "Tháng";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(121, 153);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(37, 17);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Năm";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(121, 197);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(112, 17);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Ngày/tháng/năm";
            // 
            // DateTimePickerLabel
            // 
            this.DateTimePickerLabel.AutoSize = true;
            this.DateTimePickerLabel.Location = new System.Drawing.Point(121, 238);
            this.DateTimePickerLabel.Name = "DateTimePickerLabel";
            this.DateTimePickerLabel.Size = new System.Drawing.Size(106, 17);
            this.DateTimePickerLabel.TabIndex = 4;
            this.DateTimePickerLabel.Text = "Datetime picker";
            // 
            // DayTextBox
            // 
            this.DayTextBox.Location = new System.Drawing.Point(274, 68);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(100, 22);
            this.DayTextBox.TabIndex = 5;
            this.DayTextBox.Tag = "day";
            this.DayTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(274, 112);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 22);
            this.MonthTextBox.TabIndex = 6;
            this.MonthTextBox.Tag = "month";
            this.MonthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(274, 153);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 22);
            this.YearTextBox.TabIndex = 7;
            this.YearTextBox.Tag = "year";
            this.YearTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(274, 197);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateTextBox.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(274, 238);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker.TabIndex = 9;
            // 
            // UpdateDateTimePickerButton
            // 
            this.UpdateDateTimePickerButton.Location = new System.Drawing.Point(104, 318);
            this.UpdateDateTimePickerButton.Name = "UpdateDateTimePickerButton";
            this.UpdateDateTimePickerButton.Size = new System.Drawing.Size(201, 28);
            this.UpdateDateTimePickerButton.TabIndex = 10;
            this.UpdateDateTimePickerButton.Text = "Cập nhật datetime picker";
            this.UpdateDateTimePickerButton.UseVisualStyleBackColor = true;
            this.UpdateDateTimePickerButton.Click += new System.EventHandler(this.UpdateDateTimePickerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(359, 318);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 28);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 409);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateDateTimePickerButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.DayTextBox);
            this.Controls.Add(this.DateTimePickerLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.DayLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateTimePickerLabel;
        private System.Windows.Forms.TextBox DayTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button UpdateDateTimePickerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

