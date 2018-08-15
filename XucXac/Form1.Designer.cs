namespace XucXac
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.XucXac1 = new System.Windows.Forms.PictureBox();
            this.XucXac2 = new System.Windows.Forms.PictureBox();
            this.XucXac3 = new System.Windows.Forms.PictureBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CountBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.XucXac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XucXac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XucXac3)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(644, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "                       Đổ Xúc Xắc                                ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // XucXac1
            // 
            this.XucXac1.Location = new System.Drawing.Point(75, 107);
            this.XucXac1.Name = "XucXac1";
            this.XucXac1.Size = new System.Drawing.Size(110, 124);
            this.XucXac1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XucXac1.TabIndex = 1;
            this.XucXac1.TabStop = false;
            // 
            // XucXac2
            // 
            this.XucXac2.Location = new System.Drawing.Point(263, 107);
            this.XucXac2.Name = "XucXac2";
            this.XucXac2.Size = new System.Drawing.Size(110, 124);
            this.XucXac2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XucXac2.TabIndex = 2;
            this.XucXac2.TabStop = false;
            // 
            // XucXac3
            // 
            this.XucXac3.Location = new System.Drawing.Point(452, 107);
            this.XucXac3.Name = "XucXac3";
            this.XucXac3.Size = new System.Drawing.Size(110, 124);
            this.XucXac3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XucXac3.TabIndex = 3;
            this.XucXac3.TabStop = false;
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(129, 355);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(129, 49);
            this.RollButton.TabIndex = 4;
            this.RollButton.Text = "Quay số";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(377, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(129, 49);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Đóng";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // CountBox
            // 
            this.CountBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountBox.Location = new System.Drawing.Point(270, 275);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(93, 51);
            this.CountBox.TabIndex = 6;
            this.CountBox.Text = "0";
            this.CountBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 452);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.XucXac3);
            this.Controls.Add(this.XucXac2);
            this.Controls.Add(this.XucXac1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XucXac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XucXac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XucXac3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox XucXac1;
        private System.Windows.Forms.PictureBox XucXac2;
        private System.Windows.Forms.PictureBox XucXac3;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CountBox;
        private System.Windows.Forms.Timer timer1;
    }
}

