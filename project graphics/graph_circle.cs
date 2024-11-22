using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_graphics
{

    public partial class graph_circle : Form
    {
        Bitmap bitmap;
        public graph_circle()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictur.Width, pictur.Height);
            draw_X_axis(ref bitmap);
            draw_Y_axis(ref bitmap);
        }
        public void circleAlgorithm(int x, int y)
        {
            bitmap.SetPixel(x + (pictur.Width / 2), (pictur.Height / 2) - y, Color.Blue);
        }

        public void showPaint(Boolean show)
        {
            this.Show();
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
    }
}
