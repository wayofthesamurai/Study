using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Spam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "" || textBoxPswd.Text == "" || textBoxName.Text == "" || textBoxTo.Text == "" || textBoxMessage.Text == "" || textBoxTheme.Text == "" || textBoxNumber.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential(textBoxMail.Text, textBoxPswd.Text);
                client.EnableSsl = true;

                MailMessage msg = new MailMessage()
                {
                    From = new MailAddress(textBoxMail.Text, textBoxName.Text),
                    Subject = textBoxTheme.Text,
                    IsBodyHtml = true
                };
                msg.To.Add(new MailAddress(textBoxTo.Text));

                int num = Convert.ToInt32(textBoxNumber.Text);


                while (num > 0)
                {
                    msg.Body = ("<html><head><title> not spam </title></head><body><h1>" + textBoxMessage.Text + "</h1></body></html>");
                    client.Send(msg);
                    num--;
                }
                MessageBox.Show("Отправлено!");
                textBoxMail.Text = " ";
                textBoxPswd.Text = " ";
                textBoxName.Text = " ";
                textBoxTo.Text = " ";
                textBoxMessage.Text = " ";
                textBoxTheme.Text = " ";
                textBoxNumber.Text = " ";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
