namespace project_graphics
{
    partial class transformation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transformation));
            pictur = new PictureBox();
            translation = new CheckBox();
            rotaion = new CheckBox();
            scale = new CheckBox();
            reflation = new CheckBox();
            shear = new CheckBox();
            imge = new Button();
            data = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            label = new Label();
            label3 = new Label();
            xt = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            yt = new NumericUpDown();
            label4 = new Label();
            degree = new NumericUpDown();
            label6 = new Label();
            ys = new NumericUpDown();
            label7 = new Label();
            xs = new NumericUpDown();
            label10 = new Label();
            ysh = new NumericUpDown();
            label11 = new Label();
            xsh = new NumericUpDown();
            restButton = new Button();
            x_axis = new CheckBox();
            y_axis = new CheckBox();
            xy_axis = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)degree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ysh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xsh).BeginInit();
            SuspendLayout();
            // 
            // pictur
            // 
            pictur.BackColor = Color.WhiteSmoke;
            pictur.Location = new Point(2, 1);
            pictur.Name = "pictur";
            pictur.Size = new Size(711, 643);
            pictur.SizeMode = PictureBoxSizeMode.StretchImage;
            pictur.TabIndex = 3;
            pictur.TabStop = false;
            // 
            // translation
            // 
            translation.AutoSize = true;
            translation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translation.Location = new Point(920, 30);
            translation.Name = "translation";
            translation.Size = new Size(130, 29);
            translation.TabIndex = 23;
            translation.Text = "Translation";
            translation.UseVisualStyleBackColor = true;
            translation.CheckedChanged += translation_CheckedChanged;
            // 
            // rotaion
            // 
            rotaion.AutoSize = true;
            rotaion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rotaion.Location = new Point(766, 30);
            rotaion.Name = "rotaion";
            rotaion.Size = new Size(108, 29);
            rotaion.TabIndex = 24;
            rotaion.Text = "Rotation";
            rotaion.UseVisualStyleBackColor = true;
            rotaion.CheckedChanged += rotaion_CheckedChanged;
            // 
            // scale
            // 
            scale.AutoSize = true;
            scale.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scale.Location = new Point(949, 192);
            scale.Name = "scale";
            scale.Size = new Size(76, 29);
            scale.TabIndex = 25;
            scale.Text = "Scale";
            scale.UseVisualStyleBackColor = true;
            scale.CheckedChanged += scale_CheckedChanged;
            // 
            // reflation
            // 
            reflation.AutoSize = true;
            reflation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reflation.Location = new Point(766, 192);
            reflation.Name = "reflation";
            reflation.Size = new Size(120, 29);
            reflation.TabIndex = 26;
            reflation.Text = "Reflection";
            reflation.UseVisualStyleBackColor = true;
            reflation.CheckedChanged += reflation_CheckedChanged;
            // 
            // shear
            // 
            shear.AutoSize = true;
            shear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shear.Location = new Point(863, 342);
            shear.Name = "shear";
            shear.RightToLeft = RightToLeft.No;
            shear.Size = new Size(81, 29);
            shear.TabIndex = 27;
            shear.Text = "Shear";
            shear.UseVisualStyleBackColor = true;
            shear.CheckedChanged += shear_CheckedChanged;
            // 
            // imge
            // 
            imge.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            imge.ForeColor = SystemColors.ActiveCaptionText;
            imge.Location = new Point(233, 650);
            imge.Name = "imge";
            imge.Size = new Size(160, 41);
            imge.TabIndex = 29;
            imge.Text = "Select Image";
            imge.UseVisualStyleBackColor = true;
            imge.Click += imge_Click;
            // 
            // data
            // 
            data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            data.Location = new Point(770, 477);
            data.Name = "data";
            data.ReadOnly = true;
            data.RowHeadersWidth = 43;
            data.ScrollBars = ScrollBars.Vertical;
            data.Size = new Size(258, 174);
            data.TabIndex = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "Operation";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(719, 168);
            label.Name = "label";
            label.Size = new Size(346, 21);
            label.TabIndex = 33;
            label.Text = "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(719, 318);
            label3.Name = "label3";
            label3.Size = new Size(346, 21);
            label3.TabIndex = 34;
            label3.Text = "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ";
            // 
            // xt
            // 
            xt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xt.Location = new Point(958, 79);
            xt.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            xt.Minimum = new decimal(new int[] { 500, 0, 0, int.MinValue });
            xt.Name = "xt";
            xt.Size = new Size(70, 27);
            xt.TabIndex = 35;
            xt.TextAlign = HorizontalAlignment.Center;
            xt.ValueChanged += xt_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(920, 81);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 36;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(920, 124);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 38;
            label2.Text = "Y";
            // 
            // yt
            // 
            yt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yt.Location = new Point(958, 124);
            yt.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            yt.Minimum = new decimal(new int[] { 500, 0, 0, int.MinValue });
            yt.Name = "yt";
            yt.Size = new Size(70, 27);
            yt.TabIndex = 37;
            yt.TextAlign = HorizontalAlignment.Center;
            yt.ValueChanged += yt_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(729, 104);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 42;
            label4.Text = "Degree";
            // 
            // degree
            // 
            degree.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            degree.Location = new Point(802, 103);
            degree.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            degree.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            degree.Name = "degree";
            degree.Size = new Size(83, 27);
            degree.TabIndex = 41;
            degree.TextAlign = HorizontalAlignment.Center;
            degree.ValueChanged += degree_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(941, 291);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 46;
            label6.Text = "Y";
            // 
            // ys
            // 
            ys.DecimalPlaces = 1;
            ys.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ys.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ys.Location = new Point(981, 293);
            ys.Name = "ys";
            ys.Size = new Size(70, 27);
            ys.TabIndex = 45;
            ys.TextAlign = HorizontalAlignment.Center;
            ys.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ys.ValueChanged += ys_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(941, 238);
            label7.Name = "label7";
            label7.Size = new Size(24, 25);
            label7.TabIndex = 44;
            label7.Text = "X";
            // 
            // xs
            // 
            xs.DecimalPlaces = 1;
            xs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xs.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            xs.Location = new Point(981, 240);
            xs.Name = "xs";
            xs.RightToLeft = RightToLeft.No;
            xs.Size = new Size(70, 27);
            xs.TabIndex = 43;
            xs.TextAlign = HorizontalAlignment.Center;
            xs.Value = new decimal(new int[] { 1, 0, 0, 0 });
            xs.ValueChanged += xs_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(767, 397);
            label10.Name = "label10";
            label10.Size = new Size(24, 25);
            label10.TabIndex = 54;
            label10.Text = "Y";
            // 
            // ysh
            // 
            ysh.DecimalPlaces = 1;
            ysh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ysh.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ysh.Location = new Point(807, 399);
            ysh.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            ysh.Name = "ysh";
            ysh.Size = new Size(70, 27);
            ysh.TabIndex = 53;
            ysh.TextAlign = HorizontalAlignment.Center;
            ysh.ValueChanged += ysh_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(909, 397);
            label11.Name = "label11";
            label11.Size = new Size(24, 25);
            label11.TabIndex = 52;
            label11.Text = "X";
            // 
            // xsh
            // 
            xsh.DecimalPlaces = 1;
            xsh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xsh.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            xsh.Location = new Point(949, 399);
            xsh.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            xsh.Name = "xsh";
            xsh.Size = new Size(70, 27);
            xsh.TabIndex = 51;
            xsh.TextAlign = HorizontalAlignment.Center;
            xsh.ValueChanged += xsh_ValueChanged;
            // 
            // restButton
            // 
            restButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restButton.Location = new Point(-1, 732);
            restButton.Name = "restButton";
            restButton.Size = new Size(87, 34);
            restButton.TabIndex = 55;
            restButton.Text = "Reset";
            restButton.UseVisualStyleBackColor = true;
            restButton.Click += button1_Click;
            // 
            // x_axis
            // 
            x_axis.AutoSize = true;
            x_axis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x_axis.Location = new Point(792, 227);
            x_axis.Name = "x_axis";
            x_axis.Size = new Size(75, 25);
            x_axis.TabIndex = 57;
            x_axis.Text = "X-axis";
            x_axis.UseVisualStyleBackColor = true;
            x_axis.CheckedChanged += x_axis_CheckedChanged;
            // 
            // y_axis
            // 
            y_axis.AutoSize = true;
            y_axis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            y_axis.Location = new Point(792, 258);
            y_axis.Name = "y_axis";
            y_axis.Size = new Size(75, 25);
            y_axis.TabIndex = 59;
            y_axis.Text = "Y-axis";
            y_axis.UseVisualStyleBackColor = true;
            y_axis.CheckedChanged += y_axis_CheckedChanged;
            // 
            // xy_axis
            // 
            xy_axis.AutoSize = true;
            xy_axis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xy_axis.Location = new Point(792, 289);
            xy_axis.Name = "xy_axis";
            xy_axis.Size = new Size(91, 25);
            xy_axis.TabIndex = 60;
            xy_axis.Text = "X-Y-axis";
            xy_axis.UseVisualStyleBackColor = true;
            xy_axis.CheckedChanged += xy_axis_CheckedChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(-1, 641);
            button1.Name = "button1";
            button1.Size = new Size(92, 22);
            button1.TabIndex = 61;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // transformation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1063, 765);
            Controls.Add(button1);
            Controls.Add(xy_axis);
            Controls.Add(y_axis);
            Controls.Add(x_axis);
            Controls.Add(restButton);
            Controls.Add(label10);
            Controls.Add(ysh);
            Controls.Add(label11);
            Controls.Add(xsh);
            Controls.Add(label6);
            Controls.Add(ys);
            Controls.Add(label7);
            Controls.Add(xs);
            Controls.Add(label4);
            Controls.Add(degree);
            Controls.Add(label2);
            Controls.Add(yt);
            Controls.Add(label1);
            Controls.Add(xt);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(data);
            Controls.Add(imge);
            Controls.Add(shear);
            Controls.Add(reflation);
            Controls.Add(scale);
            Controls.Add(rotaion);
            Controls.Add(translation);
            Controls.Add(pictur);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "transformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transformation";
            ((System.ComponentModel.ISupportInitialize)pictur).EndInit();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ((System.ComponentModel.ISupportInitialize)xt).EndInit();
            ((System.ComponentModel.ISupportInitialize)yt).EndInit();
            ((System.ComponentModel.ISupportInitialize)degree).EndInit();
            ((System.ComponentModel.ISupportInitialize)ys).EndInit();
            ((System.ComponentModel.ISupportInitialize)xs).EndInit();
            ((System.ComponentModel.ISupportInitialize)ysh).EndInit();
            ((System.ComponentModel.ISupportInitialize)xsh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictur;
        private CheckBox translation;
        private CheckBox rotaion;
        private CheckBox scale;
        private CheckBox reflation;
        private CheckBox shear;
        private Button imge;
        private DataGridView data;
        private DataGridViewTextBoxColumn Column2;
        private Label label;
        private Label label3;
        private NumericUpDown xt;
        private Label label1;
        private Label label2;
        private NumericUpDown yt;
        private Label label4;
        private NumericUpDown degree;
        private Label label6;
        private NumericUpDown ys;
        private Label label7;
        private NumericUpDown xs;
        private Label label10;
        private NumericUpDown ysh;
        private Label label11;
        private NumericUpDown xsh;
        private Button restButton;
        private CheckBox x_axis;
        private CheckBox y_axis;
        private CheckBox xy_axis;
        private Button button1;
    }
}