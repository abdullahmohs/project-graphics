using project_graphics;

namespace final_project_graphics
{

    public partial class tablecircle : Form
    {
        graph_circle graph_Circle = new graph_circle();

        int xCenter, yCenter, radius;
        public tablecircle(int xCenter, int yCenter, int radius)
        {
            InitializeComponent();
            this.xCenter = xCenter;
            this.yCenter = yCenter;
            this.radius = radius;
            Circle(xCenter, yCenter, radius);
        }

        void Circle(int xCenter, int yCenter, int radius)
        {
            label.Location = new System.Drawing.Point(150, 30);
            label.Text = "Bresenham Circle With Center ( " + xCenter + " ," + yCenter + " ) Radius ( " + radius + " )";
            int x = 0, k = 0;
            int y = radius;
            int p = 1 - radius;
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    data.Rows.Add(k, p, (x, y), 2 * x, 2 * y);
                    graph_Circle.circleAlgorithm(x+xCenter, y+yCenter);
                    graph_Circle.circleAlgorithm(y + xCenter, x + yCenter);
                    graph_Circle.circleAlgorithm(y + xCenter, -x + yCenter);
                    graph_Circle.circleAlgorithm(x + xCenter, -y + yCenter);
                    graph_Circle.circleAlgorithm(-x + xCenter, -y + yCenter);
                    graph_Circle.circleAlgorithm(-y + xCenter, -x + yCenter);
                    graph_Circle.circleAlgorithm(-y + xCenter, x + yCenter);
                    graph_Circle.circleAlgorithm(-x + xCenter, y + yCenter);

                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    data.Rows.Add(k, p, (x, y), 2 * x, 2 * y);
                    graph_Circle.circleAlgorithm(x + xCenter, y + yCenter);
                    graph_Circle.circleAlgorithm(y + xCenter, x + yCenter);
                    graph_Circle.circleAlgorithm(y + xCenter, -x + yCenter);
                    graph_Circle.circleAlgorithm(x + xCenter, -y + yCenter);
                    graph_Circle.circleAlgorithm(-x + xCenter, -y + yCenter);
                    graph_Circle.circleAlgorithm(-y + xCenter, -x + yCenter);
                    graph_Circle.circleAlgorithm(-y + xCenter, x + yCenter);
                    graph_Circle.circleAlgorithm(-x + xCenter, y + yCenter);

                    p += 2 * (x - y) + 1;
                }
                k++;
            }
            graph_Circle.showPaint(true);
        }

    }
}
