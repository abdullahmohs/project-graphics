namespace final_project_graphics
{
    partial class ellipsepoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ellipsepoint));
            panel1 = new Panel();
            txtyradius = new TextBox();
            label4 = new Label();
            txtxcenter = new TextBox();
            txtxradius = new TextBox();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtycenter = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(txtyradius);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtxcenter);
            panel1.Controls.Add(txtxradius);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtycenter);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 260);
            panel1.TabIndex = 3;
            // 
            // txtyradius
            // 
            txtyradius.Location = new Point(146, 155);
            txtyradius.Name = "txtyradius";
            txtyradius.Size = new Size(46, 23);
            txtyradius.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 157);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 15;
            label4.Text = "Enter Y Radius";
            // 
            // txtxcenter
            // 
            txtxcenter.Location = new Point(146, 22);
            txtxcenter.Name = "txtxcenter";
            txtxcenter.Size = new Size(46, 23);
            txtxcenter.TabIndex = 14;
            // 
            // txtxradius
            // 
            txtxradius.Location = new Point(146, 110);
            txtxradius.Name = "txtxradius";
            txtxradius.Size = new Size(46, 23);
            txtxradius.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 12;
            label3.Text = "Enter X Radius";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(120, 205);
            button3.Name = "button3";
            button3.Size = new Size(143, 37);
            button3.TabIndex = 11;
            button3.Text = "Draw";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 6;
            label2.Text = "Enter Y Center";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 5;
            label1.Text = "Enter X Center";
            // 
            // txtycenter
            // 
            txtycenter.Location = new Point(146, 64);
            txtycenter.Name = "txtycenter";
            txtycenter.Size = new Size(46, 23);
            txtycenter.TabIndex = 3;
            // 
            // ellipsepoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 253);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ellipsepoint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Point";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtxcenter;
        private TextBox txtxradius;
        private Label label3;
        private Button button3;
        private Label label2;
        private Label label1;
        private TextBox txtycenter;
        private TextBox txtyradius;
        private Label label4;
    }
}