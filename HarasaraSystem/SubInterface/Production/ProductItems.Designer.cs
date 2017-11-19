namespace HarasaraSystem.SubInterface.Production
{
    partial class ProductItems
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
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gvUser = new System.Windows.Forms.DataGridView();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(90, 12);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(100, 20);
            this.txtPid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qty";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(90, 65);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(90, 112);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(100, 20);
            this.txtItemId.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(90, 152);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 20);
            this.txtqty.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gvUser
            // 
            this.gvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
            this.name,
            this.Qty,
            this.Add});
            this.gvUser.Location = new System.Drawing.Point(196, 12);
            this.gvUser.Name = "gvUser";
            this.gvUser.Size = new System.Drawing.Size(349, 341);
            this.gvUser.TabIndex = 9;
            this.gvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUser_CellContentClick);
            // 
            // item_id
            // 
            this.item_id.DataPropertyName = "item_id";
            this.item_id.HeaderText = "Item Id";
            this.item_id.Name = "item_id";
            this.item_id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Item Name";
            this.name.Name = "name";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(12, 202);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(121, 21);
            this.cmbItemName.TabIndex = 10;
            this.cmbItemName.TextChanged += new System.EventHandler(this.cmbItemName_TextChanged);
            // 
            // ProductItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 365);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.gvUser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPid);
            this.Name = "ProductItems";
            this.Text = "ProductItems";
            this.Load += new System.EventHandler(this.ProductItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.ComboBox cmbItemName;
    }
}