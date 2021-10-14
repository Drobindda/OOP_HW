using System.Windows.Forms;

namespace OOP_HW_4_1
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TriangleForm_Load(object sender, System.EventArgs e)
        {

        }

        private void label12_Click(object sender, System.EventArgs e)
        {

        }

        private void label14_Click(object sender, System.EventArgs e)
        {

        }

        private void label13_Click(object sender, System.EventArgs e)
        {

        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void angleBC_CA_Click(object sender, System.EventArgs e)
        {

        }

        private void label10_Click(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelSquareText.Visible = true;
                Square.Visible = true;
                BC.Visible = false;
                CA.Visible = false;
                AB.Text = "Side  =";
                textBoxBC.Visible = false;
                textBoxCA.Visible = false;

            }
            else
            {
                labelSquareText.Visible = false;
                Square.Text = "";
                Square.Visible = false;
                BC.Visible = true;
                CA.Visible = true;
                AB.Text = "AB  =";
                textBoxBC.Visible = true;
                textBoxCA.Visible = true;
            }
        }

        private void MainBtn_Click(object sender, System.EventArgs e)
        {
            
            if (!checkBox1.Checked)
            {
                double AB = 0;
                double.TryParse(textBoxAB.Text, out AB);
                double BC = 0;
                double.TryParse(textBoxBC.Text, out BC);
                double CA = 0;
                double.TryParse(textBoxCA.Text, out CA);
                Triangle tri = new Triangle(AB, BC, CA);
                ShowInfo(tri);
            }
            else
            {
                double side = 0;
                double.TryParse(textBoxAB.Text, out side);
                EquilateralTriangle tri = new EquilateralTriangle(side);
                ShowInfo(tri);
                Square.Text = tri.Square.ToString();
            }
        }

        private void ShowInfo(Triangle triangle)
        {
            angleAB_BC.Text = triangle.AngleAB_BC.ToString();
            angleBC_CA.Text = triangle.AngleBC_CA.ToString();
            angleCA_AB.Text = triangle.AngleCA_AB.ToString();
            Perimetr.Text = triangle.Perimetr.ToString();
        }

        private void textBoxBC_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
