using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Messenger
{
    public partial class Form1 : Form
    { 
        UdpClient client;
        const int LOCALPORT = 8001; // порт для приема сообщений
        const int REMOTEPORT = 8002; // порт для отправки сообщений
        const int TTL = 20;
        const string HOST = "109.86.51.222"; // хост для групповой рассылки
        IPAddress groupAddress; // адрес для групповой рассылки


        public Form1()
        {
            InitializeComponent();
            groupAddress = IPAddress.Parse(HOST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendMessenge_Click(object sender, EventArgs e)
        {
            try
            {
                string message = Nickname.Text + ": "  + textBoxMessege.Text;
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                textBoxMessege.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void GetMessege()
        {
            try
            {

                UdpClient receiver = new UdpClient(1024);
                IPEndPoint remoteIp = null;
                byte[] data = client.Receive(ref remoteIp);
                string message = Encoding.Unicode.GetString(data);

                // добавляем полученное сообщение в текстовое поле
                this.Invoke(new MethodInvoker(() =>
                {
                    string time = DateTime.Now.ToShortTimeString();
                    listBox2.Items.Add((time + " " + Nickname.Text + message).ToString());
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipaddress = IPAddress.Parse(textBox3.Text);   
                // присоединяемся к групповой рассылке
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);

                // запускаем задачу на прием сообщений
                Task receiveTask = new Task(GetMessege);
                receiveTask.Start();

                // отправляем первое сообщение о входе нового пользователя
                string message = Nickname.Text + " вошел в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                listBox2.Items.Add(message);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            string message = Nickname.Text + " покидает чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            client.Close();
        }
    }
}
