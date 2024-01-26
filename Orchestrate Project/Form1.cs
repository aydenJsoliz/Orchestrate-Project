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
    public partial class Form1 : Form
    {
        NoteForm nf;
        string noteResults;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //int freq = 262;
        //int dur = 800; hello 
        public Form1()
        {
            InitializeComponent();
            nf = new NoteForm(); //this
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            nf.Close();
            Application.Exit(); 
        }

        private void tempoInputBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void notePopupButton_Click(object sender, EventArgs e)
        {
            nf.Show();
        }


        public void GetCheckedRadioButton()
        {
            string noteResults = nf.CheckedRadio();
            radioLabel.Text = noteResults;
        }

        public void GetNoteSelection(string note)
        {
            noteResults = note;
            switch(noteResults)
            {
                case "quarterRadio":
                    radioLabel.Text = "Selected: Quarter Note";
                    Bitmap bmp1 = new Bitmap(new Bitmap("C:/Users/aydan/OneDrive/Documents" +
                        "/Orchestrate Project/Orchestrate Project/Orchestrate Project/Resources" +
                        "/DrawnQuarterNote2.png"), 55, 90);
                    this.Cursor = new Cursor(bmp1.GetHicon());
                    break;
                case "halfRadio":
                    radioLabel.Text = "Selected: Half Note";
                    Bitmap bmp2 = new Bitmap(new Bitmap("C:/Users/aydan/OneDrive/Documents" +
                        "/Orchestrate Project/Orchestrate Project/Orchestrate Project/Resources" +
                        "/DrawnHalfNote.png"), 55, 90);
                    this.Cursor = new Cursor(bmp2.GetHicon());
                    break;
                case "wholeRadio":
                    radioLabel.Text = "Selected: Whole Note";
                    Bitmap bmp3 = new Bitmap(new Bitmap("C:/Users/aydan/OneDrive/Documents" +
                        "/Orchestrate Project/Orchestrate Project/Orchestrate Project/Resources" +
                        "/DrawnWholeNote.png"), 55, 70);
                    this.Cursor = new Cursor(bmp3.GetHicon());
                    break;
                default:
                    radioLabel.Text = "Selected: Nothing";
                    break;
                  
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                "/Orchestrate Project/Piano sounds/piano-c3.wav");
            player.Play(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                "/Orchestrate Project/Piano sounds/piano-g5.wav");
            player.Play();
        }
    }
}
