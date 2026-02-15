using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeStore
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
    txtEmail.Text == "" ||
    txtPassword.Text == "" ||
    txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE email = @Email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                con.Open();
                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("Email already exists.");
                    return;
                }

                string insertQuery = @"
            INSERT INTO Users 
            (fullname, email, password, role, phone, address)
            VALUES (@Name, @Email, @Password, 'Customer', @Phone, @Address)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@Name", txtFullName.Text);
                insertCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                insertCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                insertCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                insertCmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registration successful!");

            new LoginForm().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
