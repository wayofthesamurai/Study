using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login22
{
    
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                
                LoginForm lf = new LoginForm();
                if (lf.ShowDialog(this) != DialogResult.OK)
                {
                    MessageBox.Show("Good by!!!");
                    Close();
                    return;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser create = new CreateUser();
            create.ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowUsers Show = new ShowUsers();
            Show.ShowDialog();
        }
    }
    
}
