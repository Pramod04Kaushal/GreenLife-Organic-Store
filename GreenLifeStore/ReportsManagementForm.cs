using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GreenLifeStore
{
    public partial class ReportsManagementForm : Form
    {
        private string connStr;


        // CONSTRUCTOR
        public ReportsManagementForm()
        {
            InitializeComponent();
            connStr = ConfigurationManager
                        .ConnectionStrings["GreenLifeDB"]
                        .ConnectionString;
        }


        // FORM LOAD
        private void ReportsManagementForm_Load(object sender, EventArgs e)
        {
            LoadTotalSales();
            LoadTotalOrders();
            LoadTotalCustomers();
            LoadPendingOrders();
            LoadOrdersReport();
            LoadDashboardStats();
        }

        // TOTAL SALES
        private void LoadTotalSales()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(total_amount), 0) FROM Orders", con);

                con.Open();
                decimal totalSales = Convert.ToDecimal(cmd.ExecuteScalar());
                lblTotalSales.Text = "Rs. " + totalSales.ToString("N2");
            }
        }


        // TOTAL ORDERS
        private void LoadTotalOrders()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Orders", con);

                con.Open();
                lblTotalOrders.Text = cmd.ExecuteScalar().ToString();
            }
        }


        // TOTAL CUSTOMERS
        private void LoadTotalCustomers()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE role = 'Customer'", con);

                con.Open();
                lblTotalCustomers.Text = cmd.ExecuteScalar().ToString();
            }
        }


        // PENDING ORDERS
        private void LoadPendingOrders()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Orders WHERE order_status = 'Pending'", con);

                con.Open();
                lblPendingOrders.Text = cmd.ExecuteScalar().ToString();
            }
        }


        // LOAD ORDERS INTO REPORT GRID
        private void LoadOrdersReport()
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
                    ORDER BY order_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReports.DataSource = dt;
            }

            // Friendly column headers
            dgvReports.Columns["order_id"].HeaderText = "Order ID";
            dgvReports.Columns["order_date"].HeaderText = "Order Date";
            dgvReports.Columns["total_amount"].HeaderText = "Total Amount";
            dgvReports.Columns["order_status"].HeaderText = "Status";
        }

        // GENERATE REPORT (DATE FILTER)
        private void btnGenerate_Click(object sender, EventArgs e)
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
                    WHERE order_date BETWEEN @fromDate AND @toDate
                    ORDER BY order_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@toDate", dtpTo.Value.Date.AddDays(1));


                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReports.DataSource = dt;
            }
        }

        private void ReportsManagementForm_Load_1(object sender, EventArgs e)
        {

        }

        // Hover Effect
        private void btnExportCSV_MouseEnter(object sender, EventArgs e)
        {
            btnExportCSV.BackColor = Color.FromArgb(25, 118, 210);
        }

        private void btnExportCSV_MouseLeave(object sender, EventArgs e)
        {
            btnExportCSV.BackColor = Color.FromArgb(33, 150, 243);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "SalesReport.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString))
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
                WHERE o.order_date BETWEEN @From AND @To
                ORDER BY o.order_date DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@From", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@To", dtpTo.Value.Date.AddDays(1));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    using (System.IO.StreamWriter sw =
                           new System.IO.StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Order ID,Customer,Order Date,Total Amount,Status");

                        while (reader.Read())
                        {
                            sw.WriteLine(
                                reader["order_id"] + "," +
                                reader["customer"] + "," +
                                reader["order_date"] + "," +
                                reader["total_amount"] + "," +
                                reader["order_status"]
                            );
                        }
                    }
                }

                MessageBox.Show("CSV Exported Successfully!");
            }
        }

        private void LoadDashboardStats()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                // Total Products
                SqlCommand cmdProducts = new SqlCommand("SELECT COUNT(*) FROM Products", con);
                lblTotalProducts.Text = cmdProducts.ExecuteScalar().ToString();

                // Total Customers
                SqlCommand cmdCustomers = new SqlCommand("SELECT COUNT(*) FROM Users WHERE role='Customer'", con);
                lblTotalCustomers.Text = cmdCustomers.ExecuteScalar().ToString();

                // Total Orders
                SqlCommand cmdOrders = new SqlCommand("SELECT COUNT(*) FROM Orders", con);
                lblTotalOrders.Text = cmdOrders.ExecuteScalar().ToString();

                // Total Sales
                SqlCommand cmdSales = new SqlCommand("SELECT ISNULL(SUM(total_amount),0) FROM Orders", con);
                decimal totalSales = Convert.ToDecimal(cmdSales.ExecuteScalar());
                lblTotalSales.Text = "Rs. " + totalSales.ToString("N2");
            }
        }

    }
}
