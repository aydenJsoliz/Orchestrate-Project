
namespace Orchestrate_Project
{
    partial class NoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.quarterRadio = new System.Windows.Forms.RadioButton();
            this.halfRadio = new System.Windows.Forms.RadioButton();
            this.wholeRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quarterRestRadio = new System.Windows.Forms.RadioButton();
            this.nothingRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a rhythm note option and exit this page !\r\n\r\n\r\n";
            // 
            // quarterRadio
            // 
            this.quarterRadio.AutoSize = true;
            this.quarterRadio.BackColor = System.Drawing.Color.Transparent;
            this.quarterRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quarterRadio.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterRadio.Location = new System.Drawing.Point(19, 21);
            this.quarterRadio.Name = "quarterRadio";
            this.quarterRadio.Size = new System.Drawing.Size(123, 25);
            this.quarterRadio.TabIndex = 1;
            this.quarterRadio.Text = "Quarter Note";
            this.quarterRadio.UseVisualStyleBackColor = false;
            // 
            // halfRadio
            // 
            this.halfRadio.AutoSize = true;
            this.halfRadio.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfRadio.Location = new System.Drawing.Point(166, 21);
            this.halfRadio.Name = "halfRadio";
            this.halfRadio.Size = new System.Drawing.Size(101, 25);
            this.halfRadio.TabIndex = 3;
            this.halfRadio.Text = "Half Note";
            this.halfRadio.UseVisualStyleBackColor = true;
            // 
            // wholeRadio
            // 
            this.wholeRadio.AutoSize = true;
            this.wholeRadio.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeRadio.Location = new System.Drawing.Point(316, 21);
            this.wholeRadio.Name = "wholeRadio";
            this.wholeRadio.Size = new System.Drawing.Size(113, 25);
            this.wholeRadio.TabIndex = 5;
            this.wholeRadio.Text = "Whole Note";
            this.wholeRadio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quarterRestRadio);
            this.panel1.Controls.Add(this.nothingRadio);
            this.panel1.Controls.Add(this.quarterRadio);
            this.panel1.Controls.Add(this.halfRadio);
            this.panel1.Controls.Add(this.wholeRadio);
            this.panel1.Location = new System.Drawing.Point(77, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 67);
            this.panel1.TabIndex = 8;
            // 
            // quarterRestRadio
            // 
            this.quarterRestRadio.AutoSize = true;
            this.quarterRestRadio.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterRestRadio.Location = new System.Drawing.Point(472, 21);
            this.quarterRestRadio.Name = "quarterRestRadio";
            this.quarterRestRadio.Size = new System.Drawing.Size(121, 25);
            this.quarterRestRadio.TabIndex = 10;
            this.quarterRestRadio.TabStop = true;
            this.quarterRestRadio.Text = "Quarter Rest";
            this.quarterRestRadio.UseVisualStyleBackColor = true;
            // 
            // nothingRadio
            // 
            this.nothingRadio.AutoSize = true;
            this.nothingRadio.Checked = true;
            this.nothingRadio.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothingRadio.Location = new System.Drawing.Point(645, 21);
            this.nothingRadio.Name = "nothingRadio";
            this.nothingRadio.Size = new System.Drawing.Size(88, 25);
            this.nothingRadio.TabIndex = 9;
            this.nothingRadio.TabStop = true;
            this.nothingRadio.Text = "Nothing";
            this.nothingRadio.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Orchestrate_Project.Properties.Resources.DrawnQuarterRest;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(502, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 204);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Orchestrate_Project.Properties.Resources.DrawnWholeNote;
            this.pictureBox3.Location = new System.Drawing.Point(383, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 195);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Orchestrate_Project.Properties.Resources.NewDrawnQuarterNote;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Orchestrate_Project.Properties.Resources.NewDrawnHalfNote;
            this.pictureBox2.Location = new System.Drawing.Point(-119, -28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 89);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quarter Note, Quarter Rest = 1 Beat\r\nHalf Note = 2 Beats\r\nWhole Note = 4 Beats";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Selection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton quarterRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton halfRadio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton wholeRadio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton nothingRadio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton quarterRestRadio;
        private System.Windows.Forms.Label label2;
    }
}