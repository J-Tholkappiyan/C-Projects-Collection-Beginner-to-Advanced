using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                foreach (var item in comboBox2.Items)
                {
                    comboBox1.Items.Add(item);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) return;

            comboBox1.Items.Add(comboBox2.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBox1.Items)
            {
                comboBox2.Items.Add(item);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!comboBox2.Items.Contains(textBox1.Text))
            {
                comboBox2.Items.Add(textBox1.Text);
                MessageBox.Show(textBox1.Text + " is added to new list");
            }
            else { MessageBox.Show("Item already exist"); }
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
         {
               comboBox2.Items.Remove(comboBox2.SelectedItem);
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

          

    }
}
