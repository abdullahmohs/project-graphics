
using System.Drawing;
using project_graphics;
using static System.Windows.Forms.AxHost;

namespace final_project_graphics
{
    public partial class tabledda : Form
    {
        graph_dda graph_dda = new graph_dda();
        int x1, y1, x2, y2;

        public tabledda(int x1, int y1, int x2, int y2)
        {
            InitializeComponent();
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            LineDDA(x1, y1, x2, y2);
        }

        void LineDDA(int x1, int y1, int x2, int y2)
        {

            label.Location = new System.Drawing.Point(100, 30);
            label.Text = "DDA Line from ( " + x1 + " ," + y1 + " ) to ( " + x2 + " ," + y2 + " )";

            if ((x1 > x2 && y1 > y2) || (x1 > x2 && y2 > y1))
            {
                  swap(ref x1, ref x2);
                  swap(ref y1, ref y2);
            }

            int step, k,dx = x2 -x1,dy= y2-y1;
            double slope, yIncrement = y1, xIncrement = x1;
            slope = (double)(dy) / (x2 - x1);
           
            if (slope<=1)
            {
                step = x2 - x1;
                 for (k = 0; k < step; k++)
                 {
                     yIncrement += slope;
                     string formattedNumber = yIncrement.ToString("0.00");
                     data.Rows.Add(k, ++x1, formattedNumber, (x1, Math.Round(yIncrement)));
                    if (k + 1 == step)
                    {
                        graph_dda.lineAlgorithm(x1, (int)Math.Round(yIncrement, 0),true);
                    }
                    else
                    {
                        graph_dda.lineAlgorithm(x1, (int)Math.Round(yIncrement, 0), false);

                    }

                }
            }
            else
            {
                step = y2 - y1;
                for (k = 0; k < step; k++)
                {
                    xIncrement += 1 / slope;
                    string formattedNumber = xIncrement.ToString("0.00");
                    data.Rows.Add(k, formattedNumber, ++y1, (Math.Round(xIncrement), y1));
                    if(k+1 == step)
                    {
                        graph_dda.lineAlgorithm((int)(Math.Round(xIncrement)), y1, true);
                    }
                    else
                    {
                        graph_dda.lineAlgorithm((int)(Math.Round(xIncrement)), y1, false);
                    }
                }
            }
        }
        void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }
}
