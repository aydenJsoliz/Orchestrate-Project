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
    public partial class MusicNameForm : Form
    {
        string musicName;
        string composerName;

        public MusicNameForm()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(MusicNameForm_FormClosing);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(MusicNameForm_FormClosing);
            this.Close();
        }

        private void MusicNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // call function
            SendMusicAndComposerName();
        }

        public string SendMusicAndComposerName()
        {
            musicName = musicNameBox.Text;
            composerName = composerBox.Text;

            // sending name of music and user back to the main form
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.GetMusicAndComposerName(musicName, composerName);
            return null;
        }
    }
}
