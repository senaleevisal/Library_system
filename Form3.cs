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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            user_name_text.Focus();
            password_text.UseSystemPasswordChar = true;
            repassword_text.UseSystemPasswordChar = true;
        }

        private void user_name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                ID_number_text.Focus();
                e.Handled = true;
            }
        }

        private void ID_number_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                email_text.Focus();
                e.Handled = true;
            }
        }

        private void email_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                password_text.Focus();
                e.Handled = true;
            }
        }

        private void password_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                repassword_text.Focus();
                e.Handled = true;
            }
        }

        private void repassword_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guna2Button1.Focus();
                e.Handled = true;
            }
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                password_text.UseSystemPasswordChar = false;
                repassword_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
                repassword_text.UseSystemPasswordChar = true;
            }
        }

        private void ID_number_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_name_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
