using System.Security.Cryptography.Xml;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string input = "";
        List<string> operators = new List<string>();
        List<double> numbers = new List<double>();

        double calculate()
        {
            double resault=0;
            for (int i = 0; i < operators.Count; i++) {
                if(i==0) resault = numbers[i];
                switch (operators[i])
                {
                    case "+":
                        resault += numbers[i + 1];
                        break;
                    case "-":
                        resault -= numbers[i + 1];
                        break;
                    case "*":
                        resault *= numbers[i + 1];
                        break;
                    case "/":
                        resault /= numbers[i + 1];
                        break;
                    default:
                        break;
                }
            }
            return resault;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            input += ".";
            textBox1.Text = input;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            textBox1.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)//clear
        {
            input = "";
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)//+
        {
            numbers.Add(Convert.ToDouble(input));
            Button button = (Button)sender;
            operators.Add(button.Text);
            input = "";
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)//-
        {
            numbers.Add(Convert.ToDouble(input));
            Button button = (Button)sender;
            operators.Add(button.Text);
            input = "";
            textBox1.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)//*
        {
            numbers.Add(Convert.ToDouble(input));
            Button button = (Button)sender;
            operators.Add(button.Text);
            input = "";
            textBox1.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)// /
        {
            numbers.Add(Convert.ToDouble(input));
            Button button = (Button)sender;
            operators.Add(button.Text);
            input = "";
            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToDouble(input));
            input = "";
            input += calculate();
            operators.Clear();
            numbers.Clear();
            textBox1.Text = input;
        }
    }
}
