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

namespace StockControl_2
{
    public partial class CfrmRegister : Form
    {
        public CfrmRegister()
        {
            InitializeComponent();
        }

        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            CfrmLogin loginForm = new CfrmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void lblCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //CfrmRegister register = new CfrmRegister();
            //register.Show();
            //this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=young_laptop\\sqlexpress;Initial Catalog=loginForm;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string insertQuery = "INSERT INTO loginform VALUES (@username, @password)";
            SqlCommand command = new SqlCommand(insertQuery, conn);
            command.Parameters.AddWithValue("@username", txtUsername.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Register successfull","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
