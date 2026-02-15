using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeStore
{
    public partial class CustomerProductViewForm : Form
    {
        private string connStr;
        private int loggedCustomerId;
        private int selectedProductId = 0;
        private decimal selectedPrice = 0;
        private decimal selectedProductPrice = 0;

        private List<ShoppingCartItem> cart = new List<ShoppingCartItem>();



        public CustomerProductViewForm(int customerId)
        {
            InitializeComponent();

            loggedCustomerId = customerId;
            connStr = ConfigurationManager
                        .ConnectionStrings["GreenLifeDB"]
                        .ConnectionString;
        }


        // LOAD PRODUCTS
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
        SELECT product_id, product_name, price, stockQuantity, category
        FROM Products
        WHERE is_active = 1";

                // Search filter
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query += " AND product_name LIKE @Search";
                }

                // Category filter
                if (cmbCategory.SelectedIndex > 0)
                {
                    query += " AND category = @Category";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                }

                if (cmbCategory.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.DataSource = dt;
            }

            dgvProducts.Columns["product_id"].Visible = false;
            dgvProducts.Columns["product_name"].HeaderText = "Product";
            dgvProducts.Columns["price"].HeaderText = "Price";
            dgvProducts.Columns["stockQuantity"].HeaderText = "Stock";
            dgvProducts.Columns["category"].HeaderText = "Category";
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT DISTINCT category FROM Products";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategory.Items.Add(reader["category"].ToString());
                }
            }

            cmbCategory.SelectedIndex = 0;
        }


        private void CustomerProductViewForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            LoadRatings();
        }

        //LOAD RATING OPTIONS
        private void LoadRatings()
        {
            cmbRating.Items.Clear();
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");
        }


        // PRODUCT SELECTION
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["product_id"].Value);
                selectedPrice = Convert.ToDecimal(row.Cells["price"].Value);

                lblProductName.Text = row.Cells["product_name"].Value.ToString();
                lblPrice.Text = "Rs. " + selectedPrice.ToString("N2");

                txtQuantity.Text = "1";
                CalculateTotal();
                LoadAverageRating();
            }
        }


        // TOTAL CALCULATION
        private void CalculateTotal()
        {
            if (decimal.TryParse(txtQuantity.Text, out decimal qty) && qty > 0)
            {
                decimal total = selectedPrice * qty;
                lblTotal.Text = "Rs. " + total.ToString("N2");
            }
            else
            {
                lblTotal.Text = "Rs. 0.00";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        // PLACE ORDER
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 🔹 1. Calculate Grand Total
                    decimal grandTotal = cart.Sum(x => x.TotalPrice);

                    // 🔹 2. Insert into Orders table
                    string orderQuery = @"
                INSERT INTO Orders (user_id, order_status, total_amount)
                VALUES (@UserId, 'Pending', @TotalAmount);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand orderCmd = new SqlCommand(orderQuery, con, transaction);
                    orderCmd.Parameters.AddWithValue("@UserId", loggedCustomerId);
                    orderCmd.Parameters.AddWithValue("@TotalAmount", grandTotal);

                    int newOrderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                    // 🔹 3. Insert each item into OrderItems
                    foreach (var item in cart)
                    {
                        string itemQuery = @"
                    INSERT INTO OrderItems (order_id, product_id, quantity, unit_price)
                    VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)";

                        SqlCommand itemCmd = new SqlCommand(itemQuery, con, transaction);
                        itemCmd.Parameters.AddWithValue("@OrderId", newOrderId);
                        itemCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        itemCmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);

                        itemCmd.ExecuteNonQuery();

                        // 🔹 4. Reduce stock
                        string stockQuery = @"
                    UPDATE Products
                    SET stockQuantity = stockQuantity - @Quantity
                    WHERE product_id = @ProductId";

                        SqlCommand stockCmd = new SqlCommand(stockQuery, con, transaction);
                        stockCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        stockCmd.Parameters.AddWithValue("@ProductId", item.ProductId);

                        stockCmd.ExecuteNonQuery();
                    }

                    // 🔹 5. Commit transaction
                    transaction.Commit();

                    MessageBox.Show("Order placed successfully!");

                    // 🔹 6. Clear cart
                    cart.Clear();
                    dgvCart.DataSource = null;
                    dgvCart.Refresh();

                    lblTotal.Text = "Rs. 0.00";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // BUTTON HOVER EFFECT
        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
            btnPlaceOrder.BackColor = Color.FromArgb(56, 142, 60);
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPlaceOrder.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            if (cmbRating.SelectedItem == null)
            {
                MessageBox.Show("Select a rating.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            INSERT INTO Reviews (user_id, product_id, rating, comment)
            VALUES (@UserId, @ProductId, @Rating, @Comment)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", loggedCustomerId);
                cmd.Parameters.AddWithValue("@ProductId", selectedProductId);
                cmd.Parameters.AddWithValue("@Rating", Convert.ToInt32(cmbRating.SelectedItem));
                cmd.Parameters.AddWithValue("@Comment", txtReviewComment.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Review submitted successfully!");

            cmbRating.SelectedIndex = -1;
            txtReviewComment.Clear();
        }

        private void LoadAverageRating()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
            SELECT ISNULL(AVG(CAST(rating AS FLOAT)), 0)
            FROM Reviews
            WHERE product_id = @ProductId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", selectedProductId);

                con.Open();
                double avg = Convert.ToDouble(cmd.ExecuteScalar());

                lblAverageRating.Text = "Average Rating: " + avg.ToString("0.0");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter valid quantity.");
                return;
            }

            // Check if product already exists in cart
            var existingItem = cart.FirstOrDefault(p => p.ProductId == selectedProductId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cart.Add(new ShoppingCartItem
                {
                    ProductId = selectedProductId,
                    ProductName = lblProductName.Text,
                    UnitPrice = selectedPrice,
                    Quantity = quantity
                });
            }

            MessageBox.Show("Product added to cart.");

            RefreshCartGrid();

        }

        //LOAD CART METHOD
        private void RefreshCartGrid()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart;
        }
    }
}
