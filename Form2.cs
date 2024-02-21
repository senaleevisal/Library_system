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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int counter = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter --;
                thime_llable.Text = counter.ToString()+" S";
            }
            else
            {
                timer1.Stop();
                counter = 10;
                thime_llable.Visible = false;
                okbutton.Enabled = true;
            }
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.count = 0;
        }
    }
}
