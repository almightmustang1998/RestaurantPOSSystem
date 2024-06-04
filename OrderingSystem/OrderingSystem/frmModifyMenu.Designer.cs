namespace OrderingSystem
{
    partial class frmModifyMenu
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.gbModify = new System.Windows.Forms.GroupBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtModifyPrice = new System.Windows.Forms.TextBox();
            this.lblModifyMealType = new System.Windows.Forms.Label();
            this.txtModifyCategory = new System.Windows.Forms.TextBox();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.lblModifyCategory = new System.Windows.Forms.Label();
            this.txtModifyMealType = new System.Windows.Forms.TextBox();
            this.lblModifyDescription = new System.Windows.Forms.Label();
            this.lblModifyPrice = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvCategorizedItems = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboCategoryList = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboBoxMealType = new System.Windows.Forms.ComboBox();
            this.lblMealType = new System.Windows.Forms.Label();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblModifyUrl = new System.Windows.Forms.Label();
            this.txtBoxModifyImageURL = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.gbModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorizedItems)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.gbModify);
            this.GroupBox2.Controls.Add(this.btnModify);
            this.GroupBox2.Controls.Add(this.dgvCategorizedItems);
            this.GroupBox2.Controls.Add(this.btnRemove);
            this.GroupBox2.Controls.Add(this.cboCategoryList);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 232);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(631, 272);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Remove Menu Item";
            // 
            // gbModify
            // 
            this.gbModify.Controls.Add(this.txtBoxModifyImageURL);
            this.gbModify.Controls.Add(this.lblModifyUrl);
            this.gbModify.Controls.Add(this.lblHelp);
            this.gbModify.Controls.Add(this.txtModifyPrice);
            this.gbModify.Controls.Add(this.lblModifyMealType);
            this.gbModify.Controls.Add(this.txtModifyCategory);
            this.gbModify.Controls.Add(this.txtModifyDescription);
            this.gbModify.Controls.Add(this.lblModifyCategory);
            this.gbModify.Controls.Add(this.txtModifyMealType);
            this.gbModify.Controls.Add(this.lblModifyDescription);
            this.gbModify.Controls.Add(this.lblModifyPrice);
            this.gbModify.Location = new System.Drawing.Point(419, 50);
            this.gbModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModify.Name = "gbModify";
            this.gbModify.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModify.Size = new System.Drawing.Size(197, 186);
            this.gbModify.TabIndex = 18;
            this.gbModify.TabStop = false;
            this.gbModify.Text = "Modify";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(14, 14);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelp.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblHelp.MinimumSize = new System.Drawing.Size(20, 26);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(173, 26);
            this.lblHelp.TabIndex = 18;
            this.lblHelp.Text = "*Leave blank if you don\'t want any change to that field";
            // 
            // txtModifyPrice
            // 
            this.txtModifyPrice.Location = new System.Drawing.Point(79, 51);
            this.txtModifyPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModifyPrice.Name = "txtModifyPrice";
            this.txtModifyPrice.Size = new System.Drawing.Size(113, 20);
            this.txtModifyPrice.TabIndex = 10;
            // 
            // lblModifyMealType
            // 
            this.lblModifyMealType.AutoSize = true;
            this.lblModifyMealType.Location = new System.Drawing.Point(14, 138);
            this.lblModifyMealType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyMealType.Name = "lblModifyMealType";
            this.lblModifyMealType.Size = new System.Drawing.Size(60, 13);
            this.lblModifyMealType.TabIndex = 17;
            this.lblModifyMealType.Text = "Meal Type:";
            // 
            // txtModifyCategory
            // 
            this.txtModifyCategory.Location = new System.Drawing.Point(79, 108);
            this.txtModifyCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModifyCategory.Name = "txtModifyCategory";
            this.txtModifyCategory.Size = new System.Drawing.Size(113, 20);
            this.txtModifyCategory.TabIndex = 12;
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(79, 77);
            this.txtModifyDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(113, 20);
            this.txtModifyDescription.TabIndex = 13;
            // 
            // lblModifyCategory
            // 
            this.lblModifyCategory.AutoSize = true;
            this.lblModifyCategory.Location = new System.Drawing.Point(14, 108);
            this.lblModifyCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyCategory.Name = "lblModifyCategory";
            this.lblModifyCategory.Size = new System.Drawing.Size(52, 13);
            this.lblModifyCategory.TabIndex = 16;
            this.lblModifyCategory.Text = "Category:";
            // 
            // txtModifyMealType
            // 
            this.txtModifyMealType.Location = new System.Drawing.Point(79, 136);
            this.txtModifyMealType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModifyMealType.Name = "txtModifyMealType";
            this.txtModifyMealType.Size = new System.Drawing.Size(113, 20);
            this.txtModifyMealType.TabIndex = 11;
            // 
            // lblModifyDescription
            // 
            this.lblModifyDescription.AutoSize = true;
            this.lblModifyDescription.Location = new System.Drawing.Point(14, 79);
            this.lblModifyDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyDescription.Name = "lblModifyDescription";
            this.lblModifyDescription.Size = new System.Drawing.Size(63, 13);
            this.lblModifyDescription.TabIndex = 15;
            this.lblModifyDescription.Text = "Description:";
            // 
            // lblModifyPrice
            // 
            this.lblModifyPrice.AutoSize = true;
            this.lblModifyPrice.Location = new System.Drawing.Point(14, 52);
            this.lblModifyPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyPrice.Name = "lblModifyPrice";
            this.lblModifyPrice.Size = new System.Drawing.Size(34, 13);
            this.lblModifyPrice.TabIndex = 14;
            this.lblModifyPrice.Text = "Price:";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(209, 231);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(141, 24);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify Item";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvCategorizedItems
            // 
            this.dgvCategorizedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorizedItems.Location = new System.Drawing.Point(6, 60);
            this.dgvCategorizedItems.Name = "dgvCategorizedItems";
            this.dgvCategorizedItems.RowHeadersWidth = 62;
            this.dgvCategorizedItems.Size = new System.Drawing.Size(383, 150);
            this.dgvCategorizedItems.TabIndex = 8;
            this.dgvCategorizedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorizedItems_CellContentClick);
            this.dgvCategorizedItems.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategorizedItems_RowHeaderMouseClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(43, 232);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove From Menu";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboCategoryList
            // 
            this.cboCategoryList.FormattingEnabled = true;
            this.cboCategoryList.Items.AddRange(new object[] {
            "Appetizer",
            "Dessert",
            "Drink",
            "Entree",
            "Salad"});
            this.cboCategoryList.Location = new System.Drawing.Point(98, 33);
            this.cboCategoryList.Name = "cboCategoryList";
            this.cboCategoryList.Size = new System.Drawing.Size(121, 21);
            this.cboCategoryList.TabIndex = 5;
            this.cboCategoryList.SelectedIndexChanged += new System.EventHandler(this.cboCategoryList_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Category:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblImage);
            this.GroupBox1.Controls.Add(this.txtBoxURL);
            this.GroupBox1.Controls.Add(this.cmboBoxMealType);
            this.GroupBox1.Controls.Add(this.lblMealType);
            this.GroupBox1.Controls.Add(this.btnAddToMenu);
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.lblPrice);
            this.GroupBox1.Controls.Add(this.txtDesc);
            this.GroupBox1.Controls.Add(this.lblDesc);
            this.GroupBox1.Controls.Add(this.cboCategory);
            this.GroupBox1.Controls.Add(this.lblCategory);
            this.GroupBox1.Location = new System.Drawing.Point(12, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(336, 200);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add New Menu Item";
            // 
            // cmboBoxMealType
            // 
            this.cmboBoxMealType.FormattingEnabled = true;
            this.cmboBoxMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.cmboBoxMealType.Location = new System.Drawing.Point(99, 33);
            this.cmboBoxMealType.Name = "cmboBoxMealType";
            this.cmboBoxMealType.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxMealType.TabIndex = 6;
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(29, 33);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(57, 13);
            this.lblMealType.TabIndex = 5;
            this.lblMealType.Text = "Meal Type";
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Location = new System.Drawing.Point(209, 171);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(121, 23);
            this.btnAddToMenu.TabIndex = 4;
            this.btnAddToMenu.Text = "Add to Menu";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            this.btnAddToMenu.Click += new System.EventHandler(this.btnAddToMenu_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(69, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(58, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(98, 101);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(195, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(29, 104);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Appetizer",
            "Dessert",
            "Drink",
            "Entree",
            "Salad "});
            this.cboCategory.Location = new System.Drawing.Point(98, 64);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 67);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(99, 161);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(104, 20);
            this.txtBoxURL.TabIndex = 7;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(22, 164);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(64, 13);
            this.lblImage.TabIndex = 8;
            this.lblImage.Text = "Image URL:";
            // 
            // lblModifyUrl
            // 
            this.lblModifyUrl.AutoSize = true;
            this.lblModifyUrl.Location = new System.Drawing.Point(14, 162);
            this.lblModifyUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyUrl.Name = "lblModifyUrl";
            this.lblModifyUrl.Size = new System.Drawing.Size(64, 13);
            this.lblModifyUrl.TabIndex = 19;
            this.lblModifyUrl.Text = "Image URL:";
            // 
            // txtBoxModifyImageURL
            // 
            this.txtBoxModifyImageURL.Location = new System.Drawing.Point(79, 160);
            this.txtBoxModifyImageURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxModifyImageURL.Name = "txtBoxModifyImageURL";
            this.txtBoxModifyImageURL.Size = new System.Drawing.Size(113, 20);
            this.txtBoxModifyImageURL.TabIndex = 20;
            // 
            // frmModifyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(683, 679);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.MinimumSize = new System.Drawing.Size(699, 480);
            this.Name = "frmModifyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyMenu";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.gbModify.ResumeLayout(false);
            this.gbModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorizedItems)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.ComboBox cboCategoryList;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAddToMenu;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Label lblDesc;
        internal System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.ComboBox cmboBoxMealType;
        internal System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.DataGridView dgvCategorizedItems;
        private System.Windows.Forms.GroupBox gbModify;
        private System.Windows.Forms.TextBox txtModifyPrice;
        private System.Windows.Forms.Label lblModifyMealType;
        private System.Windows.Forms.TextBox txtModifyCategory;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.Label lblModifyCategory;
        private System.Windows.Forms.TextBox txtModifyMealType;
        private System.Windows.Forms.Label lblModifyDescription;
        private System.Windows.Forms.Label lblModifyPrice;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblHelp;
        internal System.Windows.Forms.Label lblImage;
        internal System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.TextBox txtBoxModifyImageURL;
        private System.Windows.Forms.Label lblModifyUrl;
    }
}