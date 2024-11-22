namespace final_project_graphics
{
    public partial class circlepoint : Form
    {
        int x, y, radius;
        tablecircle tablecircle;
        public circlepoint()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            x = int.Parse(txtx.Text);
            y = int.Parse(txty.Text);
            radius = int.Parse(txtradius.Text);
            tablecircle = new tablecircle(x, y, radius);
            tablecircle.Show();
            this.Hide();
        }
    }
}
