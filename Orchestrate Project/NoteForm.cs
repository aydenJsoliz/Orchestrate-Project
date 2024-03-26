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
     
    public partial class NoteForm : Form
    {
        string radioName;  
        public NoteForm() //Form1 nform1
        {
            
            InitializeComponent(); 

            this.FormClosing += new FormClosingEventHandler(NoteForm_FormClosing);

        }
        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stops form from closing

            GetCheckedRadio(panel1);
            
           // e.Cancel = true;
           // this.Hide();
        }

        public RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
                {
                    RadioButton rb = control as RadioButton;
                    
                    if (rb != null && rb.Checked) 
                    {
                     radioName = rb.Name;
                    }
                }
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.GetNoteSelection(radioName);
            return null;
        }
    }
}
