using System.Drawing;
using project_graphics;
using WinFormsApp1;

namespace final_project_graphics
{
    public partial class tableellipse : Form
    {
        double xCenter, yCenter;
        double xRadius, yRadius;
        graph_ellipse graph_ellipse = new graph_ellipse();
        Graphics graphics;

        public tableellipse(double xCenter, double yCenter, double xRadius, double yRadius)
        {
            InitializeComponent();
            this.xCenter = xCenter; 
            this.yCenter = yCenter; 
            this.xRadius = xRadius; 
            this.yRadius = yRadius; 
            Ellipse(xCenter, yCenter, xRadius, yRadius);
        }

        void Ellipse(double xCenter, double yCenter, double xRadius, double yRadius)
        {
            label.Location = new System.Drawing.Point(40, 30);
            label.Text = " Ellipse With Center ( " + xCenter + " ," + yCenter + " ) X Radius ( " + xRadius + " ) Y Radius ( " + yRadius + " )";
            
            CalculatefirstHalf(yCenter, xCenter, xRadius, yRadius);
            draw(xCenter, yCenter, xRadius, yRadius);
        }
        void CalculatefirstHalf(double yCenter,double xCenter,double xRadius, double yRadius)
         {
            int k = 0;
            double x = 0, y = yRadius;
            x++;
            double yPoint = 2 * Math.Pow(yRadius, 2) * (x);
            double xPoint = 2 * Math.Pow(xRadius, 2) * y; 
            double p1 = (Math.Pow(yRadius, 2)) - (Math.Pow(xRadius, 2) * yRadius) + Math.Pow(xRadius, 2) * 1 / 4;//-332
                                                                                                                 //int d = b2 - a2 * (b) + a2 / 4; // -716

            while (yPoint < xPoint)
            {
                if (p1 < 0)
                {
                    data.Rows.Add(k, p1, (x, y), yPoint, xPoint);
                    p1 += yPoint + Math.Pow(yRadius, 2); 
                }
                else
                {
                    data.Rows.Add(k, p1, (x, --y), yPoint, xPoint);
                    p1 += yPoint - xPoint + Math.Pow(yRadius, 2); 
                }
                yPoint = 2 * Math.Pow(yRadius, 2) * (x + 1); 

                if (p1 > 0)
                {
                    xPoint = 2 * Math.Pow(xRadius, 2) * (y - 1);
                }
                else
                {
                    xPoint = 2 * Math.Pow(xRadius, 2) * (y); 
                }
                k++;
                x++;
            }
            data.Rows.Add(k, p1, (x, --y), yPoint, xPoint);
            CalculatesecondHalf(x,y,yRadius,xRadius,xCenter ,yCenter);
         }
         void CalculatesecondHalf(double x, double y,double yRadius,double xRadius, double xCneter, double yCenter)
         {
             double p1 = Math.Pow(yRadius, 2) * Math.Pow(x+ .5, 2) + Math.Pow(xRadius, 2) * Math.Pow(y -1, 2) - Math.Pow(yRadius, 2) * Math.Pow(xRadius, 2);
             int k = 0;
             double yPoint = 2 * Math.Pow(yRadius, 2) * (x+1); 
             double xPoint = 2 * Math.Pow(xRadius, 2) * (--y);

             while (y>0)
             {
                 if (p1 > 0)
                 {
                    data1.Rows.Add(k, p1, (x, y), yPoint, xPoint);
                    p1 += - xPoint + Math.Pow(x, 2);
                 }
                 else
                 {
                    x++;
                    data1.Rows.Add(k, p1, (x, y), yPoint, xPoint);
                    p1 += yPoint - xPoint + Math.Pow(xRadius, 2);
                 }
                 if (p1 > 0)
                 {
                     xPoint = 2 * Math.Pow(xRadius, 2) * (y - 1);
                 }
                 else
                 {
                     xPoint = 2 * Math.Pow(xRadius, 2) * (y);
                 }
                 y--;
                 k++;
             }
             data1.Rows.Add(k, p1, (x, y), "ــــــ", "ــــــ");
         }
        void draw(double xCenter,double yCenter , double xRadius, double yRadius)
        {
            int x = 0;
            int y = (int)yRadius; 
            int twoA2 = (int)(2 * (Math.Pow(xRadius, 2))); 
            int twoB2 = (int)(2 * (Math.Pow(yRadius, 2)));
            int d = (int)((Math.Pow(yRadius, 2)) - (Math.Pow(xRadius, 2) * 2 * yRadius) + Math.Pow(xRadius, 2) * 1 / 4);//-332

            int dx = 0; 
            int dy = (int)(twoA2 * yRadius); 

            // Region 1
            while (dx < dy)
            {
               x++;
                dx += twoB2; 
                if (d >= 0) 
                {
                    y--; 
                    dy -= twoA2; 
                    d -= dy; 
                }
                d += dx + (int)(Math.Pow(yRadius, 2));
                graph_ellipse.ellipseAlgorithm((int)(xCenter + x), (int)(yCenter + y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter - x), (int)(yCenter + y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter + x), (int)(yCenter - y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter - x), (int)(yCenter - y));
            }

            // Region 2
            d =(int)(Math.Pow(yRadius, 2) * Math.Pow(x + .5, 2) + Math.Pow(xRadius, 2) * Math.Pow(y - 1, 2) - Math.Pow(yRadius, 2) * Math.Pow(xRadius, 2)); 
            while (y > 0) 
            {
                y--; 
                dy -= twoA2;
                if (d <= 0)
                {
                    x++;
                    dx += twoB2;
                    d += dx;
                }
                d -= dy + (int)(Math.Pow(xRadius, 2));;
                graph_ellipse.ellipseAlgorithm((int)(xCenter + x), (int)(yCenter + y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter - x), (int)(yCenter + y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter + x), (int)(yCenter - y));
                graph_ellipse.ellipseAlgorithm((int)(xCenter - x), (int)(yCenter - y));
            }
            graph_ellipse.showPaint(); 
        }
    }
}
