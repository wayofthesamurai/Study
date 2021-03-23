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

namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string writePath = @"C:\Users\ADMIN\Downloads\Anketa_" + textBoxSurname.Text + ".txt";
            StreamWriter WriteFile = new StreamWriter(writePath, true, System.Text.Encoding.Default);
            WriteFile.WriteLine(textBoxName.Text);
            WriteFile.WriteLine(textBoxSurname.Text);
            WriteFile.WriteLine(textBoxAge.Text);
            WriteFile.WriteLine(textBoxSex.Text);
            WriteFile.WriteLine(textBoxAboutMe.Text);
            WriteFile.Close();
            Close();
        }
    }
}
