namespace OrderingSystem
{
    partial class frmViewOrders
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
            this.btnViewBill = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvViewOrders = new System.Windows.Forms.DataGridView();
            this.btnOrderComplete = new System.Windows.Forms.Button();
            this.btnViewOrderProgress = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(284, 465);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(180, 53);
            this.btnViewBill.TabIndex = 17;
            this.btnViewBill.Text = "View Bill";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(46, 465);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(180, 53);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Close";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(501, 465);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvViewOrders
            // 
            this.dgvViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvViewOrders.ColumnHeadersHeight = 34;
            this.dgvViewOrders.Location = new System.Drawing.Point(13, 55);
            this.dgvViewOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewOrders.MultiSelect = false;
            this.dgvViewOrders.Name = "dgvViewOrders";
            this.dgvViewOrders.ReadOnly = true;
            this.dgvViewOrders.RowHeadersWidth = 62;
            this.dgvViewOrders.Size = new System.Drawing.Size(1072, 378);
            this.dgvViewOrders.TabIndex = 18;
            this.dgvViewOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewOrders_RowHeaderMouseClick);
            // 
            // btnOrderComplete
            // 
            this.btnOrderComplete.Location = new System.Drawing.Point(284, 539);
            this.btnOrderComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderComplete.Name = "btnOrderComplete";
            this.btnOrderComplete.Size = new System.Drawing.Size(180, 49);
            this.btnOrderComplete.TabIndex = 19;
            this.btnOrderComplete.Text = "Order Complete";
            this.btnOrderComplete.UseVisualStyleBackColor = true;
            this.btnOrderComplete.Click += new System.EventHandler(this.btnOrderComplete_Click);
            // 
            // btnViewOrderProgress
            // 
            this.btnViewOrderProgress.Location = new System.Drawing.Point(46, 539);
            this.btnViewOrderProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrderProgress.Name = "btnViewOrderProgress";
            this.btnViewOrderProgress.Size = new System.Drawing.Size(180, 49);
            this.btnViewOrderProgress.TabIndex = 20;
            this.btnViewOrderProgress.Text = "View Item Progress";
            this.btnViewOrderProgress.UseVisualStyleBackColor = true;
            this.btnViewOrderProgress.Click += new System.EventHandler(this.btnViewOrderProgress_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(728, 465);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(180, 53);
            this.btnSwitch.TabIndex = 21;
            this.btnSwitch.Text = "Switch View (Kitchen/Server)";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchen.Location = new System.Drawing.Point(390, 9);
            this.lblKitchen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(201, 37);
            this.lblKitchen.TabIndex = 22;
            this.lblKitchen.Text = "Kitchen View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Table number 0 is takeout";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(501, 539);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 49);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove items from order";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(728, 539);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(180, 49);
            this.btnAddItems.TabIndex = 25;
            this.btnAddItems.Text = "Add items to order";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(929, 492);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(156, 65);
            this.btnPriority.TabIndex = 26;
            this.btnPriority.Text = "Make Order a Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 602);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKitchen);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnViewOrderProgress);
            this.Controls.Add(this.btnOrderComplete);
            this.Controls.Add(this.dgvViewOrders);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewOrders";
            this.Load += new System.EventHandler(this.frmViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnViewBill;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvViewOrders;
        internal System.Windows.Forms.Button btnOrderComplete;
        internal System.Windows.Forms.Button btnViewOrderProgress;
        internal System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnAddItems;
        internal System.Windows.Forms.Button btnPriority;
    }
}