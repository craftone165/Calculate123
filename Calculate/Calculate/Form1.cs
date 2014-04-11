using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculate.BinaryOperations;
using Calculate.UnaryOperations;

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

        private void UnaryCalculation(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation(name);
            ResultArgument.Text = calculator.Calculate(first);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cos_Click(object sender, EventArgs e)
        {
            UnaryCalculation("cos");
            
        }

        private void sin_Click(object sender, EventArgs e)
        {
            UnaryCalculation("sin"); 
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            UnaryCalculation("arcsin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnaryCalculation("tg");
        }

        private void pix_Click(object sender, EventArgs e)
        {
            UnaryCalculation("pix");
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            UnaryCalculation("sqrt");
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            UnaryCalculation("sqr");
        }

        private void clrscr_Click(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            ResultArgument.Text = "";
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            UnaryCalculation("arccos");
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            UnaryCalculation("ctg");
        }
    }
}
