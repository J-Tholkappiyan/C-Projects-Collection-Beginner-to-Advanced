using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox3.Text)*0.20).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToInt32(textBox3.Text) * 0.15).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = (Convert.ToInt32(textBox3.Text) * 0.12).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Text = (Convert.ToInt32(textBox7.Text) * 0.10).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text= (Convert.ToInt32(textBox8.Text) +Convert.ToInt32(textBox9.Text)).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox11.Text =(Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox10.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
        
       
    }
}
