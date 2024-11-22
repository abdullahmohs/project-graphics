using project_graphics;

namespace final_project_graphics
{
    public partial class point : Form
    {
        string typeShape;
        tablebresenham tablebrenseham;

        public point(string typeShape)
        {
            this.typeShape = typeShape;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (typeShape)
            {
                case "dda":
                    drawDDA();
                    break;
                case "brenseham":
                    drawBrenseham();
                    break;
            }

        }
        void drawDDA()
        {
            int x1, y1, x2, y2;
            x1 = int.Parse(txtx1.Text);
            y1 = int.Parse(txty1.Text);
            x2 = int.Parse(txtx2.Text);
            y2 = int.Parse(txty2.Text);

            tabledda tabledda = new tabledda(x1, y1, x2, y2);
            tabledda.Show();
            this.Hide();

        }

        void drawBrenseham()
        {
            int x1, y1, x2, y2;
            x1 = int.Parse(txtx1.Text);
            y1 = int.Parse(txty1.Text);
            x2 = int.Parse(txtx2.Text);
            y2 = int.Parse(txty2.Text);
            tablebrenseham = new tablebresenham(x1, y1, x2, y2);
            tablebrenseham.Show();
            this.Hide();
        }
    }
}
