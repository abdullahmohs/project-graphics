namespace final_project_graphics
{
    partial class point
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(point));
            panel1 = new Panel();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtx1 = new TextBox();
            txtx2 = new TextBox();
            txty2 = new TextBox();
            txty1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtx1);
            panel1.Controls.Add(txtx2);
            panel1.Controls.Add(txty2);
            panel1.Controls.Add(txty1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 260);
            panel1.TabIndex = 0;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(226, 103);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 10;
            label6.Text = "Y2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 103);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 9;
            label5.Text = "X2";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(226, 44);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 8;
            label4.Text = "Y1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 44);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 7;
            label3.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 124);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 6;
            label2.Text = "Enter Second Point";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 70);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 5;
            label1.Text = "Enter First Point";
            // 
            // txtx1
            // 
            txtx1.Location = new Point(152, 68);
            txtx1.Name = "txtx1";
            txtx1.Size = new Size(46, 23);
            txtx1.TabIndex = 4;
            // 
            // txtx2
            // 
            txtx2.Location = new Point(152, 125);
            txtx2.Name = "txtx2";
            txtx2.Size = new Size(46, 23);
            txtx2.TabIndex = 3;
            // 
            // txty2
            // 
            txty2.Location = new Point(217, 125);
            txty2.Name = "txty2";
            txty2.Size = new Size(46, 23);
            txty2.TabIndex = 2;
            // 
            // txty1
            // 
            txty1.Location = new Point(216, 68);
            txty1.Name = "txty1";
            txty1.Size = new Size(46, 23);
            txty1.TabIndex = 0;
            // 
            // point
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 257);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "point";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Point";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txty1;
        private TextBox txtx1;
        private TextBox txtx2;
        private TextBox txty2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button3;
    }
}