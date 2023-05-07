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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int val1, val2, val3;
            val1 = Convert.ToInt32(textBox1.Text);

            val2 = Convert.ToInt32(textBox2.Text);
            if (val1 < -1 && val2 < -1)
            {
                string warn1 = "Your Value1 and Value2 is wrong! ";
                Warning1.Text = warn1;
            }
            else if (val1 < -1)
            {
                string warn2 = "Your Value1 is wrong!";
                Warning1.Text = warn2;
                //Console.ReadLine();
                //goto b;
            }
            else if (val2 < -1)
            {
                string warn = "Your Value2 is wrong!";
                Warning1.Text = warn;
                //Console.ReadLine();
                //goto b;
            }
            else
            {
                Warning1.ResetText();
                val3 = val1 + val2;
                textBox3.Text = Convert.ToString(val3);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
           textBox1.ResetText();textBox2.ResetText();textBox3.ResetText();
            Warning1.ResetText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
           
            int val1, val2, val3;
            val1= Convert.ToInt32(textBox1.Text);
            
            val2 = Convert.ToInt32(textBox2.Text);
            if (val1 < -1 && val2 < -1)
            {
                string warn1 = "Your Value1 and Value2 is wrong! ";
                Warning1.Text = warn1;
            }
            else if (val1 < -1)
            {
                string warn2 = "Your Value1 is wrong!";
                Warning1.Text = warn2;
                //Console.ReadLine();
                //goto b;
            }
            else if (val2 < -1)
            {
                string warn = "Your Value2 is wrong!";
                Warning1.Text = warn;
                //Console.ReadLine();
                //goto b;
            }
            else
            {
                Warning1.ResetText();
                val3 = val1 - val2;
                textBox3.Text = Convert.ToString(val3);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Warning1_Click(object sender, EventArgs e)
        {

        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            int val1, val2,val3;
            val1 = Convert.ToInt32(textBox1.Text);
            val2 = Convert.ToInt32(textBox2.Text);
            if(val1 < -1 && val2 < -1)
            {
                string warn1 = "Your Value1 and Value2 is wrong! ";
                Warning1.Text = warn1;
            }
            else if (val1 < -1)
            {

                string warn2 = "Your Value1 is wrong! ";
                Warning1.Text = warn2;
            }
            else if(val2 < -1)
            {
                string warn = "Your Value2 is wrong! ";
                Warning1.Text = warn;
            }
            else
            {
                Warning1.ResetText();
                val3 = val1 * val2;
                textBox3.Text = Convert.ToString(val3);
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            int val1, val2, val3;
            val1 = Convert.ToInt32(textBox1.Text);
            val2 = Convert.ToInt32(textBox2.Text);
            if (val1 < -1 && val2 < -1)
            {
                string warn1 = "Your Value1 and Value2 is wrong! ";
                Warning1.Text = warn1;
            }
            else if (val1 < -1)
            {

                string warn2 = "Your Value1 is wrong! ";
                Warning1.Text = warn2;
            }
            else if (val2 < -1)
            {
                string warn = "Your Value2 is wrong! ";
                Warning1.Text = warn;
            }
            else
            {
                Warning1.ResetText();
                val3 = val1 / val2;
                textBox3.Text = Convert.ToString(val3);
            }
        }
    }
}
