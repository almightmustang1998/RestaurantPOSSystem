namespace OrderingSystem
{
    partial class frmOrder
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
            this.grpModifyOrder = new System.Windows.Forms.GroupBox();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSelectOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.lblEntrees = new System.Windows.Forms.Label();
            this.lblAppetizers = new System.Windows.Forms.Label();
            this.picBeverage = new System.Windows.Forms.PictureBox();
            this.picDessert = new System.Windows.Forms.PictureBox();
            this.picEntree = new System.Windows.Forms.PictureBox();
            this.picAppetizer = new System.Windows.Forms.PictureBox();
            this.grpNewOrder = new System.Windows.Forms.GroupBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListView();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpModifyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).BeginInit();
            this.grpNewOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModifyOrder
            // 
            this.grpModifyOrder.Controls.Add(this.btnCancelChanges);
            this.grpModifyOrder.Controls.Add(this.btnSaveChanges);
            this.grpModifyOrder.Location = new System.Drawing.Point(182, 416);
            this.grpModifyOrder.Name = "grpModifyOrder";
            this.grpModifyOrder.Size = new System.Drawing.Size(314, 55);
            this.grpModifyOrder.TabIndex = 17;
            this.grpModifyOrder.TabStop = false;
            this.grpModifyOrder.Visible = false;
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(172, 19);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(120, 30);
            this.btnCancelChanges.TabIndex = 1;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(21, 19);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 30);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Order Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSelectOrder
            // 
            this.btnSelectOrder.Location = new System.Drawing.Point(255, 364);
            this.btnSelectOrder.Name = "btnSelectOrder";
            this.btnSelectOrder.Size = new System.Drawing.Size(156, 30);
            this.btnSelectOrder.TabIndex = 30;
            this.btnSelectOrder.Text = "Find Order To Modify";
            this.btnSelectOrder.UseVisualStyleBackColor = true;
            this.btnSelectOrder.Click += new System.EventHandler(this.btnSelectOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(532, 102);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveItem.TabIndex = 29;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(529, 154);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(55, 13);
            this.lblTable.TabIndex = 28;
            this.lblTable.Text = "Table #:";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(532, 170);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(52, 20);
            this.txtTable.TabIndex = 27;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(255, 322);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(156, 30);
            this.btnViewOrder.TabIndex = 26;
            this.btnViewOrder.Text = "View Current Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(532, 66);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 30);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverages.Location = new System.Drawing.Point(9, 364);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(67, 13);
            this.lblBeverages.TabIndex = 25;
            this.lblBeverages.Text = "Beverages";
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesserts.Location = new System.Drawing.Point(9, 259);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(56, 13);
            this.lblDesserts.TabIndex = 24;
            this.lblDesserts.Text = "Desserts";
            // 
            // lblEntrees
            // 
            this.lblEntrees.AutoSize = true;
            this.lblEntrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrees.Location = new System.Drawing.Point(12, 154);
            this.lblEntrees.Name = "lblEntrees";
            this.lblEntrees.Size = new System.Drawing.Size(50, 13);
            this.lblEntrees.TabIndex = 23;
            this.lblEntrees.Text = "Entrees";
            // 
            // lblAppetizers
            // 
            this.lblAppetizers.AutoSize = true;
            this.lblAppetizers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppetizers.Location = new System.Drawing.Point(12, 50);
            this.lblAppetizers.Name = "lblAppetizers";
            this.lblAppetizers.Size = new System.Drawing.Size(66, 13);
            this.lblAppetizers.TabIndex = 22;
            this.lblAppetizers.Text = "Appetizers";
            // 
            // picBeverage
            // 
            this.picBeverage.Image = global::OrderingSystem.Properties.Resources.drinks;
            this.picBeverage.Location = new System.Drawing.Point(12, 380);
            this.picBeverage.Name = "picBeverage";
            this.picBeverage.Size = new System.Drawing.Size(100, 79);
            this.picBeverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeverage.TabIndex = 21;
            this.picBeverage.TabStop = false;
            this.picBeverage.Click += new System.EventHandler(this.picBeverage_Click);
            // 
            // picDessert
            // 
            this.picDessert.Image = global::OrderingSystem.Properties.Resources.dessert;
            this.picDessert.Location = new System.Drawing.Point(12, 273);
            this.picDessert.Name = "picDessert";
            this.picDessert.Size = new System.Drawing.Size(100, 79);
            this.picDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDessert.TabIndex = 20;
            this.picDessert.TabStop = false;
            this.picDessert.Click += new System.EventHandler(this.picDessert_Click);
            // 
            // picEntree
            // 
            this.picEntree.Image = global::OrderingSystem.Properties.Resources.entree;
            this.picEntree.Location = new System.Drawing.Point(12, 170);
            this.picEntree.Name = "picEntree";
            this.picEntree.Size = new System.Drawing.Size(100, 79);
            this.picEntree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntree.TabIndex = 19;
            this.picEntree.TabStop = false;
            this.picEntree.Click += new System.EventHandler(this.picEntree_Click);
            // 
            // picAppetizer
            // 
            this.picAppetizer.Image = global::OrderingSystem.Properties.Resources.appetizer;
            this.picAppetizer.Location = new System.Drawing.Point(12, 66);
            this.picAppetizer.Name = "picAppetizer";
            this.picAppetizer.Size = new System.Drawing.Size(100, 79);
            this.picAppetizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppetizer.TabIndex = 16;
            this.picAppetizer.TabStop = false;
            this.picAppetizer.Click += new System.EventHandler(this.picAppetizer_Click);
            // 
            // grpNewOrder
            // 
            this.grpNewOrder.Controls.Add(this.btnCancelOrder);
            this.grpNewOrder.Controls.Add(this.btnSubmitOrder);
            this.grpNewOrder.Location = new System.Drawing.Point(182, 468);
            this.grpNewOrder.Name = "grpNewOrder";
            this.grpNewOrder.Size = new System.Drawing.Size(314, 55);
            this.grpNewOrder.TabIndex = 15;
            this.grpNewOrder.TabStop = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(172, 19);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(120, 30);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(21, 19);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(120, 30);
            this.btnSubmitOrder.TabIndex = 0;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescription,
            this.colPrice,
            this.colCategory});
            this.lstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenu.FullRowSelect = true;
            this.lstMenu.GridLines = true;
            this.lstMenu.HideSelection = false;
            this.lstMenu.Location = new System.Drawing.Point(139, 66);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(367, 249);
            this.lstMenu.TabIndex = 31;
            this.lstMenu.UseCompatibleStateImageBehavior = false;
            this.lstMenu.View = System.Windows.Forms.View.Details;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 266;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 97;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 530);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.grpModifyOrder);
            this.Controls.Add(this.btnSelectOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblBeverages);
            this.Controls.Add(this.lblDesserts);
            this.Controls.Add(this.lblEntrees);
            this.Controls.Add(this.lblAppetizers);
            this.Controls.Add(this.picBeverage);
            this.Controls.Add(this.picDessert);
            this.Controls.Add(this.picEntree);
            this.Controls.Add(this.picAppetizer);
            this.Controls.Add(this.grpNewOrder);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpModifyOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).EndInit();
            this.grpNewOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpModifyOrder;
        internal System.Windows.Forms.Button btnCancelChanges;
        internal System.Windows.Forms.Button btnSaveChanges;
        internal System.Windows.Forms.Button btnSelectOrder;
        internal System.Windows.Forms.Button btnRemoveItem;
        internal System.Windows.Forms.Label lblTable;
        internal System.Windows.Forms.TextBox txtTable;
        internal System.Windows.Forms.Button btnViewOrder;
        internal System.Windows.Forms.Button btnAddToOrder;
        internal System.Windows.Forms.Label lblBeverages;
        internal System.Windows.Forms.Label lblDesserts;
        internal System.Windows.Forms.Label lblEntrees;
        internal System.Windows.Forms.Label lblAppetizers;
        internal System.Windows.Forms.PictureBox picBeverage;
        internal System.Windows.Forms.PictureBox picDessert;
        internal System.Windows.Forms.PictureBox picEntree;
        internal System.Windows.Forms.PictureBox picAppetizer;
        internal System.Windows.Forms.GroupBox grpNewOrder;
        internal System.Windows.Forms.Button btnCancelOrder;
        internal System.Windows.Forms.Button btnSubmitOrder;
        internal System.Windows.Forms.ListView lstMenu;
        internal System.Windows.Forms.ColumnHeader colDescription;
        internal System.Windows.Forms.ColumnHeader colPrice;
        internal System.Windows.Forms.ColumnHeader colCategory;
    }
}