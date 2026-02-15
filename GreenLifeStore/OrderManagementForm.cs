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
    public partial class OrderManagementForm : Form
    {
        private string connStr;

        public OrderManagementForm()
        {
            InitializeComponent();

            connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadStatusDropdown();
        }

        private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
        SELECT 
            o.order_id,
            u.fullname AS customer,
            o.order_date,
            o.total_amount,
            o.order_status
        FROM Orders o
        INNER JOIN Users u ON o.user_id = u.user_id
        ORDER BY o.order_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }
        }

        private void LoadStatusDropdown()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Shipped");
            cmbStatus.Items.Add("Delivered");
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Select an order first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
        UPDATE Orders
        SET order_status = @Status
        WHERE order_id = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@OrderId", txtOrderID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order status updated.");
            LoadOrders();
        }

        private void btnUpdateStatus_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Select an order first.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Select a status.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
        UPDATE Orders
        SET order_status = @Status
        WHERE order_id = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderID.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order status updated successfully.");

            LoadOrders();
        }
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["order_id"].Value.ToString();
                txtCustomer.Text = row.Cells["customer"].Value.ToString();
                txtOrderDate.Text = Convert.ToDateTime(row.Cells["order_date"].Value)
                                        .ToString("yyyy-MM-dd");

                txtTotalAmount.Text = row.Cells["total_amount"].Value.ToString();

                cmbStatus.SelectedItem = row.Cells["order_status"].Value.ToString();
            }
        }


    }
}
