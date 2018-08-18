namespace SinhVienApp
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
            this.MSSVTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MSSVLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.SinhVienListView = new System.Windows.Forms.ListView();
            this.MSSVHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // MSSVTextBox
            // 
            this.MSSVTextBox.Location = new System.Drawing.Point(173, 78);
            this.MSSVTextBox.Name = "MSSVTextBox";
            this.MSSVTextBox.Size = new System.Drawing.Size(123, 22);
            this.MSSVTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(173, 125);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(472, 58);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 32);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(472, 96);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(125, 33);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Cập nhật";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(472, 135);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MSSVLabel
            // 
            this.MSSVLabel.AutoSize = true;
            this.MSSVLabel.Location = new System.Drawing.Point(31, 81);
            this.MSSVLabel.Name = "MSSVLabel";
            this.MSSVLabel.Size = new System.Drawing.Size(106, 17);
            this.MSSVLabel.TabIndex = 5;
            this.MSSVLabel.Text = "Mã số sinh viên";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(31, 128);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 17);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Họ tên";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(29, 196);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(136, 17);
            this.ListLabel.TabIndex = 7;
            this.ListLabel.Text = "Danh sách sinh viên";
            // 
            // SinhVienListView
            // 
            this.SinhVienListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSVHeader,
            this.NameHeader});
            this.SinhVienListView.FullRowSelect = true;
            this.SinhVienListView.Location = new System.Drawing.Point(32, 216);
            this.SinhVienListView.MultiSelect = false;
            this.SinhVienListView.Name = "SinhVienListView";
            this.SinhVienListView.Size = new System.Drawing.Size(565, 208);
            this.SinhVienListView.TabIndex = 9;
            this.SinhVienListView.UseCompatibleStateImageBehavior = false;
            this.SinhVienListView.View = System.Windows.Forms.View.Details;
            this.SinhVienListView.SelectedIndexChanged += new System.EventHandler(this.SinhVienListView_SelectedIndexChanged);
            // 
            // MSSVHeader
            // 
            this.MSSVHeader.Text = "Mã số sinh viên";
            this.MSSVHeader.Width = 150;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Họ tên sinh viên";
            this.NameHeader.Width = 415;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 455);
            this.Controls.Add(this.SinhVienListView);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MSSVLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MSSVTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MSSVTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MSSVLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.ListView SinhVienListView;
        private System.Windows.Forms.ColumnHeader MSSVHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
    }
}

