namespace Library_Management_System
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.password_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.username_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_createaccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_pasword_lable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_username_lable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.login_password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_username_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.guna2CheckBox1);
            this.guna2Panel1.Controls.Add(this.password_error);
            this.guna2Panel1.Controls.Add(this.username_error);
            this.guna2Panel1.Controls.Add(this.login_createaccount);
            this.guna2Panel1.Controls.Add(this.login_pasword_lable);
            this.guna2Panel1.Controls.Add(this.login_username_lable);
            this.guna2Panel1.Controls.Add(this.login_button);
            this.guna2Panel1.Controls.Add(this.login_password_textbox);
            this.guna2Panel1.Controls.Add(this.login_username_textbox);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(511, 130);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(583, 608);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(328, 396);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(175, 29);
            this.guna2CheckBox1.TabIndex = 5;
            this.guna2CheckBox1.Text = "Show Password";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 2;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // password_error
            // 
            this.password_error.BackColor = System.Drawing.Color.Transparent;
            this.password_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_error.ForeColor = System.Drawing.Color.Red;
            this.password_error.Location = new System.Drawing.Point(100, 373);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(183, 22);
            this.password_error.TabIndex = 4;
            this.password_error.Text = "Enter Correct Password";
            this.password_error.Visible = false;
            // 
            // username_error
            // 
            this.username_error.BackColor = System.Drawing.Color.Transparent;
            this.username_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_error.ForeColor = System.Drawing.Color.Red;
            this.username_error.Location = new System.Drawing.Point(100, 211);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(194, 22);
            this.username_error.TabIndex = 4;
            this.username_error.Text = "Enter Correct User Name";
            this.username_error.Visible = false;
            // 
            // login_createaccount
            // 
            this.login_createaccount.BackColor = System.Drawing.Color.Transparent;
            this.login_createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_createaccount.ForeColor = System.Drawing.Color.White;
            this.login_createaccount.Location = new System.Drawing.Point(220, 559);
            this.login_createaccount.Name = "login_createaccount";
            this.login_createaccount.Size = new System.Drawing.Size(153, 27);
            this.login_createaccount.TabIndex = 3;
            this.login_createaccount.Text = "Create Account";
            this.login_createaccount.Click += new System.EventHandler(this.login_createaccount_Click);
            // 
            // login_pasword_lable
            // 
            this.login_pasword_lable.BackColor = System.Drawing.Color.Transparent;
            this.login_pasword_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pasword_lable.ForeColor = System.Drawing.Color.White;
            this.login_pasword_lable.Location = new System.Drawing.Point(117, 254);
            this.login_pasword_lable.Name = "login_pasword_lable";
            this.login_pasword_lable.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.login_pasword_lable.Size = new System.Drawing.Size(96, 27);
            this.login_pasword_lable.TabIndex = 1;
            this.login_pasword_lable.Text = "Pasword";
            this.login_pasword_lable.Click += new System.EventHandler(this.login_pasword_lable_Click);
            // 
            // login_username_lable
            // 
            this.login_username_lable.BackColor = System.Drawing.Color.Transparent;
            this.login_username_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username_lable.ForeColor = System.Drawing.Color.White;
            this.login_username_lable.Location = new System.Drawing.Point(117, 92);
            this.login_username_lable.Name = "login_username_lable";
            this.login_username_lable.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.login_username_lable.Size = new System.Drawing.Size(120, 27);
            this.login_username_lable.TabIndex = 1;
            this.login_username_lable.Text = "User Name";
            this.login_username_lable.Click += new System.EventHandler(this.login_username_lable_Click);
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.BorderColor = System.Drawing.Color.White;
            this.login_button.BorderRadius = 10;
            this.login_button.BorderThickness = 4;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_button.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.HoverState.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_button.Location = new System.Drawing.Point(208, 459);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 84);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Animated = true;
            this.login_password_textbox.BorderColor = System.Drawing.Color.White;
            this.login_password_textbox.BorderRadius = 10;
            this.login_password_textbox.BorderThickness = 3;
            this.login_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password_textbox.DefaultText = "";
            this.login_password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password_textbox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password_textbox.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.login_password_textbox.ForeColor = System.Drawing.Color.White;
            this.login_password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password_textbox.HoverState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_password_textbox.IconRight = global::Library_Management_System.Properties.Resources._lock;
            this.login_password_textbox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.login_password_textbox.IconRightSize = new System.Drawing.Size(50, 50);
            this.login_password_textbox.Location = new System.Drawing.Point(100, 267);
            this.login_password_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.PasswordChar = '\0';
            this.login_password_textbox.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_password_textbox.PlaceholderText = "Enter Password";
            this.login_password_textbox.SelectedText = "";
            this.login_password_textbox.Size = new System.Drawing.Size(403, 99);
            this.login_password_textbox.TabIndex = 1;
            this.login_password_textbox.TextChanged += new System.EventHandler(this.login_password_textbox_TextChanged);
            this.login_password_textbox.Click += new System.EventHandler(this.login_password_textbox_Click);
            this.login_password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_password_textbox_KeyPress);
            // 
            // login_username_textbox
            // 
            this.login_username_textbox.Animated = true;
            this.login_username_textbox.BorderColor = System.Drawing.Color.White;
            this.login_username_textbox.BorderRadius = 10;
            this.login_username_textbox.BorderThickness = 3;
            this.login_username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username_textbox.DefaultText = "";
            this.login_username_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_username_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_username_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username_textbox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_username_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username_textbox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.login_username_textbox.ForeColor = System.Drawing.Color.White;
            this.login_username_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username_textbox.HoverState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_username_textbox.IconRight = global::Library_Management_System.Properties.Resources.user__2_;
            this.login_username_textbox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.login_username_textbox.IconRightSize = new System.Drawing.Size(50, 50);
            this.login_username_textbox.Location = new System.Drawing.Point(100, 105);
            this.login_username_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.PasswordChar = '\0';
            this.login_username_textbox.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_username_textbox.PlaceholderText = "Enter User Name";
            this.login_username_textbox.SelectedText = "";
            this.login_username_textbox.Size = new System.Drawing.Size(403, 99);
            this.login_username_textbox.TabIndex = 1;
            this.login_username_textbox.TextChanged += new System.EventHandler(this.login_username_textbox_TextChanged);
            this.login_username_textbox.Click += new System.EventHandler(this.login_username_textbox_Click);
            this.login_username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_username_textbox_KeyPress);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(231, 18);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(122, 56);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Login";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Library_Management_System.Properties.Resources.cross_small;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1486, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(47, 47);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 866);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox login_username_textbox;
        private Guna.UI2.WinForms.Guna2TextBox login_password_textbox;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel login_pasword_lable;
        private Guna.UI2.WinForms.Guna2HtmlLabel login_username_lable;
        private Guna.UI2.WinForms.Guna2HtmlLabel login_createaccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel password_error;
        private Guna.UI2.WinForms.Guna2HtmlLabel username_error;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}

