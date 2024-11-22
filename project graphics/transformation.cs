using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace project_graphics
{
    public partial class transformation : Form
    {
        Bitmap bitmap, startbitmap, tempBitmap;
        string selectedFileName;
        OpenFileDialog openFileDialog;
        public transformation()
        {
            InitializeComponent();
            startbitmap = new Bitmap(pictur.Width, pictur.Height);
            clearBitmap(ref startbitmap);
        }

        private void imge_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.png;)|*.jpg; *.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;
                try
                {
                    bitmap = new Bitmap(selectedFileName);
                    initiBitmap(ref bitmap, ref startbitmap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void translation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (translation.Checked)
                {
                    data.Rows.Add("Translation");
                    order(sender, e);
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i].Cells[0].Value == "Translation")
                        {
                            data.Rows.RemoveAt(i);
                        }
                    }
                    clearBitmap(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rotaion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rotaion.Checked)
                {
                    data.Rows.Add("Rotation");
                    order(sender, e);
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i].Cells[0].Value == "Rotation")
                        {
                            data.Rows.RemoveAt(i);
                        }
                    }
                    clearBitmap(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void scale_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (scale.Checked)
                {
                    data.Rows.Add("Scale");
                    order(sender, e);
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i].Cells[0].Value == "Scale")
                        {
                            data.Rows.RemoveAt(i);
                        }
                    }
                    clearBitmap(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void reflation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (reflation.Checked)
                {
                    data.Rows.Add("Reflection");
                    CheckChange(sender, e);
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i].Cells[0].Value == "Reflection")
                        {
                            data.Rows.RemoveAt(i);
                        }
                    }
                    clearBitmap(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void shear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (shear.Checked)
                {
                    data.Rows.Add("Shear");
                    xsh_ValueChanged(sender, e);
                    ysh_ValueChanged(sender, e);
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i].Cells[0].Value == "Shear")
                        {
                            data.Rows.RemoveAt(i);
                        }
                    }
                }
                clearBitmap(ref startbitmap);
                initiBitmap(ref bitmap, ref startbitmap);
            }
            catch (Exception ex)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            xt.Value = 0;
            yt.Value = 0;
            degree.Value = 0;
            xs.Value = 1;
            ys.Value = 1;
            xsh.Value = 0;
            ysh.Value = 0;
            translation.Checked = false;
            reflation.Checked = false;
            scale.Checked = false;
            shear.Checked = false;
            rotaion.Checked = false;
            data.Rows.Clear();
            clearBitmap(ref startbitmap);
            initiBitmap(ref bitmap, ref startbitmap);
            x_axis.Checked = false;
            y_axis.Checked = false;
            xy_axis.Checked = false;
        }

        private void xs_ValueChanged(object sender, EventArgs e)
        {
            if (scale.Checked)
            {
                Scale();
            }
        }

        private void ys_ValueChanged(object sender, EventArgs e)
        {
            if (scale.Checked)
            {
                Scale();
            }
        }

        private void xt_ValueChanged(object sender, EventArgs e)
        {
            if (translation.Checked)
            {
                Translation();
            }
        }

        private void yt_ValueChanged(object sender, EventArgs e)
        {
            if (translation.Checked)
            {
                Translation();
            }
        }
        void draw_X_axis(ref Bitmap bitmap)
        {
            for (int start = 0; start < pictur.Width; start++)
            {
                bitmap.SetPixel(start, pictur.Height / 2, Color.Black);
            }
            pictur.Image = bitmap;

        }
        void draw_Y_axis(ref Bitmap bitmap)
        {
            for (int start = 0; start < pictur.Height; start++)
            {
                bitmap.SetPixel(pictur.Width / 2, start, Color.Black);
            }

            pictur.Image = bitmap;
        }

        void clearBitmap(ref Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.WhiteSmoke);
                }
            }
            draw_X_axis(ref startbitmap);
            draw_Y_axis(ref startbitmap);
            pictur.Image = startbitmap;
        }
        void initiBitmap(ref Bitmap bitmap, ref Bitmap startbitmap)
        {
            using (Graphics g = Graphics.FromImage(startbitmap))
            {
                g.DrawImage(bitmap, pictur.Width / 2, (pictur.Height / 2) - 200, 200, 200);
            }
            pictur.Image = startbitmap;
        }


        private void x_axis_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(sender, e);

            if (reflation.Checked)
            {
                if (x_axis.Checked)
                {
                    clearBitmap(ref startbitmap);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            startbitmap.SetPixel((pictur.Width / 2) + x, (pictur.Height / 2) - y - 1 + (bitmap.Height), bitmap.GetPixel(x, y));
                        }
                    }

                    pictur.Image = startbitmap;
                }
                else
                {
                    clearBitmap(ref startbitmap);
                    draw_X_axis(ref startbitmap);
                    draw_Y_axis(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                    pictur.Image = startbitmap;
                }
            }
        }
        private void y_axis_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(sender, e);
            if (reflation.Checked)
            {
                if (y_axis.Checked)
                {
                    clearBitmap(ref startbitmap);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            startbitmap.SetPixel((pictur.Width / 2) - x - 1, (pictur.Height / 2) + y - (bitmap.Height), bitmap.GetPixel(x, y));
                        }
                    }

                    pictur.Image = startbitmap;
                }
                else
                {
                    clearBitmap(ref startbitmap);
                    draw_X_axis(ref startbitmap);
                    draw_Y_axis(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                    pictur.Image = startbitmap;
                }
            }
        }

        private void xy_axis_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(sender, e);

            if (reflation.Checked)
            {
                if (xy_axis.Checked)
                {
                    clearBitmap(ref startbitmap);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            startbitmap.SetPixel((pictur.Width / 2) - x - 1, (pictur.Height / 2) - y - 1 + (bitmap.Height), bitmap.GetPixel(x, y));
                        }
                    }

                    pictur.Image = startbitmap;
                }
                else
                {
                    clearBitmap(ref startbitmap);
                    draw_X_axis(ref startbitmap);
                    draw_Y_axis(ref startbitmap);
                    initiBitmap(ref bitmap, ref startbitmap);
                    pictur.Image = startbitmap;
                }
            }
        }
        private void CheckChange(object sender, EventArgs e)
        {
            try
            {
                CheckBox click = (CheckBox)sender;
                if (click.Checked)
                {
                    foreach (CheckBox checkbox in Controls)
                    {
                        if (checkbox != click)
                        {
                            checkbox.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void xsh_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (shear.Checked)
                {
                    clearBitmap(ref startbitmap);

                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            int newX = x + (int)Math.Round(((float)xsh.Value * y));
                            int newY = (int)Math.Round(((float)ysh.Value * x)) + y;
                            startbitmap.SetPixel((pictur.Width / 2) + newX, (pictur.Height / 2) + newY - (bitmap.Height), bitmap.GetPixel(x, y));
                        }
                    }
                    pictur.Image = startbitmap;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ysh_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (shear.Checked)
                {
                    clearBitmap(ref startbitmap);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            int newX = x + (int)Math.Round(((float)xsh.Value * y));
                            int newY = (int)Math.Round(((float)ysh.Value * x)) + y;
                            startbitmap.SetPixel((pictur.Width / 2) + newX, (pictur.Height / 2) + newY - (bitmap.Height), bitmap.GetPixel(x, y));
                        }
                    }
                    pictur.Image = startbitmap;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void order(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Cells[0].Value.ToString() == "Translation")
                {
                    xt_ValueChanged(sender, e);
                    yt_ValueChanged(sender, e);
                }
                else if (data.Rows[i].Cells[0].Value.ToString() == "Scale")
                {
                    xs_ValueChanged(sender, e);
                    ys_ValueChanged(sender, e);
                }
                else if (data.Rows[i].Cells[0].Value.ToString() == "Reflation")
                {

                }
                else if (data.Rows[i].Cells[0].Value.ToString() == "Rotaion")
                {

                }
                else if (data.Rows[i].Cells[0].Value.ToString() == "Shear")
                {

                }
            }
        }
        void Translation()
        {
            try
            {
                int newX = (int)xt.Value;
                int newY = (int)yt.Value;
                clearBitmap(ref startbitmap);
                using (Graphics g = Graphics.FromImage(startbitmap))
                {
                    g.DrawImage(bitmap, newX + (pictur.Width / 2), (pictur.Height / 2) - newY - 200, 200, 200);
                }
                pictur.Image = startbitmap;
            }
            catch (Exception ex)
            {
            }
        }
        void Scale()
        {
            try
            {
                float newWidth = (float)xs.Value * 200;
                float newHeight = (float)ys.Value * 200;
                clearBitmap(ref startbitmap);
                using (Graphics g = Graphics.FromImage(startbitmap))
                {
                    g.DrawImage(bitmap, (pictur.Width / 2), (pictur.Height / 2) - 200, newWidth, newHeight);
                }
                pictur.Image = startbitmap;
            }
            catch (Exception ex)
            {
            }
        }

        private void degree_ValueChanged(object sender, EventArgs e)
        {
            if (rotaion.Checked)
            {
                using (Graphics g = Graphics.FromImage(startbitmap))
                {
                    g.TranslateTransform(pictur.Width / 2, pictur.Height / 2);
                    g.RotateTransform(360.0f - float.Parse(degree.Value.ToString()));
                    g.TranslateTransform(-(pictur.Width / 2), -(pictur.Height / 2));
                    clearBitmap(ref startbitmap);
                    g.DrawImage(bitmap, (pictur.Width / 2) , (pictur.Height / 2) - 200 , 200, 200);
                }
            }
        }
    }
}



