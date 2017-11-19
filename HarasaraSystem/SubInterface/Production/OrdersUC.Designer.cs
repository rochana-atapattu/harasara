namespace HarasaraSystem.SubInterface.Production
{
    partial class OrdersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersUC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton2 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton3 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton4 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton5 = new WindowsFormsControlLibrary1.BunifuThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.category,
            this.orderID,
            this.Quantity,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(202, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "View pending orders";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(12, 25);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton1.TabIndex = 1;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // bunifuThinButton2
            // 
            this.bunifuThinButton2.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton2.BackgroundImage")));
            this.bunifuThinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton2.ButtonText = "Check Availability";
            this.bunifuThinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton2.Iconimage = null;
            this.bunifuThinButton2.IconVisible = true;
            this.bunifuThinButton2.IconZoom = 90D;
            this.bunifuThinButton2.ImageIconOverlay = false;
            this.bunifuThinButton2.Location = new System.Drawing.Point(12, 191);
            this.bunifuThinButton2.Name = "bunifuThinButton2";
            this.bunifuThinButton2.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton2.TabIndex = 2;
            this.bunifuThinButton2.Click += new System.EventHandler(this.bunifuThinButton2_Click);
            // 
            // bunifuThinButton3
            // 
            this.bunifuThinButton3.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton3.BackgroundImage")));
            this.bunifuThinButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton3.ButtonText = "Add order";
            this.bunifuThinButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton3.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton3.Iconimage = null;
            this.bunifuThinButton3.IconVisible = true;
            this.bunifuThinButton3.IconZoom = 90D;
            this.bunifuThinButton3.ImageIconOverlay = false;
            this.bunifuThinButton3.Location = new System.Drawing.Point(12, 233);
            this.bunifuThinButton3.Name = "bunifuThinButton3";
            this.bunifuThinButton3.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton3.TabIndex = 3;
            this.bunifuThinButton3.Click += new System.EventHandler(this.bunifuThinButton3_Click);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product number";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.Width = 200;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.Width = 200;
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "orderID";
            this.orderID.HeaderText = "Order number";
            this.orderID.Name = "orderID";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Current Status";
            this.status.Name = "status";
            // 
            // bunifuThinButton4
            // 
            this.bunifuThinButton4.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton4.BackgroundImage")));
            this.bunifuThinButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton4.ButtonText = "View completed orders";
            this.bunifuThinButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton4.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton4.Iconimage = null;
            this.bunifuThinButton4.IconVisible = true;
            this.bunifuThinButton4.IconZoom = 90D;
            this.bunifuThinButton4.ImageIconOverlay = false;
            this.bunifuThinButton4.Location = new System.Drawing.Point(12, 67);
            this.bunifuThinButton4.Name = "bunifuThinButton4";
            this.bunifuThinButton4.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton4.TabIndex = 4;
            this.bunifuThinButton4.Click += new System.EventHandler(this.bunifuThinButton4_Click);
            // 
            // bunifuThinButton5
            // 
            this.bunifuThinButton5.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton5.BackgroundImage")));
            this.bunifuThinButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton5.ButtonText = "View all orders";
            this.bunifuThinButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton5.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton5.Iconimage = null;
            this.bunifuThinButton5.IconVisible = true;
            this.bunifuThinButton5.IconZoom = 90D;
            this.bunifuThinButton5.ImageIconOverlay = false;
            this.bunifuThinButton5.Location = new System.Drawing.Point(12, 109);
            this.bunifuThinButton5.Name = "bunifuThinButton5";
            this.bunifuThinButton5.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton5.TabIndex = 5;
            this.bunifuThinButton5.Click += new System.EventHandler(this.bunifuThinButton5_Click);
            // 
            // OrdersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.bunifuThinButton5);
            this.Controls.Add(this.bunifuThinButton4);
            this.Controls.Add(this.bunifuThinButton3);
            this.Controls.Add(this.bunifuThinButton2);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdersUC";
            this.Size = new System.Drawing.Size(1082, 616);
            this.Load += new System.EventHandler(this.OrdersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton2;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton4;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton5;
    }
}
