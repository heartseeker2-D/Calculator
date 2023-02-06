using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double res1;
        double res2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        // Отчистка с помощью кнопки С
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Clear();
            textBox1.Text = " ";

            label1.Text = null;
            label1.Text = " ";

            label3.Text = null;
            label3.Text = " ";

            textBox2.Text = null;
            textBox2.Clear();
            textBox2.Text = " ";
        }


        // Ввод чисел с панели формы
        private void button9_Click(object sender, EventArgs e)
        {
                textBox1.Text += "1"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Закрытие программы
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Операции с числами
        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "-";
            textBox1.Text = textBox1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res1 = num1 - num2;
            textBox3.Text += Convert.ToString(res1) + Environment.NewLine;
            label1.Text = Convert.ToString(res1);
            label3.Text = "Выбрано действие - (минус)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "+";
            textBox1.Text = textBox1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res1 = num1 + num2;
            textBox3.Text += Convert.ToString(res1) + Environment.NewLine;
            label1.Text = Convert.ToString(res1);
            label3.Text = "Выбрано действие + (плюс)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "*";
            textBox1.Text = textBox1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res1 = num1 * num2;
            textBox3.Text += Convert.ToString(res1) + Environment.NewLine;
            label1.Text = Convert.ToString(res1);
            label3.Text = "Выбрано действие * (умножение)";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "/";
            textBox1.Text = textBox1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res1 = num1 / num2;
            textBox3.Text += Convert.ToString(res1) + Environment.NewLine;
            label1.Text = Convert.ToString(res1);
            label3.Text = "Выбрано действие / (деление)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "%";
            textBox1.Text = textBox1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res1 = num1 / 100;
            textBox3.Text += Convert.ToString(res1) + Environment.NewLine;
            res2 = num2 / 100;
            label1.Text = Convert.ToString(res1);
            label1.Text = Convert.ToString(res2);
            label3.Text = "Выбрано действие / (деление)";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm = new Form2();
            myForm.ShowDialog();
            
        }

    }

}
