using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_password_textbox.UseSystemPasswordChar = true;
            login_username_textbox.Focus();
        }

        private void login_enterpasword_lable_Click(object sender, EventArgs e)
        {
           
        }

        private void login_password_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_pasword_lable_Click(object sender, EventArgs e)
        {
           
        }

        private void login_enterusernake_lable_Click(object sender, EventArgs e)
        {
            
        }

        private void login_username_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void login_username_lable_Click(object sender, EventArgs e)
        {
            

        }

        private void login_username_textbox_Click(object sender, EventArgs e)
        {
            
        }

        private void login_password_textbox_Click(object sender, EventArgs e)
        {

        }

        private void login_createaccount_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
        public static int count = 0;
        Form2 form2 = new Form2();
        private void login_button_Click(object sender, EventArgs e)
        {
            
            if (login_username_textbox.Text == "123" || login_password_textbox.Text == "123")
            {
                username_error.Visible = false;
                password_error.Visible = false;
                this.Hide();
                count = 0;
            }
            else
            {
                if (count < 3)
                {
                    username_error.Visible = true;
                    password_error.Visible = true;
                    count++;
                }else if (count == 3)
                {
                    form2.ShowDialog();

                }
                
            }

            // if you are get data using database , plz zero the count variable.
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                login_password_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                login_password_textbox.UseSystemPasswordChar = true;
            }
        }

        private void login_username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            login_password_textbox.Focus();
        }

        private void login_password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            login_button.Focus();
        }
    }
}
