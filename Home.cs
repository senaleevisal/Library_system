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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Clear any existing controls in the panel_Display
            panel_Display.Controls.Clear();

            // Create a new instance of your Home_panel user control
            PanelHome panelHome = new PanelHome();
            {
                Dock = DockStyle.Fill; // Ensures it fills the panel_Display
            };

            // Add the Home_panel instance to panel_Display
            panel_Display.Controls.Add(panelHome);
        }
    }
}
