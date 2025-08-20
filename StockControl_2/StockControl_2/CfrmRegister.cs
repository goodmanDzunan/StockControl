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
        CfrmLogin loginForm = new CfrmLogin();
        public CfrmRegister()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            
            loginForm.Show();
            this.Hide();
        }

        private void lblCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=young_laptop\\sqlexpress;Initial Catalog=loginForm;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string insertQuery = "INSERT INTO loginform VALUES (@username, @password)";
            SqlCommand command = new SqlCommand(insertQuery, conn);
            command.Parameters.AddWithValue("@username", txtUsername.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Register successfull","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            this.Hide();
            loginForm.Show();
        }

        private void lblCloseRegister_MouseEnter(object sender, EventArgs e)
        {
            lblCloseRegister.ForeColor = Color.DarkRed;
            lblCloseRegister.BackColor = Color.CadetBlue;
        }

        private void lblCloseRegister_MouseLeave(object sender, EventArgs e)
        {
            lblCloseRegister.ForeColor = Color.Red;
            lblCloseRegister.BackColor = Color.Transparent;
        }

        private void chckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
