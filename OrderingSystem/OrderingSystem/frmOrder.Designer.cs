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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.btnViewCurrentOrder = new System.Windows.Forms.Button();
            this.btnAddCurrentOrder = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxFrmOrder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).BeginInit();
            this.grpNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrmOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(456, 560);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(234, 46);
            this.btnRemoveItem.TabIndex = 29;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(860, 495);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(287, 20);
            this.lblTable.TabIndex = 28;
            this.lblTable.Text = "Table #(Leave blank for takeout):";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(959, 520);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(76, 26);
            this.txtTable.TabIndex = 27;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(594, 495);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(234, 46);
            this.btnViewOrder.TabIndex = 26;
            this.btnViewOrder.Text = "View Current Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(339, 495);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(234, 46);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverages.Location = new System.Drawing.Point(14, 560);
            this.lblBeverages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(98, 20);
            this.lblBeverages.TabIndex = 25;
            this.lblBeverages.Text = "Beverages";
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesserts.Location = new System.Drawing.Point(14, 398);
            this.lblDesserts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(86, 20);
            this.lblDesserts.TabIndex = 24;
            this.lblDesserts.Text = "Desserts";
            // 
            // lblEntrees
            // 
            this.lblEntrees.AutoSize = true;
            this.lblEntrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrees.Location = new System.Drawing.Point(18, 237);
            this.lblEntrees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrees.Name = "lblEntrees";
            this.lblEntrees.Size = new System.Drawing.Size(74, 20);
            this.lblEntrees.TabIndex = 23;
            this.lblEntrees.Text = "Entrees";
            // 
            // lblAppetizers
            // 
            this.lblAppetizers.AutoSize = true;
            this.lblAppetizers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppetizers.Location = new System.Drawing.Point(18, 77);
            this.lblAppetizers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppetizers.Name = "lblAppetizers";
            this.lblAppetizers.Size = new System.Drawing.Size(99, 20);
            this.lblAppetizers.TabIndex = 22;
            this.lblAppetizers.Text = "Appetizers";
            // 
            // picBeverage
            // 
            this.picBeverage.Image = global::OrderingSystem.Properties.Resources.drinks;
            this.picBeverage.Location = new System.Drawing.Point(18, 585);
            this.picBeverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBeverage.Name = "picBeverage";
            this.picBeverage.Size = new System.Drawing.Size(150, 122);
            this.picBeverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeverage.TabIndex = 21;
            this.picBeverage.TabStop = false;
            this.picBeverage.Click += new System.EventHandler(this.picBeverage_Click);
            // 
            // picDessert
            // 
            this.picDessert.Image = global::OrderingSystem.Properties.Resources.dessert;
            this.picDessert.Location = new System.Drawing.Point(18, 420);
            this.picDessert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDessert.Name = "picDessert";
            this.picDessert.Size = new System.Drawing.Size(150, 122);
            this.picDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDessert.TabIndex = 20;
            this.picDessert.TabStop = false;
            this.picDessert.Click += new System.EventHandler(this.picDessert_Click);
            // 
            // picEntree
            // 
            this.picEntree.Image = global::OrderingSystem.Properties.Resources.entree;
            this.picEntree.Location = new System.Drawing.Point(18, 262);
            this.picEntree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEntree.Name = "picEntree";
            this.picEntree.Size = new System.Drawing.Size(150, 122);
            this.picEntree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntree.TabIndex = 19;
            this.picEntree.TabStop = false;
            this.picEntree.Click += new System.EventHandler(this.picEntree_Click);
            // 
            // picAppetizer
            // 
            this.picAppetizer.Image = global::OrderingSystem.Properties.Resources.appetizer;
            this.picAppetizer.Location = new System.Drawing.Point(18, 102);
            this.picAppetizer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAppetizer.Name = "picAppetizer";
            this.picAppetizer.Size = new System.Drawing.Size(150, 122);
            this.picAppetizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppetizer.TabIndex = 16;
            this.picAppetizer.TabStop = false;
            this.picAppetizer.Click += new System.EventHandler(this.picAppetizer_Click);
            // 
            // grpNewOrder
            // 
            this.grpNewOrder.Controls.Add(this.btnCancelOrder);
            this.grpNewOrder.Controls.Add(this.btnSubmitOrder);
            this.grpNewOrder.Location = new System.Drawing.Point(339, 622);
            this.grpNewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNewOrder.Name = "grpNewOrder";
            this.grpNewOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNewOrder.Size = new System.Drawing.Size(471, 85);
            this.grpNewOrder.TabIndex = 15;
            this.grpNewOrder.TabStop = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(258, 29);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(180, 46);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(32, 29);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(180, 46);
            this.btnSubmitOrder.TabIndex = 0;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(224, 77);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.Size = new System.Drawing.Size(712, 391);
            this.dgvMenu.TabIndex = 31;
            this.dgvMenu.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMenu_RowHeaderMouseClick);
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(224, 77);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.RowHeadersWidth = 62;
            this.dgvCurrentOrder.RowTemplate.Height = 28;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(712, 391);
            this.dgvCurrentOrder.TabIndex = 32;
            this.dgvCurrentOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCurrentOrder_RowHeaderMouseClick);
            // 
            // btnViewCurrentOrder
            // 
            this.btnViewCurrentOrder.Location = new System.Drawing.Point(339, 560);
            this.btnViewCurrentOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewCurrentOrder.Name = "btnViewCurrentOrder";
            this.btnViewCurrentOrder.Size = new System.Drawing.Size(234, 46);
            this.btnViewCurrentOrder.TabIndex = 33;
            this.btnViewCurrentOrder.Text = "View Order";
            this.btnViewCurrentOrder.UseVisualStyleBackColor = true;
            this.btnViewCurrentOrder.Click += new System.EventHandler(this.btnViewCurrentOrder_Click);
            // 
            // btnAddCurrentOrder
            // 
            this.btnAddCurrentOrder.Location = new System.Drawing.Point(339, 495);
            this.btnAddCurrentOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCurrentOrder.Name = "btnAddCurrentOrder";
            this.btnAddCurrentOrder.Size = new System.Drawing.Size(234, 46);
            this.btnAddCurrentOrder.TabIndex = 34;
            this.btnAddCurrentOrder.Text = "Add To Current Order";
            this.btnAddCurrentOrder.UseVisualStyleBackColor = true;
            this.btnAddCurrentOrder.Click += new System.EventHandler(this.btnAddCurrentOrder_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(594, 495);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(234, 46);
            this.btnSaveChanges.TabIndex = 35;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 560);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(234, 46);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBoxFrmOrder
            // 
            this.pictureBoxFrmOrder.Location = new System.Drawing.Point(980, 102);
            this.pictureBoxFrmOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxFrmOrder.Name = "pictureBoxFrmOrder";
            this.pictureBoxFrmOrder.Size = new System.Drawing.Size(508, 317);
            this.pictureBoxFrmOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrmOrder.TabIndex = 37;
            this.pictureBoxFrmOrder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1506, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFrmOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddCurrentOrder);
            this.Controls.Add(this.btnViewCurrentOrder);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.dgvMenu);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).EndInit();
            this.grpNewOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrmOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        internal System.Windows.Forms.Button btnViewCurrentOrder;
        internal System.Windows.Forms.Button btnAddCurrentOrder;
        internal System.Windows.Forms.Button btnSaveChanges;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxFrmOrder;
        private System.Windows.Forms.Label label1;
    }
}