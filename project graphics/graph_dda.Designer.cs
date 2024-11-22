namespace project_graphics
{
    partial class graph_dda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graph_dda));
            picture = new PictureBox();
            pictur = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictur).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.BackColor = Color.Silver;
            picture.Location = new Point(0, 0);
            picture.Name = "picture";
            picture.Size = new Size(800, 570);
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // pictur
            // 
            pictur.BackColor = Color.Silver;
            pictur.Location = new Point(0, 0);
            pictur.Name = "pictur";
            pictur.Size = new Size(800, 570);
            pictur.SizeMode = PictureBoxSizeMode.StretchImage;
            pictur.TabIndex = 1;
            pictur.TabStop = false;
            // 
            // graph_dda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(pictur);
            Controls.Add(picture);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(480, 200);
            Name = "graph_dda";
            StartPosition = FormStartPosition.Manual;
            Text = "DDA Line Drawing Algorithm";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picture;
        private PictureBox pictur;
    }
}