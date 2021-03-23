using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            OpenFileDialog open = new OpenFileDialog();  // создали экземпляр установим фильтр для файлов

            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;// по умолчанию фильтруются текстовые файлы

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();  // считываем файл до конца
                progressBar1.Maximum = 100;
                while(progressBar1.Value!=progressBar1.Maximum)
                progressBar1.Value+=1;
                reader.Close(); // закрываем reader
            }
        } 
    }
}
