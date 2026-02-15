namespace GreenLifeStore
{
    partial class MyOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelOrdersList = new System.Windows.Forms.Panel();
            this.dgvMyOrders = new System.Windows.Forms.DataGridView();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.panelOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).BeginInit();
            this.panelOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Orders";
            // 
            // panelOrdersList
            // 
            this.panelOrdersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.panelOrdersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrdersList.Controls.Add(this.dgvMyOrders);
            this.panelOrdersList.Location = new System.Drawing.Point(39, 92);
            this.panelOrdersList.Name = "panelOrdersList";
            this.panelOrdersList.Size = new System.Drawing.Size(650, 520);
            this.panelOrdersList.TabIndex = 1;
            // 
            // dgvMyOrders
            // 
            this.dgvMyOrders.AllowUserToAddRows = false;
            this.dgvMyOrders.AllowUserToDeleteRows = false;
            this.dgvMyOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvMyOrders.Name = "dgvMyOrders";
            this.dgvMyOrders.ReadOnly = true;
            this.dgvMyOrders.RowHeadersVisible = false;
            this.dgvMyOrders.RowHeadersWidth = 62;
            this.dgvMyOrders.RowTemplate.Height = 28;
            this.dgvMyOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyOrders.Size = new System.Drawing.Size(648, 518);
            this.dgvMyOrders.TabIndex = 0;
            this.dgvMyOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyOrders_CellClick);
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.panelOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrderDetails.Controls.Add(this.btnClose);
            this.panelOrderDetails.Controls.Add(this.btnRefresh);
            this.panelOrderDetails.Controls.Add(this.txtStatus);
            this.panelOrderDetails.Controls.Add(this.lblStatus);
            this.panelOrderDetails.Controls.Add(this.txtTotalAmount);
            this.panelOrderDetails.Controls.Add(this.lblTotal);
            this.panelOrderDetails.Controls.Add(this.txtOrderDate);
            this.panelOrderDetails.Controls.Add(this.lblOrderDate);
            this.panelOrderDetails.Controls.Add(this.txtOrderID);
            this.panelOrderDetails.Controls.Add(this.lblOrderId);
            this.panelOrderDetails.Location = new System.Drawing.Point(710, 92);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(330, 520);
            this.panelOrderDetails.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(24, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(260, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(24, 348);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(260, 40);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh Orders";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.Location = new System.Drawing.Point(24, 290);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(260, 26);
            this.txtStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 256);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalAmount.Location = new System.Drawing.Point(24, 209);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(260, 26);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 175);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderDate.Location = new System.Drawing.Point(24, 130);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(260, 26);
            this.txtOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblOrderDate.Location = new System.Drawing.Point(20, 96);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(88, 20);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderID.Location = new System.Drawing.Point(24, 54);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(260, 26);
            this.txtOrderID.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblOrderId.Location = new System.Drawing.Point(20, 20);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(70, 20);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID";
            // 
            // MyOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1078, 726);
            this.Controls.Add(this.panelOrderDetails);
            this.Controls.Add(this.panelOrdersList);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Orders";
            this.Load += new System.EventHandler(this.MyOrdersForm_Load);
            this.panelOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).EndInit();
            this.panelOrderDetails.ResumeLayout(false);
            this.panelOrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelOrdersList;
        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMyOrders;
    }
}