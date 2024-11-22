using final_project_graphics;
using project_graphics;

namespace WinFormsApp1
{
    public partial class draw : Form
    {
        string typeShape;

        public draw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            typeShape = "dda";
            point p = new point(typeShape);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typeShape = "brenseham";
            point p = new point(typeShape);
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            circlepoint p = new circlepoint();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ellipsepoint p = new ellipsepoint();
            p.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
