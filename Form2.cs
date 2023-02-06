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
    public partial class Form2 : Form
    {
        int num1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Clear();
            textBox1.Text = " ";

            label2.Text = null;
            label2.Text = " ";

            label6.Text = null;
            label6.Text = " ";

            label7.Text = null;
            label7.Text = " ";

            label8.Text = null;
            label8.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //num1 = Convert.ToInt32(textBox1.Text);
            if (int.TryParse(textBox1.Text, out num1))
            {
                num1 = Convert.ToInt32(textBox1.Text);
            }
            label8.Text = Convert.ToString(num1);
            label7.Text= Convert.ToString(num1, 8);
            label6.Text = Convert.ToString(num1, 16);
            label2.Text = Convert.ToString(num1, 2);
             


        }

    }
}
