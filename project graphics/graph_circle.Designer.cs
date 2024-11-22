﻿namespace project_graphics
{
    partial class graph_circle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graph_circle));
            pictur = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictur).BeginInit();
            SuspendLayout();
            // 
            // pictur
            // 
            pictur.BackColor = Color.Silver;
            pictur.Location = new Point(-1, -1);
            pictur.Name = "pictur";
            pictur.Size = new Size(800, 570);
            pictur.SizeMode = PictureBoxSizeMode.StretchImage;
            pictur.TabIndex = 2;
            pictur.TabStop = false;
            // 
            // graph_circle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(pictur);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(450, 200);
            Name = "graph_circle";
            StartPosition = FormStartPosition.Manual;
            Text = "Bresenham Circle Drawing Algorithm";
            ((System.ComponentModel.ISupportInitialize)pictur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictur;
    }
}