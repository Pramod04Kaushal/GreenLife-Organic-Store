using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace GreenLifeStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please Enter email and Password");
                return;

            }

            string connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT user_id, role FROM Users WHERE email=@email AND password=@password";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();

                    MessageBox.Show("Login Successful");

                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else
                    {
                        int customerId = Convert.ToInt32(reader["user_id"]);
                        CustomerDashboard customer = new CustomerDashboard(customerId);
                        customer.Show();

                        customer.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials");
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                lblMessage.Text = "Please enter email and password";
                lblMessage.Visible = true;
                return;
            }

            string connStr = ConfigurationManager
                .ConnectionStrings["GreenLifeDB"]
                .ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            SELECT user_id, role 
            FROM Users 
            WHERE email = @email AND password = @password
            AND is_active = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["user_id"]);
                    string role = reader["role"].ToString();

                    this.Hide();

                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else
                    {
                        CustomerDashboard customer = new CustomerDashboard(userId);
                        customer.Show();
                    }
                }
                else
                {
                    lblMessage.Text = "Invalid email or password";
                    lblMessage.Visible = true;
                }
            }
        }


        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }
    }
}


