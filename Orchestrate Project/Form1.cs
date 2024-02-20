using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;

namespace Orchestrate_Project
{
    public partial class Form1 : Form
    {
        string rhythmResults;                   // holds the rhythm chosen from NoteForm
        int tempo = 60;                         // tempo for playing notes
        int staffHght = 12;                     // the distance from staff line to staff line
        int countForDrawing = 6;                // counter for drawing staff
        int disableButtonCounter = 0;           // counter for disabling new staff button
        string[] noteArray = new string[75];    // array to hold the notes to be played
        int counterNoteArray = 0;               // counter to update note array properly   

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
            Application.Exit();
        }

        private void notePopupButton_Click(object sender, EventArgs e)
        {
            NoteForm nf = new NoteForm();
            nf.Show();
        }

        public void GetNoteSelection(string rhythm)
        {
            rhythmResults = rhythm;
            switch (rhythmResults)
            {
                case "quarterRadio":
                    radioLabel.Text = "Selected: Quarter Note";
                    break;
                case "halfRadio":
                    radioLabel.Text = "Selected: Half Note";
                    break;
                case "wholeRadio":
                    radioLabel.Text = "Selected: Whole Note";
                    break;
                case "nothingRadio":
                    radioLabel.Text = "Selected: Nothing";
                    break;
                default:
                    radioLabel.Text = "Selected: Nothing";
                    break;

            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // creates and opens an instance of HelpForm
            HelpForm hf = new HelpForm();
            hf.Show();
        }


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

            //checkBox.Text = tempo.ToString();

        }

        private void tempoInputBox_KeyPress(object sender, KeyPressEventArgs e)     // only allows integers
        {
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

        // Functions for Musical Staff Panel ----------------------------------------------------
        private void musicalStaffPanel_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;


            for (int i = 1; i < 6; i++)
                g.DrawLine(Pens.Black, 0, i * staffHght, musicalStaffPanel.Width - 45, i * staffHght);

            g.DrawLine(Pens.Black, (musicalStaffPanel.Width / 3) + 30, 12, (musicalStaffPanel.Width / 3) + 30, 60);
            g.DrawLine(Pens.Black, (musicalStaffPanel.Width / 2) + 150, 12, (musicalStaffPanel.Width / 2) + 150, 60);
            g.DrawLine(Pens.Black, musicalStaffPanel.Width - 45, 12, musicalStaffPanel.Width - 45, 60);


            g.Dispose(); // dispose graphics object for storage
        }


        private void DrawLines()
        {
            Graphics gr = musicalStaffPanel.CreateGraphics();
            gr.SmoothingMode = SmoothingMode.HighQuality;
            int i; // index for for loop

            for (i = countForDrawing; i < countForDrawing + 5; i++)
            {
                gr.DrawLine(Pens.Black, 0, i * staffHght, musicalStaffPanel.Width - 45, i * staffHght);
            }
            gr.DrawLine(Pens.Black, 0, (i * staffHght) - 12, 0, (i * staffHght) - 60);
            gr.DrawLine(Pens.Black, (musicalStaffPanel.Width / 3) + 30, (i * staffHght) - 12,
                (musicalStaffPanel.Width / 3) + 30, (i * staffHght) - 60);
            gr.DrawLine(Pens.Black, (musicalStaffPanel.Width / 2) + 150, (i * staffHght) - 12,
                (musicalStaffPanel.Width / 2) + 150, (i * staffHght) - 60);
            gr.DrawLine(Pens.Black, musicalStaffPanel.Width - 45, (i * staffHght) - 12,
                musicalStaffPanel.Width - 45, (i * staffHght) - 60);

            countForDrawing = i;
            disableButtonCounter++;
            gr.Dispose(); // disposes graphics object for storage

            if (disableButtonCounter == 4)
            {
                newMusicLineButton.BackColor = Color.LightGray;
                newMusicLineButton.ForeColor = Color.Gray;
                newMusicLineButton.Enabled = false;
            }
        }

        private void newMusicLineButton_Click(object sender, EventArgs e)
        {
            countForDrawing = countForDrawing + 3;
            DrawLines();
        }

        private void musicalStaffPanel_MouseHover(object sender, EventArgs e)
        {
            //{
            //    case "quarterRadio":
            //        Bitmap bmp1 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
            //            Resources.NewDrawnQuarterNote), 100, 150);
            //        this.Cursor = new Cursor(bmp1.GetHicon());
            //        break;
            //    case "halfRadio":
            //        Bitmap bmp2 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
            //            Resources.NewDrawnHalfNote), 370, 180);
            //        this.Cursor = new Cursor(bmp2.GetHicon());
            //        break;
            //    case "wholeRadio":
            //        Bitmap bmp3 = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
            //            Resources.DrawnWholeNote), 55, 80);
            //        this.Cursor = new Cursor(bmp3.GetHicon());
            //        break;
            //    default:
            //        break;
            //}
        }

        private void musicalStaffPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void musicalStaffPanel_Click(object sender, EventArgs e)
        {
            DrawNotes();
        }

        private void DrawNotes()
        {
            Graphics mgr = musicalStaffPanel.CreateGraphics();
            mgr.SmoothingMode = SmoothingMode.HighQuality;

            var mouseCoord = musicalStaffPanel.PointToClient(Cursor.Position);

            if ((mouseCoord.Y > 44 && mouseCoord.Y < 52) || (mouseCoord.Y > 140 && mouseCoord.Y < 148)
                || (mouseCoord.Y > 236 && mouseCoord.Y < 244) || (mouseCoord.Y > 332 && mouseCoord.Y < 340) 
                || (mouseCoord.Y > 428 && mouseCoord.Y < 436) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                    "/Orchestrate Project/Piano sounds/piano-g5.wav");
                player.Play();

                noteArray[counterNoteArray] = "G";
            }




            switch (rhythmResults)
            {
                case "quarterRadio":
                    Bitmap quarterNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.NewDrawnQuarterNote), 60, 110);
                    mouseCoord.X = mouseCoord.X - 35;
                    mouseCoord.Y = mouseCoord.Y - 60;
                    mgr.DrawImage(quarterNote, mouseCoord);
                    break;
                case "halfRadio":
                    Bitmap halfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.NewDrawnHalfNote), 250, 120);
                    mouseCoord.X = mouseCoord.X - 126;
                    mouseCoord.Y = mouseCoord.Y - 70;
                    mgr.DrawImage(halfNote, mouseCoord);
                    break;
                case "wholeRadio":
                    Bitmap wholeNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnWholeNote), 45, 70);
                    mouseCoord.X = mouseCoord.X - 25;
                    mouseCoord.Y = mouseCoord.Y - 38;
                    mgr.DrawImage(wholeNote, mouseCoord);
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("ERROR !! \nNote not selected !!");
                    break;

            }

            counterNoteArray++;
            mgr.Dispose();   // dispose graphics object for storage
        }
        // -------------------------------------------------------------------------------------

        // Functions for Playing notes ---------------------------------------------------------
        private void playButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int sleepTime = (int)((60.0/tempo) * 1000);
            checkBox.Text = sleepTime.ToString();

            do
            {
                switch(noteArray[i])
                {
                    case "G":
                        player = new System.Media.SoundPlayer("C:/Users/aydan/OneDrive/Documents" +
                        "/Orchestrate Project/Piano sounds/piano-g5.wav");
                        player.Play();
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("ERROR !! \nNotes have " +
                        "not been placed yet !!");
                        break;

                }
                Thread.Sleep(sleepTime);
                i++;
            }
            while (noteArray[i] != null);
            
        }
        
    }
}
