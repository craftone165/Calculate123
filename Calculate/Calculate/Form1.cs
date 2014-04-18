﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculate.BinaryOperations;
using Calculate.SortingOperations;
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
            ResultArgument.Text = calculator.Calculate(first, second).ToString();
        }

        private void UnaryCalculation(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation(name);
            ResultArgument.Text = calculator.Calculate(first).ToString();
        }

        private void SortCalculation(string name)
        {
            string[] first = FirstArgument.Text.Split(' ');
            int[] array = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                array[i] = Convert.ToInt32(first[i]);
            }
            ISortingOperation calculator = SortingOperationsFactory.CreateOperation(name);
            ResultArgument.Text = calculator.Sort(array).ToString();
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

        private void log2_Click(object sender, EventArgs e)
        {
            UnaryCalculation("log2");
        }

        private void ln_Click_1(object sender, EventArgs e)
        {
            UnaryCalculation("ln");
        }

        private void expPower_Click(object sender, EventArgs e)
        {
            UnaryCalculation("exppower");
        }
    }
}
