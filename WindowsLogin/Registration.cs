using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsLogin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kenne\Source\Repos\WindowsLogin\WindowsLogin\WLoginDatabase.mdf; Integrated Security = True; Connect Timeout = 30";
            string query = @"INSERT INTO WLoginData 
                                (Username, Password)
                            VALUES
                                (@username, @password)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@username", TextboxUserName.Text);
                    cmd.Parameters.AddWithValue("@password", TextboxPassword.Text);
                    int result = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Username is allready taken!");
                }

            }

        }
    }
}
