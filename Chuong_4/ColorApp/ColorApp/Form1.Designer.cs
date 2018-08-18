namespace ColorApp
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
            this.ColorBox = new System.Windows.Forms.Label();
            this.RedScrollBar = new System.Windows.Forms.HScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.BlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBox.Location = new System.Drawing.Point(33, 125);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(160, 138);
            this.ColorBox.TabIndex = 0;
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.LargeChange = 1;
            this.RedScrollBar.Location = new System.Drawing.Point(353, 125);
            this.RedScrollBar.Maximum = 255;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(270, 25);
            this.RedScrollBar.TabIndex = 2;
            this.RedScrollBar.Tag = "red";
            this.RedScrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.LargeChange = 1;
            this.GreenScrollBar.Location = new System.Drawing.Point(353, 181);
            this.GreenScrollBar.Maximum = 255;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(270, 25);
            this.GreenScrollBar.TabIndex = 3;
            this.GreenScrollBar.Tag = "green";
            this.GreenScrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.LargeChange = 1;
            this.BlueScrollBar.Location = new System.Drawing.Point(353, 238);
            this.BlueScrollBar.Maximum = 255;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(270, 25);
            this.BlueScrollBar.TabIndex = 4;
            this.BlueScrollBar.Tag = "blue";
            this.BlueScrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blue";
            // 
            // RedTextBox
            // 
            this.RedTextBox.Location = new System.Drawing.Point(646, 125);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.Size = new System.Drawing.Size(71, 22);
            this.RedTextBox.TabIndex = 8;
            this.RedTextBox.Tag = "red";
            this.RedTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Location = new System.Drawing.Point(646, 181);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.Size = new System.Drawing.Size(71, 22);
            this.GreenTextBox.TabIndex = 9;
            this.GreenTextBox.Tag = "green";
            this.GreenTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Location = new System.Drawing.Point(646, 238);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.Size = new System.Drawing.Size(71, 22);
            this.BlueTextBox.TabIndex = 10;
            this.BlueTextBox.Tag = "blue";
            this.BlueTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.RedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlueScrollBar);
            this.Controls.Add(this.GreenScrollBar);
            this.Controls.Add(this.RedScrollBar);
            this.Controls.Add(this.ColorBox);
            this.Name = "Form1";
            this.Tag = "blue";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColorBox;
        private System.Windows.Forms.HScrollBar RedScrollBar;
        private System.Windows.Forms.HScrollBar GreenScrollBar;
        private System.Windows.Forms.HScrollBar BlueScrollBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RedTextBox;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TextBox BlueTextBox;
    }
}

