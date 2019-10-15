using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigement_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1;
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R1 = 0.0;
            }
            double R2;
            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R2 = 0.0;
            }
            double RT = R1 + R2;
            label1.Text = " RT =" + RT;
            // this calculates the series circuit with 2 resistors

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double R3;
            try
            {
                R3 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R3 = 0.0;
            }
                double R4;
                try
                {
                    R4 = double.Parse(textBox9.Text);
                }
                catch
                {
                    MessageBox.Show("not correct value");
                    R4 = 0.0;
                }
                double R5;
                try
                {
                    R5 = double.Parse(textBox10.Text);
                }
                catch
                {
                    MessageBox.Show("not correct value");
                    R5 = 0.0;
                }
                double RT2 = R3 + R4 + R5;
                label2.Text = "RT2 =" + RT2;
                // this calculates the series circuit with 3 resistors
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double R6;
            try
            {
                R6 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R6 = 0.0;
            }
            double R7;
            try
            {
                R7 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R7 = 0.0;
            }
            double RT3 = 1.0 / (1.0 / R6 + 1.0 / R7);
            label3.Text = "RT3 =" + RT3;
            // this calculates the parallel circuit with 2 resistors
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double R8;
            try
            {
                R8 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R8 = 0.0;
            }
            double R9;
            try
            {
                R9 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R9 = 0.0;
            }
            double R10;
            try
            {
                R10 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                R10 = 0.0;
            }
            double RT4 = 1.0 / (1.0 / R8 + 1.0 / R9 + 1.0 / R10);
            label4.Text = "RT4 =" + RT4;
            // THIS CALCULATES THE PARALLEL CIRCUIT WITH 3 RESISTORS
        }
    }
}
