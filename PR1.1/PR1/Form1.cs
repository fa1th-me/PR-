using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                int side1 = Convert.ToInt32(txtSide1.Text);
                int side2 = Convert.ToInt32(txtSide2.Text);
                int side3 = Convert.ToInt32(txtSide3.Text);

                if (IsTriangle(side1, side2, side3))
                {
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    double area = CalculateTriangleArea(side1, side2, side3);
                    double per = CalculateTrianglePerimetr(side1, side2, side3);

                    label2.Text = "Тип треугольника по сторонам: " + triangleType;
                    label4.Text = "Периметр = " + per;
                    label5.Text = "Площадь = " + area;
                    
                }
                else
                {
                    MessageBox.Show("Такой треугольник не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения для сторон треугольника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidInput()
        {
            return double.TryParse(txtSide1.Text, out _) && double.TryParse(txtSide2.Text, out _) && double.TryParse(txtSide3.Text, out _);
        }
        private bool IsTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
        private string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Равносторонний треугольник";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Равнобедренный треугольник";
            }
            else
            {
                return "Разносторонний треугольник";
            }
        }
        private double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        private double CalculateTrianglePerimetr(double side1, double side2, double side3)
        {
            double per = side1 + side2 + side3;
            return per;
        }
    }
}
