using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login22
{
    public partial class CreateUser : Form
    {

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string Connect = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "Users",
                IntegratedSecurity = true
            }.ConnectionString;

            Auth.InsertInTable(Connect,textBoxName.Text, textBoxSurName.Text, textBoxLogin.Text, textBoxPasswd.Text);
            Visible = false;
        }
    }

}


