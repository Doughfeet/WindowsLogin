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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenne\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Table] where UserName = '" + TextboxUserName.Text + "' and Password = '" + TextboxPassword.Text + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);


            //Check if the is any match in the datatable
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();

                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password!");
            }


        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
