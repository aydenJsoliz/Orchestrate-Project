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
        int[] rhythmArray = new int[75];        // array to hold the rhythms 
        int counterRhythmArray = 0;             // counter to update rhythm array properly

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

            // if statement to play the correct note and add it to the noteArray
            if (( mouseCoord.Y > 56 && mouseCoord.Y < 64) || (mouseCoord.Y > 152 && mouseCoord.Y < 160)
                || (mouseCoord.Y > 248 && mouseCoord.Y < 256) || (mouseCoord.Y > 344 && mouseCoord.Y < 352)
                || (mouseCoord.Y > 440 && mouseCoord.Y < 448) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_e4);
                player.Play();
                noteArray[counterNoteArray] = "E4";
            }
            else if ((mouseCoord.Y >= 52 && mouseCoord.Y <= 56) || (mouseCoord.Y >= 148 && mouseCoord.Y <= 152)
                || (mouseCoord.Y >= 244 && mouseCoord.Y <= 248) || (mouseCoord.Y >= 340 && mouseCoord.Y <= 344)
                || (mouseCoord.Y >= 436 && mouseCoord.Y <= 440) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_f4);
                player.Play();
                noteArray[counterNoteArray] = "F4";
            }
            else if ((mouseCoord.Y > 44 && mouseCoord.Y < 52) || (mouseCoord.Y > 140 && mouseCoord.Y < 148)
                || (mouseCoord.Y > 236 && mouseCoord.Y < 244) || (mouseCoord.Y > 332 && mouseCoord.Y < 340) 
                || (mouseCoord.Y > 428 && mouseCoord.Y < 436) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_g4);
                player.Play();
                noteArray[counterNoteArray] = "G4";
            }
            else if ((mouseCoord.Y >= 40 && mouseCoord.Y <= 44) || (mouseCoord.Y >= 136 && mouseCoord.Y <= 140)
                || (mouseCoord.Y >= 232 && mouseCoord.Y <= 236) || (mouseCoord.Y >= 328 && mouseCoord.Y <= 332)
                || (mouseCoord.Y >= 424 && mouseCoord.Y <= 428) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_a4);
                player.Play();
                noteArray[counterNoteArray] = "A4";
            }
            else if ((mouseCoord.Y > 32 && mouseCoord.Y < 40) || (mouseCoord.Y > 128 && mouseCoord.Y < 136)
                || (mouseCoord.Y > 224 && mouseCoord.Y < 232) || (mouseCoord.Y > 320 && mouseCoord.Y < 328)
                || (mouseCoord.Y > 416 && mouseCoord.Y < 424) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_b4);
                player.Play();
                noteArray[counterNoteArray] = "B4";
            }
            else if ((mouseCoord.Y >= 28 && mouseCoord.Y <= 32) || (mouseCoord.Y >= 124 && mouseCoord.Y <= 128)
                || (mouseCoord.Y >= 220 && mouseCoord.Y <= 224) || (mouseCoord.Y >= 316 && mouseCoord.Y <= 320)
                || (mouseCoord.Y >= 412 && mouseCoord.Y <= 416) && rhythmResults != "nothingRadio") 
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_c5);
                player.Play();
                noteArray[counterNoteArray] = "C5";
            }
            else if ((mouseCoord.Y > 20 && mouseCoord.Y < 28) || (mouseCoord.Y > 116 && mouseCoord.Y < 124)
                || (mouseCoord.Y > 212 && mouseCoord.Y < 220) || (mouseCoord.Y > 308 && mouseCoord.Y < 316)
                || (mouseCoord.Y > 404 && mouseCoord.Y < 412) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_d5);
                player.Play();
                noteArray[counterNoteArray] = "D5";
            }
            else if ((mouseCoord.Y >= 16 && mouseCoord.Y <= 20) || (mouseCoord.Y >= 112 && mouseCoord.Y <= 116)
                || (mouseCoord.Y >= 208 && mouseCoord.Y <= 212) || (mouseCoord.Y >= 304 && mouseCoord.Y <= 308)
                || (mouseCoord.Y >= 400 && mouseCoord.Y <= 404) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_e5);
                player.Play();
                noteArray[counterNoteArray] = "E5";
            }
            else if ((mouseCoord.Y > 8 && mouseCoord.Y < 16) || (mouseCoord.Y > 104 && mouseCoord.Y < 112)
                || (mouseCoord.Y > 200 && mouseCoord.Y < 208) || (mouseCoord.Y > 296 && mouseCoord.Y < 304)
                || (mouseCoord.Y > 392 && mouseCoord.Y < 400) && rhythmResults != "nothingRadio")
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_f5);
                player.Play();
                noteArray[counterNoteArray] = "F5";
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR !! \nInvalid Note Placement !!");
            }
                

            // switch statement to draw the correct rhythm and add it to the rhythmArray
            switch (rhythmResults)
            {
                case "quarterRadio":
                    Bitmap quarterNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.NewDrawnQuarterNote), 60, 110);
                    mouseCoord.X = mouseCoord.X - 35;
                    mouseCoord.Y = mouseCoord.Y - 60;
                    mgr.DrawImage(quarterNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 1;
                    break;
                case "halfRadio":
                    Bitmap halfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.NewDrawnHalfNote), 250, 120);
                    mouseCoord.X = mouseCoord.X - 126;
                    mouseCoord.Y = mouseCoord.Y - 70;
                    mgr.DrawImage(halfNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 2;
                    break;
                case "wholeRadio":
                    Bitmap wholeNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnWholeNote), 45, 70);
                    mouseCoord.X = mouseCoord.X - 25;
                    mouseCoord.Y = mouseCoord.Y - 38;
                    mgr.DrawImage(wholeNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 4;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("ERROR !! \nNote not selected !!");
                    break;

            }

            counterNoteArray++;
            counterRhythmArray++;

            // GRAPHICS OBJECT MUST BE DISPOSED OF NO MATTER WHAT RIGHT BEFORE EVENT ENDS
            mgr.Dispose();   // dispose graphics object for storage
        }
        // -------------------------------------------------------------------------------------

        // Functions for Playing notes ---------------------------------------------------------
        private void playButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            do
            {
                int sleepTime = (int)((60.0 / tempo) * 1000);

                if (rhythmArray[i] == 2)        // if next rhythm is half note
                    sleepTime = sleepTime * 2;
                else if (rhythmArray[i] == 4)   // if next rhythm is whole note
                    sleepTime = sleepTime * 4;

                checkBox.Text = sleepTime.ToString();   // here only for testing
                switch (noteArray[i])
                {
                    case "E4":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_e4);
                        player.Play();
                        break;
                    case "F4":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_f4);
                        player.Play();
                        break;
                    case "G4":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_g4);
                        player.Play();
                        break;
                    case "A4":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_a4);
                        player.Play();
                        break;
                    case "B4":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_b4);
                        player.Play();
                        break;
                    case "C5":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_c5);
                        player.Play();
                        break;
                    case "D5":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_d5);
                        player.Play();
                        break;
                    case "E5":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_e5);
                        player.Play();
                        break;
                    case "F5":
                        player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.
                            Resources.piano_f5);
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
