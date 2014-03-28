using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculate.BinaryOperations;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            BinaryCalculation("+");
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            BinaryCalculation("-");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            BinaryCalculation("*");
        }

        private void deducation_Click(object sender, EventArgs e)
        {
            BinaryCalculation("/");
        }

        private void BinaryCalculation(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation(name);
            ResultArgument.Text = calculator.Calculate(first, second);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
