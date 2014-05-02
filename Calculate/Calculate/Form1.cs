using System;
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
            try
            {
                double first = Convert.ToDouble(FirstArgument.Text);
                double second = Convert.ToDouble(SecondArgument.Text);
                IBinaryOperation calculator = BinaryOperationFactory.CreateOperation(name);
                ResultArgument.Text = calculator.Calculate(first, second).ToString();
            }
            catch (Exception e)
            {
                ResultArgument.Text = e.Message;
            }
        }

        private void UnaryCalculation(string name)
        {
            try
            {
                double first = Convert.ToDouble(FirstArgument.Text);
                IUnaryOperation calculator = UnaryOperationFactory.CreateOperation(name);
                ResultArgument.Text = calculator.Calculate(first).ToString();
            }
            catch (Exception e)
            {
                ResultArgument.Text = e.Message;
            }
    }

        private void SortCalculation(string name)
        {
            try
            {
                string[] first = FirstArgument.Text.Split(' ');
                int[] array = new int[first.Length];
                for (int i = 0; i < first.Length; i++)
                {
                    array[i] = Convert.ToInt32(first[i]);
                }
                ISortingOperation calculator = SortingOperationsFactory.CreateOperation(name);
                calculator.Sort(array);
                string result = string.Empty;
                for (int i = 0; i < first.Length; i++)
                {
                    result += array[i] + " ";
                }
                ResultArgument.Text = result;

            }
            catch (Exception e)
            {
                ResultArgument.Text = e.Message;
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SortCalculation("bogosort");
        
        }

        private void quicksort_Click(object sender, EventArgs e)
        {
            SortCalculation("quicksort");
        }
    }
}
