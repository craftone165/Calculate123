using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Adder adder = new Adder();
            ResultArgument.Text = adder.Calculate(first, second);
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Substracter substracter = new Substracter();
            ResultArgument.Text = substracter.Calculate(first, second);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Multiplicater multiplicater = new Multiplicater();
            ResultArgument.Text = multiplicater.Calculate(first, second);
        }

        private void deducation_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Deducater deducater = new Deducater();
            ResultArgument.Text = deducater.Calculate(first, second);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
