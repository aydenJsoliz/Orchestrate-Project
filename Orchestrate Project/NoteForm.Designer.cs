
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
            this.nothingRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.quarterRadio.Location = new System.Drawing.Point(19, 21);
            this.quarterRadio.Name = "quarterRadio";
            this.quarterRadio.Size = new System.Drawing.Size(112, 21);
            this.quarterRadio.TabIndex = 1;
            this.quarterRadio.Text = "Quarter Note";
            this.quarterRadio.UseVisualStyleBackColor = false;
            // 
            // halfRadio
            // 
            this.halfRadio.AutoSize = true;
            this.halfRadio.Location = new System.Drawing.Point(166, 21);
            this.halfRadio.Name = "halfRadio";
            this.halfRadio.Size = new System.Drawing.Size(88, 21);
            this.halfRadio.TabIndex = 3;
            this.halfRadio.Text = "Half Note";
            this.halfRadio.UseVisualStyleBackColor = true;
            // 
            // wholeRadio
            // 
            this.wholeRadio.AutoSize = true;
            this.wholeRadio.Location = new System.Drawing.Point(316, 21);
            this.wholeRadio.Name = "wholeRadio";
            this.wholeRadio.Size = new System.Drawing.Size(103, 21);
            this.wholeRadio.TabIndex = 5;
            this.wholeRadio.Text = "Whole Note";
            this.wholeRadio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nothingRadio);
            this.panel1.Controls.Add(this.quarterRadio);
            this.panel1.Controls.Add(this.halfRadio);
            this.panel1.Controls.Add(this.wholeRadio);
            this.panel1.Location = new System.Drawing.Point(77, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 100);
            this.panel1.TabIndex = 8;
            // 
            // nothingRadio
            // 
            this.nothingRadio.AutoSize = true;
            this.nothingRadio.Checked = true;
            this.nothingRadio.Location = new System.Drawing.Point(457, 21);
            this.nothingRadio.Name = "nothingRadio";
            this.nothingRadio.Size = new System.Drawing.Size(78, 21);
            this.nothingRadio.TabIndex = 9;
            this.nothingRadio.TabStop = true;
            this.nothingRadio.Text = "Nothing";
            this.nothingRadio.UseVisualStyleBackColor = true;
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
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}