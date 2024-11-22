namespace final_project_graphics
{
    partial class circlepoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(circlepoint));
            panel1 = new Panel();
            txtx = new TextBox();
            txtradius = new TextBox();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            txty = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(txtx);
            panel1.Controls.Add(txtradius);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txty);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 260);
            panel1.TabIndex = 4;
            // 
            // txtx
            // 
            txtx.Location = new Point(146, 29);
            txtx.Name = "txtx";
            txtx.Size = new Size(46, 23);
            txtx.TabIndex = 14;
            // 
            // txtradius
            // 
            txtradius.Location = new Point(146, 117);
            txtradius.Name = "txtradius";
            txtradius.Size = new Size(46, 23);
            txtradius.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 119);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 12;
            label3.Text = "Enter Radius";
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
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 6;
            label2.Text = "Enter Y Center";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 5;
            label1.Text = "Enter X Center";
            // 
            // txty
            // 
            txty.Location = new Point(146, 71);
            txty.Name = "txty";
            txty.Size = new Size(46, 23);
            txty.TabIndex = 3;
            // 
            // circlepoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 258);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "circlepoint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Point";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtx1;
        private TextBox txty2;
        private TextBox txty1;
        private Panel panel1;
        private TextBox txtx;
        private TextBox txtradius;
        private Label label3;
        private Button button3;
        private Label label2;
        private Label label1;
        private TextBox txty;
    }
}