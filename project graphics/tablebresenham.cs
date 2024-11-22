using project_graphics;

namespace final_project_graphics
{
    public partial class tablebresenham : Form
    {
        int x1, y1, x2, y2;
        string Octant;
        graph_bresenham graph_Bresenham = new graph_bresenham();
        public tablebresenham(int x1, int y1, int x2, int y2)
        {
            InitializeComponent();
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            Calculate(x1, y1, x2, y2);
        }

        void Calculate(int x1, int y1, int x2, int y2)
        {
            label.Location = new System.Drawing.Point(40, 30);
            label.Text = "Brenseham Line from ( " + x1 + " ," + y1 + " ) to ( " + x2 + " ," + y2 + " )";
            int dx = x2 - x1;
            int dy = y2 - y1;

            double slope = (double)dy / (double)dx;

            if (slope >=0 && slope <= 1 && x2 > x1)
            {
               label1.Text = "First Octant";
                Octant = "first";
            }
            else if(slope >=1 && slope <= double.PositiveInfinity && y2 > y1)
            {
                label1.Text = "Second Octant";
                Octant = "second";
                swap(ref x1,ref y1);
                swap(ref x2,ref y2);

            }
            else if (slope > double.NegativeInfinity && slope < -1 && y2> y1)
            {
                label1.Text = "Third Octant";
                Octant = "third";
                swap(ref x1, ref y1);
                swap(ref x2, ref y2);
            }
            else if (slope >= -1 && slope <=0 && x1 > x2 && dx < 0 && dy > 0)
            {
                label1.Text = "Fourth Octant";
                Octant = "fourth";
            }
            else if (slope > 0 && slope <= 1 && x1 > x2 && dx < 0 && dy < 0 )
            {
                label1.Text = "Fifth Octant";
                Octant = "fifth";
            }
            else if(slope >= 1 && slope <= double.PositiveInfinity && y2 < y1)
            {
                label1.Text = "Sixth Octant";
                Octant = "sixth";
                swap(ref x1,ref y1);
                swap(ref x2,ref y2);
            }
            else if(slope > double.NegativeInfinity && slope < -1 && y2 < y1)
            {
                label1.Text = "Seventh Octant";
                Octant = "seventh";
                swap(ref x1, ref y1);
                swap(ref x2, ref y2);
            }
            else
            {
                label1.Text = "Eighth Octant";
                Octant = "eighth";
            }
            switch (Octant)
            {
                case "first": firstOctant(x1,y1,x2,y2); break;
                case "second": secondOctant(x1, y1, x2, y2); break;
                case "third": thirdOctant(x1, y1, x2, y2); break;
                case "fourth": fourthOctant(x1, y1, x2, y2);break;
                case "fifth": fifthOctant(x1, y1, x2, y2); break;
                case "sixth": sixthOctant(x1, y1, x2, y2); break;
                case "seventh": seventhOctant(x1, y1, x2, y2); break;
                case "eighth": eighthOctant(x1, y1, x2, y2); break;
            }
        }

        void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        void firstOctant(int x1, int y1, int x2,int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 < x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (++x1, y1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (++x1, ++y1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }

        void secondOctant(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 < x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (y1, ++x1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (++y1, ++x1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void thirdOctant(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = -(y2 - y1);
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 < x2)
            {

                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (y1, ++x1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (--y1, ++x1));
                    if (x1+1 == x2)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void fourthOctant (int x1, int y1, int x2, int y2)
        {

            int dx = -(x2 - x1);
            int dy = y2 - y1;
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 > x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (--x1, y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (--x1, ++y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void fifthOctant(int x1, int y1, int x2, int y2)
        {
            int dx = -(x2 - x1);
            int dy = -(y2 - y1);
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 > x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (--x1, y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (--x1, --y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void sixthOctant(int x1, int y1, int x2, int y2)
        {
            int dx = -(x2 - x1);
            int dy = -(y2 - y1);
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 > x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (y1, --x1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(y1,x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (--y1, --x1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void seventhOctant(int x1, int y1, int x2, int y2)
        {
            int dx = -(x2 - x1);
            int dy = (y2 - y1);
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 > x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (y1 , --x1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (++y1, --x1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(y1, x1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
        void eighthOctant(int x1, int y1, int x2, int y2)
        {
            int dx = (x2 - x1);
            int dy = -(y2 - y1);
            int pk = (2 * dy) - dx;
            int k = 0;

            while (x1 < x2)
            {
                if (pk < 0)
                {
                    data.Rows.Add(k, pk, (++x1, y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * dy;
                }
                else
                {
                    data.Rows.Add(k, pk, (++x1, --y1));
                    if (x1 == x2 + 1)
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, true);
                    }
                    else
                    {
                        graph_Bresenham.lineAlgorithm(x1, y1, false);
                    }
                    pk += 2 * (dy - dx);
                }
                k++;
            }
        }
    }

}
