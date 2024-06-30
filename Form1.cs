using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_02
{
    public partial class Form1 : Form
    {
        private char sign;
        private double calculated_value;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            
        }


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void equal(object sender, EventArgs e)
        {

            if (textBox1.Text.Length>0)
            {
                double n2 = double.Parse(textBox1.Text);
                switch (sign)
                {
                    case '+' : 
                        add(calculated_value, n2);
                        break;
                    case '-':
                        sub(calculated_value, n2);
                        break;
                    case '*':
                        mul(calculated_value, n2);
                        break;
                    case '/':
                        divide(calculated_value, n2);
                        break;
                }
            }

        }
        public void add(double n1,double n2)
        {
            setResult(n1+n2);
        }
        public void sub(double n1, double n2)
        {
            setResult(n1 - n2);
        }
        public void mul(double n1, double n2)
        {
            setResult(n1 * n2);
        }
        public void divide(double n1, double n2)
        {
            setResult(n1 / n2);
        }
        public void setResult(double result)
        {
            textBox1.Text = result.ToString();
            textBox2.Text = " ";
        }
        public void storeValue(char sign)
        {
            string value = textBox1.Text;
            calculated_value = double.Parse(value);
            textBox2.Text = value+" "+sign.ToString();
            textBox1.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void add_Action(object sender, EventArgs e)
        {
            sign = '+';
            if (textBox1.Text.Length > 0)
                storeValue(sign);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sign = '-';
            if (textBox1.Text.Length > 0)
                storeValue(sign);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sign = '*';
            if (textBox1.Text.Length > 0)
                storeValue(sign);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sign = '/';
            if (textBox1.Text.Length > 0)
                storeValue(sign);
        }
    }
}
