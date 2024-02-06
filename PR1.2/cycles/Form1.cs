using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cycles
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double discriminant = CalculateDiscriminant(a, b, c);

                label5.Text = "Дискриминант: " + discriminant;
            }
            else
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double discriminant = CalculateDiscriminant(a, b, c);

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    label6.Text = $"Два корня: x1 = {root1}, x2 = {root2}";
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    label6.Text = $"Один корень: x = {root}";
                }
                else
                {
                    label6.Text = "Уравнение не имеет действительных корней";
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidInput()
        {
            return double.TryParse(textBox1.Text, out _) && double.TryParse(textBox2.Text, out _) && double.TryParse(textBox3.Text, out _);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите значения a,b,c чтобы узнать дискриминант квадратного уравнения и его корни", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
