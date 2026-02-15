using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GreenLifeStore
{
    public partial class ProductManagementForm : Form
    {
        private string connStr;

        public ProductManagementForm()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["GreenLifeDB"].ConnectionString;
        }


        // LOAD PRODUCTS INTO GRID
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT 
                        product_id,
                        product_name,
                        category,
                        price,
                        stockQuantity,
                        supplier
                    FROM Products
                    WHERE is_active = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.DataSource = dt;
            }
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }


        // ADD PRODUCT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
                    INSERT INTO Products
                    (product_name, category, price, stockQuantity, supplier)
                    VALUES
                    (@name, @category, @price, @stock, @supplier)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product added successfully");
            LoadProducts();
            ClearFields();
        }


        // SELECT ROW FROM GRID
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductName.Text = row.Cells["product_name"].Value.ToString();
                txtCategory.Text = row.Cells["category"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                txtStock.Text = row.Cells["stockQuantity"].Value.ToString();
                txtSupplier.Text = row.Cells["supplier"].Value.ToString();
            }
        }

        // UPDATE PRODUCT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["product_id"].Value
            );

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
                    UPDATE Products
                    SET product_name = @name,
                        category = @category,
                        price = @price,
                        stockQuantity = @stock,
                        supplier = @supplier
                    WHERE product_id = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@id", productId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated successfully");
            LoadProducts();
            ClearFields();
        }

        // DELETE PRODUCT (SOFT DELETE)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["product_id"].Value
            );

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"
                    UPDATE Products
                    SET is_active = 0
                    WHERE product_id = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", productId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product deleted successfully");
            LoadProducts();
            ClearFields();
        }

        // CLEAR INPUT FIELDS
        private void ClearFields()
        {
            txtProductName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtSupplier.Clear();
        }
    }
}
