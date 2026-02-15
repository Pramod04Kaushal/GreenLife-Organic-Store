namespace GreenLifeStore
{
    partial class ReportsManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.panelTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsValue = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.panelTotalCustomers = new System.Windows.Forms.Panel();
            this.lblTotalCustomersValue = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.panelTotalOrders = new System.Windows.Forms.Panel();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.panelTotalSales = new System.Windows.Forms.Panel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.panelTotalProducts.SuspendLayout();
            this.panelTotalCustomers.SuspendLayout();
            this.panelTotalOrders.SuspendLayout();
            this.panelTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsTitle.ForeColor = System.Drawing.Color.White;
            this.lblReportsTitle.Location = new System.Drawing.Point(30, 20);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(339, 48);
            this.lblReportsTitle.TabIndex = 0;
            this.lblReportsTitle.Text = "Reports / Analytics";
            // 
            // panelTotalProducts
            // 
            this.panelTotalProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalProducts.Controls.Add(this.lblTotalProductsValue);
            this.panelTotalProducts.Controls.Add(this.lblTotalProducts);
            this.panelTotalProducts.Location = new System.Drawing.Point(38, 71);
            this.panelTotalProducts.Name = "panelTotalProducts";
            this.panelTotalProducts.Size = new System.Drawing.Size(200, 110);
            this.panelTotalProducts.TabIndex = 1;
            // 
            // lblTotalProductsValue
            // 
            this.lblTotalProductsValue.AutoSize = true;
            this.lblTotalProductsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalProductsValue.Location = new System.Drawing.Point(15, 45);
            this.lblTotalProductsValue.Name = "lblTotalProductsValue";
            this.lblTotalProductsValue.Size = new System.Drawing.Size(46, 54);
            this.lblTotalProductsValue.TabIndex = 1;
            this.lblTotalProductsValue.Text = "0";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalProducts.Location = new System.Drawing.Point(15, 15);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(136, 28);
            this.lblTotalProducts.TabIndex = 0;
            this.lblTotalProducts.Text = "Total Products";
            // 
            // panelTotalCustomers
            // 
            this.panelTotalCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalCustomers.Controls.Add(this.lblTotalCustomersValue);
            this.panelTotalCustomers.Controls.Add(this.lblTotalCustomers);
            this.panelTotalCustomers.Location = new System.Drawing.Point(250, 70);
            this.panelTotalCustomers.Name = "panelTotalCustomers";
            this.panelTotalCustomers.Size = new System.Drawing.Size(200, 110);
            this.panelTotalCustomers.TabIndex = 2;
            // 
            // lblTotalCustomersValue
            // 
            this.lblTotalCustomersValue.AutoSize = true;
            this.lblTotalCustomersValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalCustomersValue.Location = new System.Drawing.Point(15, 45);
            this.lblTotalCustomersValue.Name = "lblTotalCustomersValue";
            this.lblTotalCustomersValue.Size = new System.Drawing.Size(46, 54);
            this.lblTotalCustomersValue.TabIndex = 1;
            this.lblTotalCustomersValue.Text = "0";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalCustomers.Location = new System.Drawing.Point(15, 15);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(151, 28);
            this.lblTotalCustomers.TabIndex = 0;
            this.lblTotalCustomers.Text = "Total Customers";
            // 
            // panelTotalOrders
            // 
            this.panelTotalOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalOrders.Controls.Add(this.lblPendingOrders);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrders);
            this.panelTotalOrders.Location = new System.Drawing.Point(470, 70);
            this.panelTotalOrders.Name = "panelTotalOrders";
            this.panelTotalOrders.Size = new System.Drawing.Size(200, 110);
            this.panelTotalOrders.TabIndex = 3;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblPendingOrders.Location = new System.Drawing.Point(15, 45);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(46, 54);
            this.lblPendingOrders.TabIndex = 1;
            this.lblPendingOrders.Text = "0";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(15, 15);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(118, 28);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // panelTotalSales
            // 
            this.panelTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalSales.Controls.Add(this.lblTotalSalesValue);
            this.panelTotalSales.Controls.Add(this.lblTotalSales);
            this.panelTotalSales.Location = new System.Drawing.Point(690, 70);
            this.panelTotalSales.Name = "panelTotalSales";
            this.panelTotalSales.Size = new System.Drawing.Size(200, 110);
            this.panelTotalSales.TabIndex = 4;
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalSalesValue.Location = new System.Drawing.Point(15, 45);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.Size = new System.Drawing.Size(126, 54);
            this.lblTotalSalesValue.TabIndex = 1;
            this.lblTotalSalesValue.Text = "$0.00";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalSales.Location = new System.Drawing.Point(15, 15);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(103, 28);
            this.lblTotalSales.TabIndex = 0;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvReports.Location = new System.Drawing.Point(30, 220);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(900, 400);
            this.dgvReports.TabIndex = 5;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelFilters.Controls.Add(this.btnExportCSV);
            this.panelFilters.Controls.Add(this.btnGenerateReport);
            this.panelFilters.Controls.Add(this.dtpTo);
            this.panelFilters.Controls.Add(this.lblToDate);
            this.panelFilters.Controls.Add(this.dtpFrom);
            this.panelFilters.Controls.Add(this.lblFromDate);
            this.panelFilters.Controls.Add(this.lblFilterTitle);
            this.panelFilters.Location = new System.Drawing.Point(956, 220);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(210, 400);
            this.panelFilters.TabIndex = 6;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Location = new System.Drawing.Point(24, 254);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(162, 35);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(24, 194);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(160, 40);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(26, 150);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(160, 26);
            this.dtpTo.TabIndex = 4;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblToDate.Location = new System.Drawing.Point(22, 127);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(66, 20);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(24, 78);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(160, 26);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFromDate.Location = new System.Drawing.Point(20, 55);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(85, 20);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "From Date";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilterTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(83, 32);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filters";
            // 
            // ReportsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.panelTotalSales);
            this.Controls.Add(this.panelTotalOrders);
            this.Controls.Add(this.panelTotalCustomers);
            this.Controls.Add(this.panelTotalProducts);
            this.Controls.Add(this.lblReportsTitle);
            this.Name = "ReportsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsManagementForm_Load_1);
            this.panelTotalProducts.ResumeLayout(false);
            this.panelTotalProducts.PerformLayout();
            this.panelTotalCustomers.ResumeLayout(false);
            this.panelTotalCustomers.PerformLayout();
            this.panelTotalOrders.ResumeLayout(false);
            this.panelTotalOrders.PerformLayout();
            this.panelTotalSales.ResumeLayout(false);
            this.panelTotalSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Panel panelTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsValue;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Panel panelTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersValue;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Panel panelTotalOrders;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Panel panelTotalSales;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnExportCSV;
    }
}