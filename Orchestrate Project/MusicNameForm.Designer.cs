
namespace Orchestrate_Project
{
    partial class MusicNameForm
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
            this.musicNameLabel = new System.Windows.Forms.Label();
            this.musicNameBox = new System.Windows.Forms.TextBox();
            this.composerLabel = new System.Windows.Forms.Label();
            this.composerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // musicNameLabel
            // 
            this.musicNameLabel.AutoSize = true;
            this.musicNameLabel.Font = new System.Drawing.Font("Bodoni MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicNameLabel.Location = new System.Drawing.Point(12, 29);
            this.musicNameLabel.Name = "musicNameLabel";
            this.musicNameLabel.Size = new System.Drawing.Size(646, 53);
            this.musicNameLabel.TabIndex = 0;
            this.musicNameLabel.Text = "What is the name of your music ?";
            // 
            // musicNameBox
            // 
            this.musicNameBox.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicNameBox.Location = new System.Drawing.Point(32, 101);
            this.musicNameBox.Name = "musicNameBox";
            this.musicNameBox.Size = new System.Drawing.Size(212, 35);
            this.musicNameBox.TabIndex = 1;
            // 
            // composerLabel
            // 
            this.composerLabel.AutoSize = true;
            this.composerLabel.Font = new System.Drawing.Font("Bodoni MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.composerLabel.Location = new System.Drawing.Point(12, 165);
            this.composerLabel.Name = "composerLabel";
            this.composerLabel.Size = new System.Drawing.Size(608, 53);
            this.composerLabel.TabIndex = 2;
            this.composerLabel.Text = "What is your name, composer ?";
            // 
            // composerBox
            // 
            this.composerBox.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.composerBox.Location = new System.Drawing.Point(32, 234);
            this.composerBox.Name = "composerBox";
            this.composerBox.Size = new System.Drawing.Size(212, 35);
            this.composerBox.TabIndex = 3;
            // 
            // MusicNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(660, 292);
            this.Controls.Add(this.composerBox);
            this.Controls.Add(this.composerLabel);
            this.Controls.Add(this.musicNameBox);
            this.Controls.Add(this.musicNameLabel);
            this.Name = "MusicNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musicNameLabel;
        private System.Windows.Forms.TextBox musicNameBox;
        private System.Windows.Forms.Label composerLabel;
        private System.Windows.Forms.TextBox composerBox;
    }
}