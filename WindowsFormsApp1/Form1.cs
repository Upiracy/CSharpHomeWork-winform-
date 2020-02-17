using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string num;
        public int flag;
        public double back, front;

        public Form1()
        {
            InitializeComponent();
        }

        void addNum(string n)
        {
            if (textBox.Text == "0")
            {
                num = n;
                textBox.Text = num;
            }
            else
            {
                num += n;
                front = double.Parse(num);
                textBox.Text = num;
            }
        }

        void setOpt(int i)
        {
            if (textBox.Text.Length > 0)
            {
                back = double.Parse(textBox.Text);
                num = "";
                flag = i;
                textBox.Text = "";
                textBox.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            num = num + '0';
            front = double.Parse(num);
            textBox.Text = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNum("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNum("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNum("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNum("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum("9");
        }

        private void add_Click(object sender, EventArgs e)//+
        {
            setOpt(1);
        }

        private void clr_Click(object sender, EventArgs e)
        {
            num = "";
            textBox.Text = "0";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            setOpt(2);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            setOpt(3);
        }

        private void div_Click(object sender, EventArgs e)
        {
            setOpt(4);
        }

        private void eql_Click(object sender, EventArgs e)
        {
            switch(flag)
            {
                case 1:
                    textBox.Text = (back + double.Parse(num)).ToString();
                    front = double.Parse(textBox.Text);
                    break;
                case 2:
                    textBox.Text = (back - double.Parse(num)).ToString();
                    front = double.Parse(textBox.Text);
                    break;
                case 3:
                    textBox.Text = (back * double.Parse(num)).ToString();
                    front = double.Parse(textBox.Text);
                    break;
                case 4:
                    textBox.Text = (back / double.Parse(num)).ToString();
                    front = double.Parse(textBox.Text);
                    break;
            }
        }


    }
}
