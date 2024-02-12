﻿
namespace Orchestrate_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.tempoInputBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.radioLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newMusicLineButton = new System.Windows.Forms.Button();
            this.musicalStaffPanel = new System.Windows.Forms.Panel();
            this.trebleAndTime = new System.Windows.Forms.PictureBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.notePopupButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.musicalStaffPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trebleAndTime)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(967, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel1.Font = new System.Drawing.Font("Bodoni MT", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(387, 9);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(315, 68);
            this.titleLabel1.TabIndex = 3;
            this.titleLabel1.Text = "Orchestrate";
            // 
            // tempoLabel
            // 
            this.tempoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tempoLabel.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoLabel.Location = new System.Drawing.Point(12, 111);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(129, 57);
            this.tempoLabel.TabIndex = 4;
            this.tempoLabel.Text = "Tempo: ";
            this.tempoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempoInputBox
            // 
            this.tempoInputBox.BackColor = System.Drawing.Color.White;
            this.tempoInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempoInputBox.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoInputBox.Location = new System.Drawing.Point(76, 120);
            this.tempoInputBox.Name = "tempoInputBox";
            this.tempoInputBox.Size = new System.Drawing.Size(55, 35);
            this.tempoInputBox.TabIndex = 5;
            this.tempoInputBox.TabStop = false;
            this.tempoInputBox.Text = "60";
            this.tempoInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempoInputBox.TextChanged += new System.EventHandler(this.tempoInputBox_TextChanged_1);
            this.tempoInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempoInputBox_KeyPress);
            this.tempoInputBox.Leave += new System.EventHandler(this.tempoInputBox_Leave);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Bodoni MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(1004, 71);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(40, 55);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "?";
            this.toolTip1.SetToolTip(this.helpButton, "Help");
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLabel.Location = new System.Drawing.Point(235, 145);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(15, 23);
            this.radioLabel.TabIndex = 12;
            this.radioLabel.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Middle C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "G5 note";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "From 60 - 120";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(170, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 60);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newMusicLineButton
            // 
            this.newMusicLineButton.BackColor = System.Drawing.Color.Silver;
            this.newMusicLineButton.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMusicLineButton.Location = new System.Drawing.Point(1001, 12);
            this.newMusicLineButton.Name = "newMusicLineButton";
            this.newMusicLineButton.Size = new System.Drawing.Size(40, 65);
            this.newMusicLineButton.TabIndex = 1;
            this.newMusicLineButton.Text = "+";
            this.toolTip1.SetToolTip(this.newMusicLineButton, "Draw new staff lines");
            this.newMusicLineButton.UseVisualStyleBackColor = false;
            this.newMusicLineButton.Click += new System.EventHandler(this.newMusicLineButton_Click);
            // 
            // musicalStaffPanel
            // 
            this.musicalStaffPanel.AllowDrop = true;
            this.musicalStaffPanel.AutoScrollMargin = new System.Drawing.Size(0, 500);
            this.musicalStaffPanel.BackColor = System.Drawing.Color.White;
            this.musicalStaffPanel.Controls.Add(this.newMusicLineButton);
            this.musicalStaffPanel.Controls.Add(this.trebleAndTime);
            this.musicalStaffPanel.Location = new System.Drawing.Point(12, 198);
            this.musicalStaffPanel.Name = "musicalStaffPanel";
            this.musicalStaffPanel.Size = new System.Drawing.Size(1054, 599);
            this.musicalStaffPanel.TabIndex = 16;
            this.musicalStaffPanel.Click += new System.EventHandler(this.musicalStaffPanel_Click);
            this.musicalStaffPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.musicalStaffPanel_Paint);
            this.musicalStaffPanel.MouseLeave += new System.EventHandler(this.musicalStaffPanel_MouseLeave);
            this.musicalStaffPanel.MouseHover += new System.EventHandler(this.musicalStaffPanel_MouseHover);
            // 
            // trebleAndTime
            // 
            this.trebleAndTime.BackColor = System.Drawing.Color.Transparent;
            this.trebleAndTime.Cursor = System.Windows.Forms.Cursors.No;
            this.trebleAndTime.Image = global::Orchestrate_Project.Properties.Resources.Treble_Time;
            this.trebleAndTime.Location = new System.Drawing.Point(-34, -12);
            this.trebleAndTime.Name = "trebleAndTime";
            this.trebleAndTime.Size = new System.Drawing.Size(191, 126);
            this.trebleAndTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trebleAndTime.TabIndex = 0;
            this.trebleAndTime.TabStop = false;
            // 
            // recordButton
            // 
            this.recordButton.BackgroundImage = global::Orchestrate_Project.Properties.Resources.RecordButton;
            this.recordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordButton.Location = new System.Drawing.Point(831, 111);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(63, 60);
            this.recordButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.recordButton, "Record");
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::Orchestrate_Project.Properties.Resources.PlayButtonPic;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playButton.Location = new System.Drawing.Point(737, 111);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(69, 60);
            this.playButton.TabIndex = 7;
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.playButton, "Play");
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // notePopupButton
            // 
            this.notePopupButton.BackgroundImage = global::Orchestrate_Project.Properties.Resources.EigthNotePic;
            this.notePopupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notePopupButton.Location = new System.Drawing.Point(170, 108);
            this.notePopupButton.Name = "notePopupButton";
            this.notePopupButton.Size = new System.Drawing.Size(59, 60);
            this.notePopupButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.notePopupButton, "Note Selection");
            this.notePopupButton.UseVisualStyleBackColor = true;
            this.notePopupButton.Click += new System.EventHandler(this.notePopupButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.Control;
            this.printButton.BackgroundImage = global::Orchestrate_Project.Properties.Resources.PrinterPic;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printButton.Location = new System.Drawing.Point(12, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(56, 50);
            this.printButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.printButton, "Print Screen");
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1065, 802);
            this.Controls.Add(this.musicalStaffPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.notePopupButton);
            this.Controls.Add(this.tempoInputBox);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orchestrate";
            this.musicalStaffPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trebleAndTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.TextBox tempoInputBox;
        private System.Windows.Forms.Button notePopupButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel musicalStaffPanel;
        private System.Windows.Forms.PictureBox trebleAndTime;
        private System.Windows.Forms.Button newMusicLineButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

