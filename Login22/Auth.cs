
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;


namespace Login22
{
    class Auth
    {

        public static void InsertInTable(string Connect,string textBoxName, string textBoxSurName, string textBoxLogin, string textBoxPasswd)
        {
            
            SqlConnection conn = new SqlConnection(Connect);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Error");
            }

            using (SqlCommand cmd = new SqlCommand("AddUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;   
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxName;
                    cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = textBoxSurName;
                    cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = textBoxLogin;
                    cmd.Parameters.Add("@Passwd", SqlDbType.NVarChar).Value = textBoxPasswd;
                
                    if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Add.ADD");
                    else
                    MessageBox.Show("Add.NO");
                }

            conn.Close();
        }

        public static bool CheckLogin(string login, string password)
        {
            return login == "admin" && password == "admin";
        }
    }
}