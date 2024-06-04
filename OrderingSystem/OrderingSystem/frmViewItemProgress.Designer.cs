
namespace OrderingSystem
{
    partial class frmViewItemProgress
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
            this.lvProgress = new System.Windows.Forms.ListView();
            this.btnCooking = new System.Windows.Forms.Button();
            this.btnCooked = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.IndividualItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvProgress
            // 
            this.lvProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndividualItemID,
            this.Order,
            this.MenuID,
            this.Description,
            this.Progress});
            this.lvProgress.HideSelection = false;
            this.lvProgress.Location = new System.Drawing.Point(28, 42);
            this.lvProgress.MultiSelect = false;
            this.lvProgress.Name = "lvProgress";
            this.lvProgress.Size = new System.Drawing.Size(760, 249);
            this.lvProgress.TabIndex = 0;
            this.lvProgress.UseCompatibleStateImageBehavior = false;
            this.lvProgress.View = System.Windows.Forms.View.Details;
            // 
            // btnCooking
            // 
            this.btnCooking.Location = new System.Drawing.Point(290, 342);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(162, 68);
            this.btnCooking.TabIndex = 1;
            this.btnCooking.Text = "Item Cooking";
            this.btnCooking.UseVisualStyleBackColor = true;
            this.btnCooking.Click += new System.EventHandler(this.btnCooking_Click);
            // 
            // btnCooked
            // 
            this.btnCooked.Location = new System.Drawing.Point(470, 342);
            this.btnCooked.Name = "btnCooked";
            this.btnCooked.Size = new System.Drawing.Size(162, 68);
            this.btnCooked.TabIndex = 2;
            this.btnCooked.Text = "Item Cooked";
            this.btnCooked.UseVisualStyleBackColor = true;
            this.btnCooked.Click += new System.EventHandler(this.btnCooked_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(109, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 68);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // IndividualItemID
            // 
            this.IndividualItemID.Text = "ItemID";
            this.IndividualItemID.Width = 80;
            // 
            // Order
            // 
            this.Order.Text = "OrderID";
            this.Order.Width = 80;
            // 
            // MenuID
            // 
            this.MenuID.Text = "MenuID";
            this.MenuID.Width = 80;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 150;
            // 
            // Progress
            // 
            this.Progress.Text = "Progress";
            this.Progress.Width = 100;
            // 
            // frmViewItemProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCooked);
            this.Controls.Add(this.btnCooking);
            this.Controls.Add(this.lvProgress);
            this.Name = "frmViewItemProgress";
            this.Text = "Item Progress";
            this.Load += new System.EventHandler(this.frmViewItemProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProgress;
        private System.Windows.Forms.Button btnCooking;
        private System.Windows.Forms.Button btnCooked;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader IndividualItemID;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.ColumnHeader MenuID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Progress;
    }
}