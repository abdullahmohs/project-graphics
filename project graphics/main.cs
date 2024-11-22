using WinFormsApp1;

namespace project_graphics
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw draw = new draw();
            draw.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transformation transformation = new transformation();
            transformation.Show();
            this.Hide();
        }
    }
}
