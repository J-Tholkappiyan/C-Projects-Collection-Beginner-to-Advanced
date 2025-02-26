using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Smailid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("jtkappiyan2003@gmail.com", textBox1.Text);
            mail.Subject = "sample";
            mail.Body = textBox2.Text;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential()
            {
                UserName = "jtkappiyan2003@gmail.com",
                Password = "zurb bysm eroj bchv"
            };
            smtp.EnableSsl = true;
            //  smtp.Timeout = 400000;
            smtp.Send(mail);
            MessageBox.Show("Message has been sent successfully!");
        }
    }
}
