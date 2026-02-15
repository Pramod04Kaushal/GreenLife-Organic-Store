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
using System.Configuration;




namespace GreenLifeStore
{
    public partial class AdminDashboard : Form
    {
        string connStr;

        public AdminDashboard()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ActivateMenu(btnDashboard);
            LoadDashboardStats();
            LoadLowStock();


            timerLiveRefresh.Interval = 5000; // 5 seconds
            timerLiveRefresh.Start();
        }

        private void timerLiveRefresh_Tick(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadLowStock();

        }


        private void LoadDashboardStats()
        {
            using (SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString))
            {
                con.Open();

                // 🔹 Total Sales
                SqlCommand cmdSales = new SqlCommand(
                    "SELECT ISNULL(SUM(total_amount),0) FROM Orders",
                    con);
                decimal totalSales = Convert.ToDecimal(cmdSales.ExecuteScalar());
                lblTotalSales.Text = "Rs. " + totalSales.ToString("N2");

                // 🔹 Products In Stock (total quantity, not just count)
                SqlCommand cmdStock = new SqlCommand(
                    "SELECT ISNULL(SUM(stockQuantity),0) FROM Products WHERE is_active = 1",
                    con);
                int totalStock = Convert.ToInt32(cmdStock.ExecuteScalar());
                lblLowStock.Text = totalStock.ToString();

                // 🔹 Active Orders (Pending + Shipped)
                SqlCommand cmdActiveOrders = new SqlCommand(
                    @"SELECT COUNT(*) 
              FROM Orders 
              WHERE order_status = 'Pending' 
              OR order_status = 'Shipped'",
                    con);
                int activeOrders = Convert.ToInt32(cmdActiveOrders.ExecuteScalar());
                lblTotalOrders.Text = activeOrders.ToString();
            }
        }

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateMenu(btnDashboard);
            LoadDashboardStats();
            // load dashboard content here
        }

        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(47, 125, 50); // Dark Green
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(21, 26, 33); // Sidebar bg
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivateMenu(Button btn)
        {
            // Move green indicator
            panelActive.Visible = true;
            panelActive.Top = btn.Top;
            panelActive.Height = btn.Height;

            // Reset all buttons
            foreach (Control c in panelSidebar.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(21, 26, 33); // sidebar bg
                    c.ForeColor = Color.White;
                }
            }

            // Highlight active button
            btn.BackColor = Color.FromArgb(47, 125, 50); // dark green
            btn.ForeColor = Color.White;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateMenu(btnProducts);

            ProductManagementForm frm = new ProductManagementForm();
            frm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateMenu(btnCustomers);

            CustomerManagementForm frm = new CustomerManagementForm();
            frm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateMenu(btnOrders);

            OrderManagementForm frm = new OrderManagementForm();
            frm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateMenu(btnReports);

            ReportsManagementForm frm = new ReportsManagementForm();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        //LOW STOCK

        private void LoadLowStock()
        {
            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString))
            {
                string query = @"
            SELECT COUNT(*)
            FROM Products
            WHERE stockQuantity <= 5 AND is_active = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lblLowStockCount.Text = count.ToString();

                if (count > 0)
                {
                    panelLowStock.BackColor = Color.FromArgb(183, 28, 28); // red
                }
                else
                {
                    panelLowStock.BackColor = Color.FromArgb(46, 125, 50); // green safe
                }
            }
        }

    }
}
