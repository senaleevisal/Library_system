using Library_Management_System.Book.sub_menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Library_Management_System.Book
{
    public partial class PanelBook : UserControl
    {
        public PanelBook()
        {
            InitializeComponent();
        }
        AddBook addbook = new AddBook();
        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void PanelBook_Load(object sender, EventArgs e)
        {

        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Window.Text = "ADD BOOK";

            guna2Panel1.Controls.Clear();

            {
                Dock = DockStyle.Fill;
            }

            guna2Panel1.Controls.Add(addbook);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
