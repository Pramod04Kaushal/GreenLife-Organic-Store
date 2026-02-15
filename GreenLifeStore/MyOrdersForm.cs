using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GreenLifeStore
{
    public partial class MyOrdersForm : Form
    {
        private string connStr;
        private int loggedCustomerId;


        // CONSTRUCTOR
        public MyOrdersForm(int customerId)
        {
            InitializeComponent();

            loggedCustomerId = customerId;
            connStr = ConfigurationManager
                        .ConnectionStrings["GreenLifeDB"]
                        .ConnectionString;
        }


        // FORM LOAD
        private void MyOrdersForm_Load(object sender, EventArgs e)
        {
            LoadMyOrders();
        }


        // LOAD MY ORDERS INTO GRID
        private void LoadMyOrders()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT 
                        order_id,
                        order_date,
                        total_amount,
                        order_status
                    FROM Orders
                    WHERE user_id = @UserId
                    ORDER BY order_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@UserId", loggedCustomerId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMyOrders.DataSource = dt;
            }

            // Optional: nicer column headers
            dgvMyOrders.Columns["order_id"].HeaderText = "Order ID";
            dgvMyOrders.Columns["order_date"].HeaderText = "Order Date";
            dgvMyOrders.Columns["total_amount"].HeaderText = "Total Amount";
            dgvMyOrders.Columns["order_status"].HeaderText = "Status";
        }


        // WHEN USER CLICKS A ROW
        private void dgvMyOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMyOrders.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["order_id"].Value.ToString();
                txtOrderDate.Text = Convert
                                    .ToDateTime(row.Cells["order_date"].Value)
                                    .ToString("yyyy-MM-dd");

                txtTotalAmount.Text = row.Cells["total_amount"].Value.ToString();
                txtStatus.Text = row.Cells["order_status"].Value.ToString();
            }
        }


        // REFRESH BUTTON
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
        }


        // CLOSE BUTTON
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyOrdersForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
