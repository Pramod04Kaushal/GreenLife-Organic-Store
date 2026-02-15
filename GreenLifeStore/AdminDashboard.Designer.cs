namespace GreenLifeStore
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbldshbrdover = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVisits = new System.Windows.Forms.Label();
            this.lblVisitss = new System.Windows.Forms.Label();
            this.cardUsers = new System.Windows.Forms.Panel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.cardSales = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.cardOrders = new System.Windows.Forms.Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.timerLiveRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLowStock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cardUsers.SuspendLayout();
            this.cardSales.SuspendLayout();
            this.cardOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelSidebar.Controls.Add(this.panelActive);
            this.panelSidebar.Controls.Add(this.picLogo);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnCustomers);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 644);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.panelActive.Location = new System.Drawing.Point(-61, 84);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(5, 40);
            this.panelActive.TabIndex = 9;
            this.panelActive.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(60, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnLogout.Location = new System.Drawing.Point(12, 580);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 360);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(160, 40);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(12, 314);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(160, 40);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            this.btnOrders.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnOrders.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(12, 268);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(160, 40);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(12, 222);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(160, 40);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            this.btnProducts.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnProducts.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 176);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 40);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelHeader.Controls.Add(this.lbldshbrdover);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1161, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // lbldshbrdover
            // 
            this.lbldshbrdover.AutoSize = true;
            this.lbldshbrdover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldshbrdover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lbldshbrdover.Location = new System.Drawing.Point(150, 10);
            this.lbldshbrdover.Name = "lbldshbrdover";
            this.lbldshbrdover.Size = new System.Drawing.Size(252, 32);
            this.lbldshbrdover.TabIndex = 0;
            this.lbldshbrdover.Text = "Dashboard Overview";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelLowStock);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.cardUsers);
            this.panelMain.Controls.Add(this.cardSales);
            this.panelMain.Controls.Add(this.cardOrders);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1161, 589);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelLowStock
            // 
            this.panelLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLowStock.Controls.Add(this.lblLowStockCount);
            this.panelLowStock.Controls.Add(this.lblLowStock);
            this.panelLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.panelLowStock.Location = new System.Drawing.Point(926, 24);
            this.panelLowStock.Name = "panelLowStock";
            this.panelLowStock.Size = new System.Drawing.Size(200, 110);
            this.panelLowStock.TabIndex = 5;
            // 
            // lblLowStockCount
            // 
            this.lblLowStockCount.AutoSize = true;
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockCount.ForeColor = System.Drawing.Color.White;
            this.lblLowStockCount.Location = new System.Drawing.Point(15, 45);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(41, 48);
            this.lblLowStockCount.TabIndex = 1;
            this.lblLowStockCount.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lblLowStock.Location = new System.Drawing.Point(15, 15);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(92, 25);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblVisits);
            this.panel1.Controls.Add(this.lblVisitss);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.panel1.Location = new System.Drawing.Point(699, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 110);
            this.panel1.TabIndex = 4;
            // 
            // lblVisits
            // 
            this.lblVisits.AutoSize = true;
            this.lblVisits.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblVisits.Location = new System.Drawing.Point(15, 45);
            this.lblVisits.Name = "lblVisits";
            this.lblVisits.Size = new System.Drawing.Size(124, 48);
            this.lblVisits.TabIndex = 1;
            this.lblVisits.Text = "24.6%";
            // 
            // lblVisitss
            // 
            this.lblVisitss.AutoSize = true;
            this.lblVisitss.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lblVisitss.Location = new System.Drawing.Point(15, 15);
            this.lblVisitss.Name = "lblVisitss";
            this.lblVisitss.Size = new System.Drawing.Size(53, 25);
            this.lblVisitss.TabIndex = 0;
            this.lblVisitss.Text = "Visits";
            // 
            // cardUsers
            // 
            this.cardUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.cardUsers.Controls.Add(this.lblTotalCustomers);
            this.cardUsers.Controls.Add(this.lblCustomers);
            this.cardUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.cardUsers.Location = new System.Drawing.Point(479, 24);
            this.cardUsers.Name = "cardUsers";
            this.cardUsers.Size = new System.Drawing.Size(200, 110);
            this.cardUsers.TabIndex = 3;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalCustomers.Location = new System.Drawing.Point(15, 45);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(106, 48);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "189K";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lblCustomers.Location = new System.Drawing.Point(15, 15);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(97, 25);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "Customers";
            // 
            // cardSales
            // 
            this.cardSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.cardSales.Controls.Add(this.lblTotalSales);
            this.cardSales.Controls.Add(this.lblSales);
            this.cardSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.cardSales.Location = new System.Drawing.Point(259, 24);
            this.cardSales.Name = "cardSales";
            this.cardSales.Size = new System.Drawing.Size(200, 110);
            this.cardSales.TabIndex = 2;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalSales.Location = new System.Drawing.Point(15, 45);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(137, 48);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "$47.6K";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lblSales.Location = new System.Drawing.Point(15, 15);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(94, 25);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Total Sales";
            // 
            // cardOrders
            // 
            this.cardOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.cardOrders.Controls.Add(this.lblTotalOrders);
            this.cardOrders.Controls.Add(this.lblOrders);
            this.cardOrders.Location = new System.Drawing.Point(39, 24);
            this.cardOrders.Name = "cardOrders";
            this.cardOrders.Size = new System.Drawing.Size(200, 110);
            this.cardOrders.TabIndex = 0;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(99)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(15, 45);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(106, 48);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "248K";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.lblOrders.Location = new System.Drawing.Point(15, 15);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(108, 25);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "Total Orders";
            // 
            // timerLiveRefresh
            // 
            this.timerLiveRefresh.Interval = 5000;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1361, 644);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLowStock.ResumeLayout(false);
            this.panelLowStock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cardUsers.ResumeLayout(false);
            this.cardUsers.PerformLayout();
            this.cardSales.ResumeLayout(false);
            this.cardSales.PerformLayout();
            this.cardOrders.ResumeLayout(false);
            this.cardOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel cardOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisits;
        private System.Windows.Forms.Label lblVisitss;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Label lbldshbrdover;
        private System.Windows.Forms.Timer timerLiveRefresh;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.Label lblLowStock;
    }
}