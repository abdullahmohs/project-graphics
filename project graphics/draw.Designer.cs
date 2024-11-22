namespace WinFormsApp1
{
    partial class draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(draw));
            panel1 = new Panel();
            ellipse = new Button();
            circle = new Button();
            brenseham = new Button();
            dda = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ellipse);
            panel1.Controls.Add(circle);
            panel1.Controls.Add(brenseham);
            panel1.Controls.Add(dda);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 378);
            panel1.TabIndex = 1;
            // 
            // ellipse
            // 
            ellipse.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ellipse.Location = new Point(138, 296);
            ellipse.Name = "ellipse";
            ellipse.Size = new Size(194, 75);
            ellipse.TabIndex = 3;
            ellipse.Text = "Ellipse";
            ellipse.UseVisualStyleBackColor = true;
            ellipse.Click += button4_Click;
            // 
            // circle
            // 
            circle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circle.Location = new Point(138, 202);
            circle.Name = "circle";
            circle.Size = new Size(194, 75);
            circle.TabIndex = 2;
            circle.Text = "Circle";
            circle.UseVisualStyleBackColor = true;
            circle.Click += button3_Click;
            // 
            // brenseham
            // 
            brenseham.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brenseham.Location = new Point(138, 104);
            brenseham.Name = "brenseham";
            brenseham.Size = new Size(194, 75);
            brenseham.TabIndex = 1;
            brenseham.Text = "Line Breseham";
            brenseham.UseVisualStyleBackColor = true;
            brenseham.Click += button2_Click;
            // 
            // dda
            // 
            dda.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dda.ForeColor = SystemColors.ActiveCaptionText;
            dda.Location = new Point(138, 13);
            dda.Name = "dda";
            dda.Size = new Size(194, 75);
            dda.TabIndex = 0;
            dda.Text = "Line DDA";
            dda.UseVisualStyleBackColor = true;
            dda.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(91, 22);
            button1.TabIndex = 62;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // draw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 376);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "draw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Draw";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ellipse;
        private Button circle;
        private Button brenseham;
        private Button dda;
        private Button button1;
    }
}