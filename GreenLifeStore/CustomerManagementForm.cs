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
    public partial class CustomerManagementForm : Form
    {
        private string connStr;

        public CustomerManagementForm()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;
        }

        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            SELECT user_id, fullname, email, phone, address
            FROM Users
            WHERE role = 'Customer'";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCustomers.DataSource = dt;
            }

            dgvCustomers.Columns["user_id"].Visible = false;
        }


        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            int userId = Convert.ToInt32(
                dgvCustomers.CurrentRow.Cells["user_id"].Value);

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            UPDATE Users
            SET fullname = @FullName,
                email = @Email,
                phone = @Phone,
                address = @Address
            WHERE user_id = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@UserId", userId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer updated successfully.");

            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            int userId = Convert.ToInt32(
                dgvCustomers.CurrentRow.Cells["user_id"].Value);

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            UPDATE Users
            SET is_active = 0
            WHERE user_id = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer deactivated.");

            LoadCustomers();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelCustomerForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtFullName.Text = row.Cells["fullname"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }
    }
}
