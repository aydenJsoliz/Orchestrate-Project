using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; 
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
        int tempo;
        int staffHght = 15;
        //int countForDrawing = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); 


        public Form1()
        {
            InitializeComponent();
           // nf = new NoteForm(); //this
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
           // nf.Close();
            Application.Exit(); 
        }

        private void notePopupButton_Click(object sender, EventArgs e)
        {
            NoteForm nf = new NoteForm();
            nf.Show();
        }

        public void GetNoteSelection(string note)
        {
            noteResults = note;
            switch(noteResults)
            {
                case "quarterRadio":
                    radioLabel.Text = "Selected: Quarter Note";
                    //Bitmap bmp1 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                    //    Resources.NewDrawnQuarterNote), 100, 150);
                    //this.Cursor = new Cursor(bmp1.GetHicon());
                    break;
                case "halfRadio":
                    radioLabel.Text = "Selected: Half Note";
                    //Bitmap bmp2 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                    //    Resources.NewDrawnHalfNote), 400, 200);
                    //this.Cursor = new Cursor(bmp2.GetHicon());
                    break;
                case "wholeRadio":
                    radioLabel.Text = "Selected: Whole Note";
                    //Bitmap bmp3 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                    //    Resources.DrawnWholeNote), 55, 80);
                    //this.Cursor = new Cursor(bmp3.GetHicon());
                    break;
                case "nothingRadio":
                    radioLabel.Text = "Selected: Nothing";
                    //this.Cursor = Cursors.Default;
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
            // creates and opens an instance of HelpForm
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        // Playing with audio files ----------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                "/Orchestrate Project/Piano sounds/piano-c3.wav"); 
            player.Play(); 
        }

        private void button2_MouseHover(object sender, EventArgs e)
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

        private void button3_MouseHover(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                "/Orchestrate Project/Piano sounds/piano-g5.wav");
            player.Play();
        }
        // ---------------------------------------------------------------------------------------

        // Functions for Tempo Input Box ---------------------------------------------------------
        private void tempoInputBox_TextChanged_1(object sender, EventArgs e)
        {
            int validate = 0;
            Int32.TryParse(tempoInputBox.Text, out validate); // validates to make sure there is a value to parse

            if (Int32.TryParse(tempoInputBox.Text, out validate))
            {
                tempo = Int32.Parse(tempoInputBox.Text);
            }
            else
            {
                tempo = 60;
            }

        }

        private void tempoInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tempoInputBox_Leave(object sender, EventArgs e)
        {
            // displays the current value of tempo 
            if (tempo != 60 && tempo <= 120 && tempo >= 60)
            {
                tempoInputBox.Text = tempo.ToString();
            }
            else
                tempoInputBox.Text = "60";
        }
        // --------------------------------------------------------------------------------------

        private void musicalStaffPanel_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;


            for (int i = 1; i < 6; i++)
                 g.DrawLine(Pens.Black, 0, i * staffHght, musicalStaffPanel.Width - 45, i * staffHght);

               
        }

        private void newMusicLineButton_Click(object sender, EventArgs e)
        {
            
            //musicalStaffPanel_Paint();
            // musicalStaffPanel_Paint();  there should be more added to the Paint function, maybe if statement
            //int lines;
            //Graphics gr = e.Graphics;
            //gr.SmoothingMode = SmoothingMode.HighQuality;

            //lines = 0;
            //while (lines < 6)
            //{
            //    gr.DrawLine(Pens.Black, 0, 9 * staffHght, musicalStaffPanel.Width - 45, 9 * staffHght);
            //}
        }

        private void musicalStaffPanel_MouseHover(object sender, EventArgs e)
        {
            switch(noteResults)
            {
                case "quarterRadio":
                    Bitmap bmp1 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.NewDrawnQuarterNote), 100, 150);
                    this.Cursor = new Cursor(bmp1.GetHicon());
                    break;
                case "halfRadio":
                    Bitmap bmp2 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.NewDrawnHalfNote), 370, 180);
                    this.Cursor = new Cursor(bmp2.GetHicon());
                    break;
                case "wholeRadio":
                    Bitmap bmp3 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnWholeNote), 55, 80);
                    this.Cursor = new Cursor(bmp3.GetHicon());
                    break;
                default:
                    break;
            }
        }

        private void musicalStaffPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
