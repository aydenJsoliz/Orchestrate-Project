using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text;

namespace Orchestrate_Project
{
    public partial class Form1 : Form
    {
        string rhythmResults = "nothingRadio";  // holds the rhythm chosen from NoteForm
        int tempo = 60;                         // tempo for playing notes
        int staffHght = 12;                     // the distance from staff line to staff line
        int countForDrawing = 6;                // counter for drawing staff
        int disableButtonCounter = 0;           // counter for disabling new staff button
        string[] noteArray = new string[75];    // array to hold the notes to be played
        int counterNoteArray = 0;               // counter to update note array properly   
        int[] rhythmArray = new int[75];        // array to hold the rhythms 
        int counterRhythmArray = 0;             // counter to update rhythm array properly
        Point[] pointArray = new Point[75];     // array for storing drawn note coordinates
        int counterPointArray = 0;              // counter to update Point array
        int checkForUndo = 0;                   // used to make undo function work

        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();   // used to play audio

        public Form1()
        {
            InitializeComponent();
            // nf = new NoteForm(); //this

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notePopupButton_Click(object sender, EventArgs e)
        {
            defaultLabel.Visible = false;
            defaultPicture.Visible = false;

            NoteForm nf = new NoteForm();
            nf.Show();
        }

        public void GetNoteSelection(string rhythm)
        {
            rhythmResults = rhythm;
            radioLabel.BorderStyle = BorderStyle.FixedSingle;
            radioLabel.Visible = true;
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
                case "dottedHalfRadio":
                    radioLabel.Text = "Selected: Dotted Half Note";
                    break;
                case "quarterRestRadio":
                    radioLabel.Text = "Selected: Quarter Rest";
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

            // disables Add Staff Button and draws some graphical changes to represent end of staff
            if (disableButtonCounter == 4) 
            {
                SolidBrush endBrush = new SolidBrush(Color.Black);
                gr.FillRectangle(endBrush, musicalStaffPanel.Width - 52, (i * staffHght) - 60,
                    7, 48);
                gr.DrawLine(Pens.Black, musicalStaffPanel.Width - 57, (i * staffHght) - 12,
                    musicalStaffPanel.Width - 57, (i * staffHght) - 60);

                newMusicLineButton.BackColor = Color.LightGray;
                newMusicLineButton.ForeColor = Color.Gray;
                newMusicLineButton.Enabled = false;

                endBrush.Dispose();  // disposes graphics object for storage
            }
            gr.Dispose(); // disposes graphics object for storage
        }

        private void newMusicLineButton_Click(object sender, EventArgs e)
        {
            countForDrawing = countForDrawing + 3;
            DrawLines();
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
            testLabel.Text = "hiiii";

            // this if-statement is executed if undo button is pressed, thus checkForUndo becomes 1
            if(checkForUndo == 1)
            {
                
                int i = 0;
                Graphics redraw = musicalStaffPanel.CreateGraphics();
                while (noteArray[i] != null && i < counterNoteArray - 1) 
                {
                    switch (rhythmArray[i])
                    {
                        case 1:
                            Bitmap quarterNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                                Resources.NewDrawnQuarterNote), 60, 110);
                            redraw.DrawImage(quarterNote, pointArray[i]);
                            break;
                        case 2:
                            Bitmap halfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                                Resources.NewDrawnHalfNote), 250, 120);
                            redraw.DrawImage(halfNote, pointArray[i]);
                            break;
                        case 3:
                            Bitmap dottedHalfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.DrawnDottedHalfNote), 57, 55);
                            redraw.DrawImage(dottedHalfNote, pointArray[i]);
                            break;
                        case 4:
                            Bitmap wholeNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                                Resources.DrawnWholeNote), 45, 70);
                            redraw.DrawImage(wholeNote, pointArray[i]);
                            break;
                        case 5:
                            Bitmap quarterRest = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                                Resources.DrawnQuarterRest), 45, 70);
                            redraw.DrawImage(quarterRest, pointArray[i]);
                            break;
                        default:
                            System.Windows.Forms.MessageBox.Show("ERROR !! \nNotes have " +
                            "not been placed yet !!");
                            break;
                    }

                    i++;
                }

                if(noteArray[0] != null)    // to ensure counters do not go below 0
                {
                    counterNoteArray--;
                    counterPointArray--;
                    counterRhythmArray--;

                    // to make sure nothing gets played
                    noteArray[counterNoteArray] = null;
                }

                checkForUndo = 0;
                redraw.Dispose();
                testLabel.Text = "done stuff";
                return;
            }


            var mouseCoord = musicalStaffPanel.PointToClient(Cursor.Position);

            // if statement to play the correct note and add it to the noteArray
            // each else-if is for a line or space in the staff, the coordinates for each part 
            // of the staff in the panel is accounted for. The disableButtonCounter check is to make
            // sure that notes cannot be placed until those sections of the staff have been drawn
            if (String.Equals(rhythmResults, "nothingRadio") == true)
            {
                System.Windows.Forms.MessageBox.Show("ERROR !! \nNote Not Selected !!");
                return;
            }
            else if (mouseCoord.X > (musicalStaffPanel.Width - 45)) 
            {
                System.Windows.Forms.MessageBox.Show("ERROR !! \nInvalid Note Placement !!");
                return;
            }
            else if (String.Equals(rhythmResults, "quarterRestRadio") == true)
            {
                noteArray[counterNoteArray] = "N";
            }
            else if (( mouseCoord.Y > 56 && mouseCoord.Y < 64) || (mouseCoord.Y > 152 && mouseCoord.Y < 160 && disableButtonCounter >= 1)
                || (mouseCoord.Y > 248 && mouseCoord.Y < 256 && disableButtonCounter >= 2) || (mouseCoord.Y > 344 && mouseCoord.Y < 352 && disableButtonCounter >= 3)
                || (mouseCoord.Y > 440 && mouseCoord.Y < 448 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_e4);
                player.Play();
                noteArray[counterNoteArray] = "E4";
            }
            else if ((mouseCoord.Y >= 52 && mouseCoord.Y <= 56) || (mouseCoord.Y >= 148 && mouseCoord.Y <= 152 && disableButtonCounter >= 1)
                || (mouseCoord.Y >= 244 && mouseCoord.Y <= 248 && disableButtonCounter >= 2) || (mouseCoord.Y >= 340 && mouseCoord.Y <= 344 && disableButtonCounter >= 3)
                || (mouseCoord.Y >= 436 && mouseCoord.Y <= 440 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_f4);
                player.Play();
                noteArray[counterNoteArray] = "F4";
            }
            else if ((mouseCoord.Y > 44 && mouseCoord.Y < 52) || (mouseCoord.Y > 140 && mouseCoord.Y < 148 && disableButtonCounter >= 1)
                || (mouseCoord.Y > 236 && mouseCoord.Y < 244 && disableButtonCounter >= 2) || (mouseCoord.Y > 332 && mouseCoord.Y < 340 && disableButtonCounter >= 3) 
                || (mouseCoord.Y > 428 && mouseCoord.Y < 436 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_g4);
                player.Play();
                noteArray[counterNoteArray] = "G4";
            }
            else if ((mouseCoord.Y >= 40 && mouseCoord.Y <= 44) || (mouseCoord.Y >= 136 && mouseCoord.Y <= 140 && disableButtonCounter >= 1)
                || (mouseCoord.Y >= 232 && mouseCoord.Y <= 236 && disableButtonCounter >= 2) || (mouseCoord.Y >= 328 && mouseCoord.Y <= 332 && disableButtonCounter >= 3)
                || (mouseCoord.Y >= 424 && mouseCoord.Y <= 428 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_a4);
                player.Play();
                noteArray[counterNoteArray] = "A4";
            }
            else if ((mouseCoord.Y > 32 && mouseCoord.Y < 40) || (mouseCoord.Y > 128 && mouseCoord.Y < 136 && disableButtonCounter >= 1)
                || (mouseCoord.Y > 224 && mouseCoord.Y < 232 && disableButtonCounter >= 2) || (mouseCoord.Y > 320 && mouseCoord.Y < 328 && disableButtonCounter >= 3)
                || (mouseCoord.Y > 416 && mouseCoord.Y < 424 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_b4);
                player.Play();
                noteArray[counterNoteArray] = "B4";
            }
            else if ((mouseCoord.Y >= 28 && mouseCoord.Y <= 32) || (mouseCoord.Y >= 124 && mouseCoord.Y <= 128 && disableButtonCounter >= 1)
                || (mouseCoord.Y >= 220 && mouseCoord.Y <= 224 && disableButtonCounter >= 2) || (mouseCoord.Y >= 316 && mouseCoord.Y <= 320 && disableButtonCounter >= 3)
                || (mouseCoord.Y >= 412 && mouseCoord.Y <= 416 && disableButtonCounter == 4)) 
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_c5);
                player.Play();
                noteArray[counterNoteArray] = "C5";
            }
            else if ((mouseCoord.Y > 20 && mouseCoord.Y < 28) || (mouseCoord.Y > 116 && mouseCoord.Y < 124 && disableButtonCounter >= 1)
                || (mouseCoord.Y > 212 && mouseCoord.Y < 220 && disableButtonCounter >= 2) || (mouseCoord.Y > 308 && mouseCoord.Y < 316 && disableButtonCounter >= 3)
                || (mouseCoord.Y > 404 && mouseCoord.Y < 412 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_d5);
                player.Play();
                noteArray[counterNoteArray] = "D5";
            }
            else if ((mouseCoord.Y >= 16 && mouseCoord.Y <= 20) || (mouseCoord.Y >= 112 && mouseCoord.Y <= 116 && disableButtonCounter >= 1)
                || (mouseCoord.Y >= 208 && mouseCoord.Y <= 212 && disableButtonCounter >= 2) || (mouseCoord.Y >= 304 && mouseCoord.Y <= 308 && disableButtonCounter >= 3)
                || (mouseCoord.Y >= 400 && mouseCoord.Y <= 404 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_e5);
                player.Play();
                noteArray[counterNoteArray] = "E5";
            }
            else if ((mouseCoord.Y > 8 && mouseCoord.Y < 16) || (mouseCoord.Y > 104 && mouseCoord.Y < 112 && disableButtonCounter >= 1)
                || (mouseCoord.Y > 200 && mouseCoord.Y < 208 && disableButtonCounter >= 2) || (mouseCoord.Y > 296 && mouseCoord.Y < 304 && disableButtonCounter >= 3)
                || (mouseCoord.Y > 392 && mouseCoord.Y < 400 && disableButtonCounter == 4))
            {
                player = new System.Media.SoundPlayer(Orchestrate_Project.Properties.Resources.piano_f5);
                player.Play();
                noteArray[counterNoteArray] = "F5";
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR !! \nInvalid Note Placement !!");
                return;
            }

            testLabel.Text = "byeee";
            Graphics mgr = musicalStaffPanel.CreateGraphics();
            mgr.SmoothingMode = SmoothingMode.HighQuality;

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
                    pointArray[counterPointArray] = mouseCoord;
                    break;
                case "halfRadio":
                    Bitmap halfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.NewDrawnHalfNote), 250, 120);
                    mouseCoord.X = mouseCoord.X - 126;
                    mouseCoord.Y = mouseCoord.Y - 70;
                    mgr.DrawImage(halfNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 2;
                    pointArray[counterPointArray] = mouseCoord;
                    break;
                case "dottedHalfRadio":
                        Bitmap dottedHalfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnDottedHalfNote), 57, 55);
                    mouseCoord.X = mouseCoord.X - 35;
                    mouseCoord.Y = mouseCoord.Y - 35;
                    mgr.DrawImage(dottedHalfNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 3;
                    pointArray[counterPointArray] = mouseCoord;
                    break;
                case "wholeRadio":
                    Bitmap wholeNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnWholeNote), 45, 70);
                    mouseCoord.X = mouseCoord.X - 25;
                    mouseCoord.Y = mouseCoord.Y - 38;
                    mgr.DrawImage(wholeNote, mouseCoord);
                    rhythmArray[counterRhythmArray] = 4;
                    pointArray[counterPointArray] = mouseCoord;
                    break;
                case "quarterRestRadio":
                    Bitmap quarterRest = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnQuarterRest), 45, 70);
                    mouseCoord.X = mouseCoord.X - 28;
                    mouseCoord.Y = mouseCoord.Y - 38;
                    mgr.DrawImage(quarterRest, mouseCoord);
                    rhythmArray[counterRhythmArray] = 5;
                    pointArray[counterPointArray] = mouseCoord;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("ERROR !! \nNote not selected !!");
                    break;

            }

            counterNoteArray++;
            counterRhythmArray++;
            counterPointArray++;

            // GRAPHICS OBJECT MUST BE DISPOSED OF NO MATTER WHAT RIGHT BEFORE EVENT ENDS
            mgr.Dispose();   // dispose graphics object for storage
            
        }
        // -------------------------------------------------------------------------------------

        // Functions for Playing notes ---------------------------------------------------------
        private void playButton_Click(object sender, EventArgs e)
        {
            
            int i = 0; // index for arrays

            if(noteArray[i] == null)
            {
                System.Windows.Forms.MessageBox.Show("ERROR !! \nNotes have " +
                        "not been placed yet !!");
            }

            while (noteArray[i] != null) 
            {
                int sleepTime = (int)((60.0 / tempo) * 1000);

                if (rhythmArray[i] == 2)        // if next rhythm is half note
                    sleepTime = sleepTime * 2;
                else if (rhythmArray[i] == 3)   // if next rhythm is dotted half note
                    sleepTime = sleepTime * 3;  
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
                    case "N":
                        player.Stop();
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("ERROR !! \nNotes have " +
                        "not been placed yet !!");
                        break;

                }
                Thread.Sleep(sleepTime);
                i++;
            }
            //while (noteArray[i] != null);

        }
        // -------------------------------------------------------------------------------------

        // Functions for undo or delete notes --------------------------------------------------
        private void undoButton_Click(object sender, EventArgs e)
        {
            musicalStaffPanel.Refresh();

            // these functions redraw the staff lines that get erased on Refresh, and all the
            // notes placed exempting the most recent note
            RedrawLines();
            checkForUndo = 1;
            DrawNotes();
            
        }

        private void RedrawLines()
        {
            // all variables needed to redraw staff lines correctly
            Graphics draw = musicalStaffPanel.CreateGraphics();
            int i;
            int count = 9;
            int staffButtonCount = disableButtonCounter;
            while (staffButtonCount != 0)
            {
                for (i = count; i < count + 5; i++)
                {
                    draw.DrawLine(Pens.Black, 0, i * staffHght, musicalStaffPanel.Width - 45, i * staffHght);
                }
                draw.DrawLine(Pens.Black, 0, (i * staffHght) - 12, 0, (i * staffHght) - 60);
                draw.DrawLine(Pens.Black, (musicalStaffPanel.Width / 3) + 30, (i * staffHght) - 12,
                   (musicalStaffPanel.Width / 3) + 30, (i * staffHght) - 60);
                draw.DrawLine(Pens.Black, (musicalStaffPanel.Width / 2) + 150, (i * staffHght) - 12,
                    (musicalStaffPanel.Width / 2) + 150, (i * staffHght) - 60);
                draw.DrawLine(Pens.Black, musicalStaffPanel.Width - 45, (i * staffHght) - 12,
                    musicalStaffPanel.Width - 45, (i * staffHght) - 60);

                count = i + 3;
                staffButtonCount--;

                if (disableButtonCounter == 4)
                {
                    SolidBrush endBrush = new SolidBrush(Color.Black);
                    draw.FillRectangle(endBrush, musicalStaffPanel.Width - 52, 396,
                        7, 48);
                    draw.DrawLine(Pens.Black, musicalStaffPanel.Width - 57, 443,
                        musicalStaffPanel.Width - 57, 396);

                    newMusicLineButton.BackColor = Color.LightGray;
                    newMusicLineButton.ForeColor = Color.Gray;
                    newMusicLineButton.Enabled = false;

                    endBrush.Dispose();  // disposes graphics object for storage
                }
            }

            draw.Dispose();
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to delete all placed notes ?",
                "??", MessageBoxButtons.YesNo);
            

           if(dlgResult == DialogResult.Yes)
            { 

            musicalStaffPanel.Refresh();

            for (int i = 0; i <= counterNoteArray; i++)
            {
                noteArray[i] = null;
            }

                // these functions redraw the staff lines that get erased on Refresh
                RedrawLines();

            // resets all the array counters to start from the beginning
            counterNoteArray = 0;
            counterPointArray = 0;
            counterRhythmArray = 0;

            // to make sure nothing gets played
            noteArray[counterNoteArray] = null;
            }

        }
        // -------------------------------------------------------------------------------------

        // Functions For Printing Page ---------------------------------------------------------

        private void printButton_Click(object sender, EventArgs e)
        {
            newMusicLineButton.Visible = false;
            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument1;

            DialogResult result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print(); 
            }

            newMusicLineButton.Visible = true; 

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // painting musical staff panel and all the notes for the PDF
            Bitmap musicalStaff = new Bitmap(musicalStaffPanel.Width, musicalStaffPanel.Height);
            musicalStaffPanel.DrawToBitmap(musicalStaff, new Rectangle(0, 0, musicalStaffPanel.Width, musicalStaffPanel.Height));

            e.Graphics.DrawImage(musicalStaff, 0, 0);

            // this is for redrawing staff lines for PDF
            int index;
            int count = 9;
            int staffButtonCount = disableButtonCounter;
            while (staffButtonCount != 0)
            {
                for (index = count; index < count + 5; index++)
                {
                    e.Graphics.DrawLine(Pens.Black, 0, index * staffHght, musicalStaffPanel.Width - 45, index * staffHght);
                }
                e.Graphics.DrawLine(Pens.Black, 0, (index * staffHght) - 12, 0, (index * staffHght) - 60);
                e.Graphics.DrawLine(Pens.Black, (musicalStaffPanel.Width / 3) + 30, (index * staffHght) - 12,
                   (musicalStaffPanel.Width / 3) + 30, (index * staffHght) - 60);
                e.Graphics.DrawLine(Pens.Black, (musicalStaffPanel.Width / 2) + 150, (index * staffHght) - 12,
                    (musicalStaffPanel.Width / 2) + 150, (index * staffHght) - 60);
                e.Graphics.DrawLine(Pens.Black, musicalStaffPanel.Width - 45, (index * staffHght) - 12,
                    musicalStaffPanel.Width - 45, (index * staffHght) - 60);

                count = index + 3;
                staffButtonCount--;

                if (disableButtonCounter == 4)
                {
                    SolidBrush endBrush = new SolidBrush(Color.Black);
                    e.Graphics.FillRectangle(endBrush, musicalStaffPanel.Width - 52, 396,
                        7, 48);
                    e.Graphics.DrawLine(Pens.Black, musicalStaffPanel.Width - 57, 443,
                        musicalStaffPanel.Width - 57, 396);

                    newMusicLineButton.BackColor = Color.LightGray;
                    newMusicLineButton.ForeColor = Color.Gray;
                    newMusicLineButton.Enabled = false;

                    endBrush.Dispose();  // disposes graphics object for storage
                }
            }

            int i = 0;
            while (noteArray[i] != null)
            {
                int XCoord = pointArray[i].X;
                int YCoord = pointArray[i].Y - 2;
                switch (rhythmArray[i])
                {
                    case 1:
                        Bitmap quarterNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.NewDrawnQuarterNote), 60, 110);
                        e.Graphics.DrawImage(quarterNote, XCoord, YCoord);
                        break;
                    case 2:
                        Bitmap halfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.NewDrawnHalfNote), 250, 120);
                        e.Graphics.DrawImage(halfNote, XCoord, YCoord);
                        break;
                    case 3:
                        Bitmap dottedHalfNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                        Resources.DrawnDottedHalfNote), 57, 55);
                        e.Graphics.DrawImage(dottedHalfNote, XCoord, YCoord);
                        break;
                    case 4:
                        Bitmap wholeNote = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.DrawnWholeNote), 45, 70);
                        e.Graphics.DrawImage(wholeNote, XCoord, YCoord);
                        break;
                    case 5:
                        Bitmap quarterRest = new Bitmap(new Bitmap(Orchestrate_Project.Properties.
                            Resources.DrawnQuarterRest), 45, 70);
                        e.Graphics.DrawImage(quarterRest, XCoord, YCoord);
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("ERROR !! \nNotes have " +
                        "not been placed yet !!");
                        break;
                }

                i++;
            }


        }
    }
}
