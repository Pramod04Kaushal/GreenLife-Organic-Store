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
    public partial class CustomerDashboard : Form
    {
        private string connStr;

        private int loggedCustomerId;
        public CustomerDashboard(int customerId)
        {
            InitializeComponent();
            loggedCustomerId = customerId;
            connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadMyOrdersCount();
            LoadTotalSpent();
        }

        private void LoadMyOrdersCount()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM Orders WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", loggedCustomerId);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lblMyOrdersCount.Text = count.ToString();
            }
        }

        private void LoadTotalSpent()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            SELECT ISNULL(SUM(total_amount), 0)
            FROM Orders
            WHERE user_id = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", loggedCustomerId);

                con.Open();
                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

                lblTotalSpent.Text = "$" + total.ToString("N2");
            }
        }





        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            MyOrdersForm frm = new MyOrdersForm(loggedCustomerId);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            CustomerProductViewForm frm = new CustomerProductViewForm(loggedCustomerId);
            frm.Show();
        }
    }
}
