using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HW_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInfo(Figure figure)
        {
            label3.Text = figure.Perimetr.ToString();
            label4.Text = figure.Square.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Figure figure = null;

            double param1 = 0;
            double param2 = 0;
            double param3 = 0;

            Double.TryParse(textBox1.Text, out param1);
            Double.TryParse(textBox2.Text, out param2);
            Double.TryParse(textBox3.Text, out param3);

            if (radioButton1.Checked)
            {
                figure = new Triangle(param1, param2, param3);
            }
            else if (radioButton2.Checked)
            {
                figure = new Circle(param1);
            }
            else if (radioButton3.Checked)
            {
                figure = new Rectangle(param1, param2);
            }
            else if (radioButton4.Checked)
            {
                figure = new Square(param1);
            }
            else if (radioButton5.Checked)
            {
                figure = new Rhombus(param1, param2);
            }

            ShowInfo(figure);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ClearForm();
                label6.Text = "Side 1  =";
                label6.Visible = true;
                textBox1.Visible = true;
                label7.Text = "Side 2  =";
                label7.Visible = true;
                textBox2.Visible = true;
                label8.Text = "Side 3  =";
                label8.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ClearForm();
                label6.Text = "Radius  =";
                label6.Visible = true;
                textBox1.Visible = true;
                label7.Visible = false;
                textBox2.Visible = false;
                label8.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ClearForm();
                label6.Text = "Side 1  =";
                label6.Visible = true;
                textBox1.Visible = true;
                label7.Text = "Side 2  =";
                label7.Visible = true;
                textBox2.Visible = true;
                label8.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ClearForm();
                label6.Text = "Side  =";
                label6.Visible = true;
                textBox1.Visible = true;
                label7.Visible = false;
                textBox2.Visible = false;
                label8.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                ClearForm();
                label6.Text = "Diagonale 1  =";
                label6.Visible = true;
                textBox1.Visible = true;
                label7.Text = "Diagonale 2  =";
                label7.Visible = true;
                textBox2.Visible = true;
                label8.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
}
