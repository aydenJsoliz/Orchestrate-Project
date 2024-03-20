using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orchestrate_Project
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void changeVisiblePanel(Control container)
        {
            if(defaultPanel.Visible == true)
            {
                defaultPanel.Visible = false;
            }
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            changeVisiblePanel(panel1);
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            changeVisiblePanel(panel1);
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            changeVisiblePanel(panel1); 
        }
    }
}
