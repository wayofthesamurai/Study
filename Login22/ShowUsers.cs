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
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }


        private void buttonShow_Click(object sender, EventArgs e)
        {
            string Connect = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "Users",
                IntegratedSecurity = true
            }.ConnectionString;

            SqlConnection conn = new SqlConnection(Connect);
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Userss", Connect);
                // Создаем объект Dataset
                DataTable ds = new DataTable();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Warning");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
