namespace Library_Management_System
{
    partial class Form2
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.okbutton = new Guna.UI2.WinForms.Guna2Button();
            this.thime_llable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.LightCoral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(196, 39);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(560, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "please enter the correct username or password!";
            // 
            // okbutton
            // 
            this.okbutton.Animated = true;
            this.okbutton.BackColor = System.Drawing.Color.Transparent;
            this.okbutton.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okbutton.BorderRadius = 10;
            this.okbutton.BorderThickness = 3;
            this.okbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okbutton.Enabled = false;
            this.okbutton.FillColor = System.Drawing.Color.White;
            this.okbutton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.okbutton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okbutton.HoverState.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okbutton.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.okbutton.Location = new System.Drawing.Point(410, 95);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(118, 37);
            this.okbutton.TabIndex = 1;
            this.okbutton.Text = "Ok";
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // thime_llable
            // 
            this.thime_llable.BackColor = System.Drawing.Color.Transparent;
            this.thime_llable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thime_llable.ForeColor = System.Drawing.Color.Salmon;
            this.thime_llable.Location = new System.Drawing.Point(441, 67);
            this.thime_llable.Name = "thime_llable";
            this.thime_llable.Size = new System.Drawing.Size(55, 31);
            this.thime_llable.TabIndex = 0;
            this.thime_llable.Text = "10 S";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Library_Management_System.Properties.Resources.books;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(49, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(120, 120);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 166);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.thime_llable);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button okbutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel thime_llable;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}