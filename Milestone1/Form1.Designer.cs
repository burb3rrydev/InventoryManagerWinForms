namespace Milestone1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ddInventory = new ComboBox();
            ddSortInventory = new ComboBox();
            lbName = new Label();
            lbQty = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            lbDescription = new Label();
            lbSword = new Label();
            lbBow = new Label();
            lbShield = new Label();
            lbHealth = new Label();
            lbArmor = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            cbSword = new CheckBox();
            cbBow = new CheckBox();
            cbShield = new CheckBox();
            cbHealth = new CheckBox();
            cbArmor = new CheckBox();
            lbSelect = new Label();
            SuspendLayout();
            // 
            // ddInventory
            // 
            ddInventory.FormattingEnabled = true;
            ddInventory.Items.AddRange(new object[] { "Show All", "Weapons", "Health", "Defense" });
            ddInventory.Location = new Point(15, 12);
            ddInventory.Name = "ddInventory";
            ddInventory.Size = new Size(121, 23);
            ddInventory.TabIndex = 0;
            ddInventory.Text = "View Inventory";
            // 
            // ddSortInventory
            // 
            ddSortInventory.FormattingEnabled = true;
            ddSortInventory.Items.AddRange(new object[] { "Sort by name (Ascending)", "Sort by name (Descending)", "Sort by price (Ascending)", "Sort by price(Descending)" });
            ddSortInventory.Location = new Point(161, 12);
            ddSortInventory.Name = "ddSortInventory";
            ddSortInventory.Size = new Size(121, 23);
            ddSortInventory.TabIndex = 1;
            ddSortInventory.Text = "Sort Inventory ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(15, 52);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // lbQty
            // 
            lbQty.AutoSize = true;
            lbQty.Location = new Point(71, 52);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(26, 15);
            lbQty.TabIndex = 3;
            lbQty.Text = "Qty";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(103, 52);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Price";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(142, 52);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 5;
            lbCategory.Text = "Category";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(203, 52);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 6;
            lbDescription.Text = "Description";
            // 
            // lbSword
            // 
            lbSword.AutoSize = true;
            lbSword.Location = new Point(15, 78);
            lbSword.Name = "lbSword";
            lbSword.Size = new Size(286, 15);
            lbSword.TabIndex = 7;
            lbSword.Text = "Sword        20       $20      Weapon      For close combat";
            // 
            // lbBow
            // 
            lbBow.AutoSize = true;
            lbBow.Location = new Point(15, 93);
            lbBow.Name = "lbBow";
            lbBow.Size = new Size(315, 15);
            lbBow.TabIndex = 8;
            lbBow.Text = "Bow           50       $30      Weapon      For long range combat";
            // 
            // lbShield
            // 
            lbShield.AutoSize = true;
            lbShield.Location = new Point(15, 108);
            lbShield.Name = "lbShield";
            lbShield.Size = new Size(303, 15);
            lbShield.TabIndex = 9;
            lbShield.Text = "Shield        75       $10      Defense      Adds 50 pts to health";
            // 
            // lbHealth
            // 
            lbHealth.AutoSize = true;
            lbHealth.Location = new Point(15, 123);
            lbHealth.Name = "lbHealth";
            lbHealth.Size = new Size(356, 15);
            lbHealth.TabIndex = 10;
            lbHealth.Text = "Health       10       $10      Health        Restores up to 100 pts of health";
            // 
            // lbArmor
            // 
            lbArmor.AutoSize = true;
            lbArmor.Location = new Point(15, 138);
            lbArmor.Name = "lbArmor";
            lbArmor.Size = new Size(302, 15);
            lbArmor.TabIndex = 11;
            lbArmor.Text = "Armor        30      $5        Defense      Adds 25 pts to health";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(103, 179);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit Item";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(195, 179);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 23);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // cbSword
            // 
            cbSword.AutoSize = true;
            cbSword.Location = new Point(402, 76);
            cbSword.Name = "cbSword";
            cbSword.Size = new Size(15, 14);
            cbSword.TabIndex = 15;
            cbSword.UseVisualStyleBackColor = true;
            // 
            // cbBow
            // 
            cbBow.AutoSize = true;
            cbBow.Location = new Point(402, 93);
            cbBow.Name = "cbBow";
            cbBow.Size = new Size(15, 14);
            cbBow.TabIndex = 16;
            cbBow.UseVisualStyleBackColor = true;
            // 
            // cbShield
            // 
            cbShield.AutoSize = true;
            cbShield.Location = new Point(402, 108);
            cbShield.Name = "cbShield";
            cbShield.Size = new Size(15, 14);
            cbShield.TabIndex = 17;
            cbShield.UseVisualStyleBackColor = true;
            // 
            // cbHealth
            // 
            cbHealth.AutoSize = true;
            cbHealth.Location = new Point(402, 123);
            cbHealth.Name = "cbHealth";
            cbHealth.Size = new Size(15, 14);
            cbHealth.TabIndex = 18;
            cbHealth.UseVisualStyleBackColor = true;
            // 
            // cbArmor
            // 
            cbArmor.AutoSize = true;
            cbArmor.Location = new Point(402, 138);
            cbArmor.Name = "cbArmor";
            cbArmor.Size = new Size(15, 14);
            cbArmor.TabIndex = 19;
            cbArmor.UseVisualStyleBackColor = true;
            // 
            // lbSelect
            // 
            lbSelect.AutoSize = true;
            lbSelect.Location = new Point(391, 52);
            lbSelect.Name = "lbSelect";
            lbSelect.Size = new Size(38, 15);
            lbSelect.TabIndex = 20;
            lbSelect.Text = "Select";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 276);
            Controls.Add(lbSelect);
            Controls.Add(cbArmor);
            Controls.Add(cbHealth);
            Controls.Add(cbShield);
            Controls.Add(cbBow);
            Controls.Add(cbSword);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lbArmor);
            Controls.Add(lbHealth);
            Controls.Add(lbShield);
            Controls.Add(lbBow);
            Controls.Add(lbSword);
            Controls.Add(lbDescription);
            Controls.Add(lbCategory);
            Controls.Add(lbPrice);
            Controls.Add(lbQty);
            Controls.Add(lbName);
            Controls.Add(ddSortInventory);
            Controls.Add(ddInventory);
            Name = "Form1";
            Text = "Inventory Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ddInventory;
        private ComboBox ddSortInventory;
        private Label lbName;
        private Label lbQty;
        private Label lbPrice;
        private Label lbCategory;
        private Label lbDescription;
        private Label lbSword;
        private Label lbBow;
        private Label lbShield;
        private Label lbHealth;
        private Label lbArmor;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private CheckBox cbSword;
        private CheckBox cbBow;
        private CheckBox cbShield;
        private CheckBox cbHealth;
        private CheckBox cbArmor;
        private Label lbSelect;
    }
}