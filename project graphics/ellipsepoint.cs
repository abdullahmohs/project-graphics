namespace final_project_graphics
{
    public partial class ellipsepoint : Form
    {
        double xCenter, yCenter;
        double xRadius, yRadius;
        public ellipsepoint()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xCenter = double.Parse(txtxcenter.Text);
            yCenter = double.Parse(txtycenter.Text);
            xRadius = double.Parse(txtxradius.Text);
            yRadius = double.Parse(txtyradius.Text);
            tableellipse tableellipse = new tableellipse(xCenter, yCenter, xRadius, yRadius);
            tableellipse.Show();
            this.Hide();
        }

    }
}
