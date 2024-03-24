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
        string radioName;

        public HelpForm()
        {
            InitializeComponent();
        }

        private void changeVisiblePanel(Control container)
        {
            if(defaultLabel.Visible == true)
            {
                defaultLabel.Visible = false;
            }

            // get selected radio button in the panel 
            foreach (var control in container.Controls)
            {
                RadioButton rb = control as RadioButton;

                if (rb != null && rb.Checked)
                {
                    radioName = rb.Name;
                }
            }

            switch(radioName)
            {
                case "option1":
                    option2Label1.Visible = false;
                    option2Picture1.Visible = false;
                    option1Label1.Visible = true;
                    option1Picture1.Visible = true;
                    option1Label2.Visible = true;
                    option1Picture2.Visible = true;
                    break;
                case "option2":
                    option1Label1.Visible = false;
                    option1Picture1.Visible = false;
                    option1Label2.Visible = false;
                    option1Picture2.Visible = false;
                    option2Label1.Visible = true;
                    option2Picture1.Visible = true;
                    break;
                default:
                    break;
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
