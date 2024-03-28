using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Book.sub_menu
{
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
        }
        private string bookId ;
        private string cost ;
        private string title ;
        private string quantity ;
        private string author ;


        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            quantity = guna2TextBox2.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1 != null && guna2TextBox2 != null && guna2TextBox3 != null && guna2TextBox4 != null && guna2TextBox5 != null)
            {
             // add the code for add data for DB
             // add the mess. box for data add ok.... after
             // //add
             //
            }
            cl();
        }

        private void cl()
        {
            guna2TextBox1.Text = string.Empty;
            guna2TextBox2.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
            guna2TextBox4.Text = string.Empty;
            guna2TextBox5.Text = string.Empty;


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            bookId = guna2TextBox1.Text;    
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            title = guna2TextBox2.Text; 
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            author = guna2TextBox3.Text;    
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            cost = guna2TextBox4.Text;
        }
    }
}
