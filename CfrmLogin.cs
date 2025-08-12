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

namespace StockControl_2
{
    public partial class CfrmLogin : Form
    {
        public CfrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=young_laptop\\sqlexpress;Initial Catalog=loginForm;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            string query = "SELECT COUNT(*) FROM loginform WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();

            if (count > 0)
            {
                CfrmStockControl stockControl = new CfrmStockControl();
                stockControl.Show();
                this.Hide();
                //.Show("Login Successfull.", "LOGIN SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CfrmRegister registerForm = new CfrmRegister();
            registerForm.Show();
            this.Hide();
        }

        private void lblCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
