using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marklist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox9.Text = (Convert.ToInt32(textBox8.Text) / 5).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int average = Convert.ToInt32(textBox9.Text);
            if (average >= 75)
            {
                textBox10.Text = "Distinction";
            }
            else if (average >= 60)
            {
                textBox10.Text = "First Class";
            }
            else if (average >= 50)
            {
                textBox10.Text = "Second Class";
            }
            else
            {
                textBox10.Text = "Fail";
            }   
        }

       
    }
}
