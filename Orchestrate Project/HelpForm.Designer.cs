
namespace Orchestrate_Project
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nothingOption = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.defaultPanel = new System.Windows.Forms.Panel();
            this.option1Label1 = new System.Windows.Forms.Label();
            this.defaultLabel = new System.Windows.Forms.Label();
            this.option1Label2 = new System.Windows.Forms.Label();
            this.option2Picture1 = new System.Windows.Forms.PictureBox();
            this.option1Picture2 = new System.Windows.Forms.PictureBox();
            this.option1Picture1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option2Label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.defaultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.option2Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin your musical journey right now !!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "How To Use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(711, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hello, and welcome to Orchestrate, the simple yet intuitive music composing appli" +
    "cation.\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.nothingOption);
            this.panel1.Controls.Add(this.option3);
            this.panel1.Controls.Add(this.option2);
            this.panel1.Controls.Add(this.option1);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 295);
            this.panel1.TabIndex = 5;
            // 
            // nothingOption
            // 
            this.nothingOption.AutoSize = true;
            this.nothingOption.Checked = true;
            this.nothingOption.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothingOption.Location = new System.Drawing.Point(18, 271);
            this.nothingOption.Name = "nothingOption";
            this.nothingOption.Size = new System.Drawing.Size(88, 25);
            this.nothingOption.TabIndex = 3;
            this.nothingOption.TabStop = true;
            this.nothingOption.Text = "Nothing";
            this.nothingOption.UseVisualStyleBackColor = true;
            this.nothingOption.Visible = false;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(18, 158);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(122, 46);
            this.option3.TabIndex = 2;
            this.option3.Text = "Editing \r\nMusical Staff";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.CheckedChanged += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(18, 92);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(100, 46);
            this.option2.TabIndex = 1;
            this.option2.Text = "Changing \r\nTempo";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(18, 28);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(103, 46);
            this.option1.TabIndex = 0;
            this.option1.Text = "Selecting\r\na Rhythm";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // defaultPanel
            // 
            this.defaultPanel.BackColor = System.Drawing.Color.White;
            this.defaultPanel.Controls.Add(this.option2Label1);
            this.defaultPanel.Controls.Add(this.option2Picture1);
            this.defaultPanel.Controls.Add(this.option1Picture2);
            this.defaultPanel.Controls.Add(this.option1Label2);
            this.defaultPanel.Controls.Add(this.option1Picture1);
            this.defaultPanel.Controls.Add(this.option1Label1);
            this.defaultPanel.Controls.Add(this.defaultLabel);
            this.defaultPanel.Location = new System.Drawing.Point(189, 185);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(599, 295);
            this.defaultPanel.TabIndex = 6;
            // 
            // option1Label1
            // 
            this.option1Label1.AutoSize = true;
            this.option1Label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label1.Location = new System.Drawing.Point(28, 28);
            this.option1Label1.Name = "option1Label1";
            this.option1Label1.Size = new System.Drawing.Size(444, 48);
            this.option1Label1.TabIndex = 1;
            this.option1Label1.Text = "Begin by clicking the button pictured to the right,\r\nwhich is present on the main" +
    " screen. ";
            this.option1Label1.Visible = false;
            // 
            // defaultLabel
            // 
            this.defaultLabel.AutoSize = true;
            this.defaultLabel.Font = new System.Drawing.Font("Bodoni MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultLabel.Location = new System.Drawing.Point(33, 82);
            this.defaultLabel.Name = "defaultLabel";
            this.defaultLabel.Size = new System.Drawing.Size(525, 100);
            this.defaultLabel.TabIndex = 0;
            this.defaultLabel.Text = "Start by clicking any of the \r\nbuttons on the left for help";
            // 
            // option1Label2
            // 
            this.option1Label2.AutoSize = true;
            this.option1Label2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label2.Location = new System.Drawing.Point(28, 141);
            this.option1Label2.Name = "option1Label2";
            this.option1Label2.Size = new System.Drawing.Size(399, 120);
            this.option1Label2.TabIndex = 3;
            this.option1Label2.Text = "When a selection has been made, as shown on\r\nthe right, make sure to EXIT the rhy" +
    "thm \r\nwindow to confirm.\r\n\r\nOtherwise, the selection will not be saved. ";
            this.option1Label2.Visible = false;
            // 
            // option2Picture1
            // 
            this.option2Picture1.Image = global::Orchestrate_Project.Properties.Resources.TempoBoxExample;
            this.option2Picture1.Location = new System.Drawing.Point(236, 195);
            this.option2Picture1.Name = "option2Picture1";
            this.option2Picture1.Size = new System.Drawing.Size(172, 97);
            this.option2Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option2Picture1.TabIndex = 5;
            this.option2Picture1.TabStop = false;
            this.option2Picture1.Visible = false;
            // 
            // option1Picture2
            // 
            this.option1Picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option1Picture2.Image = global::Orchestrate_Project.Properties.Resources.RhythmSelectionExample;
            this.option1Picture2.Location = new System.Drawing.Point(472, 116);
            this.option1Picture2.Name = "option1Picture2";
            this.option1Picture2.Size = new System.Drawing.Size(111, 165);
            this.option1Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option1Picture2.TabIndex = 4;
            this.option1Picture2.TabStop = false;
            this.option1Picture2.Visible = false;
            // 
            // option1Picture1
            // 
            this.option1Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option1Picture1.Image = global::Orchestrate_Project.Properties.Resources.EigthNotePic;
            this.option1Picture1.Location = new System.Drawing.Point(512, 28);
            this.option1Picture1.Name = "option1Picture1";
            this.option1Picture1.Size = new System.Drawing.Size(55, 62);
            this.option1Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option1Picture1.TabIndex = 2;
            this.option1Picture1.TabStop = false;
            this.option1Picture1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Orchestrate_Project.Properties.Resources.NotesTransparent;
            this.pictureBox2.Location = new System.Drawing.Point(701, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Orchestrate_Project.Properties.Resources.NotesTransparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // option2Label1
            // 
            this.option2Label1.AutoSize = true;
            this.option2Label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label1.Location = new System.Drawing.Point(3, 14);
            this.option2Label1.Name = "option2Label1";
            this.option2Label1.Size = new System.Drawing.Size(504, 168);
            this.option2Label1.TabIndex = 6;
            this.option2Label1.Text = resources.GetString("option2Label1.Text");
            this.option2Label1.Visible = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.defaultPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.defaultPanel.ResumeLayout(false);
            this.defaultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.option2Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton nothingOption;
        private System.Windows.Forms.Panel defaultPanel;
        private System.Windows.Forms.Label defaultLabel;
        private System.Windows.Forms.PictureBox option1Picture1;
        private System.Windows.Forms.Label option1Label1;
        private System.Windows.Forms.PictureBox option1Picture2;
        private System.Windows.Forms.Label option1Label2;
        private System.Windows.Forms.PictureBox option2Picture1;
        private System.Windows.Forms.Label option2Label1;
    }
}