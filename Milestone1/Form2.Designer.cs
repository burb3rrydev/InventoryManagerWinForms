﻿namespace Milestone1
{
    partial class Form2
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
            lbAddName = new Label();
            tbName = new TextBox();
            lbAddQty = new Label();
            tbQty = new TextBox();
            lbAddPrice = new Label();
            tbPrice = new TextBox();
            lbAddCategory = new Label();
            tbCategory = new TextBox();
            lbAddDescription = new Label();
            tbDescription = new TextBox();
            btnAddInventory = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lbAddName
            // 
            lbAddName.AutoSize = true;
            lbAddName.Location = new Point(12, 34);
            lbAddName.Name = "lbAddName";
            lbAddName.Size = new Size(39, 15);
            lbAddName.TabIndex = 0;
            lbAddName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(65, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // lbAddQty
            // 
            lbAddQty.AutoSize = true;
            lbAddQty.Location = new Point(188, 34);
            lbAddQty.Name = "lbAddQty";
            lbAddQty.Size = new Size(26, 15);
            lbAddQty.TabIndex = 2;
            lbAddQty.Text = "Qty";
            // 
            // tbQty
            // 
            tbQty.Location = new Point(233, 31);
            tbQty.Name = "tbQty";
            tbQty.Size = new Size(100, 23);
            tbQty.TabIndex = 3;
            // 
            // lbAddPrice
            // 
            lbAddPrice.AutoSize = true;
            lbAddPrice.Location = new Point(360, 34);
            lbAddPrice.Name = "lbAddPrice";
            lbAddPrice.Size = new Size(33, 15);
            lbAddPrice.TabIndex = 4;
            lbAddPrice.Text = "Price";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(410, 31);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(100, 23);
            tbPrice.TabIndex = 5;
            // 
            // lbAddCategory
            // 
            lbAddCategory.AutoSize = true;
            lbAddCategory.Location = new Point(30, 109);
            lbAddCategory.Name = "lbAddCategory";
            lbAddCategory.Size = new Size(55, 15);
            lbAddCategory.TabIndex = 6;
            lbAddCategory.Text = "Category";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(91, 104);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(123, 23);
            tbCategory.TabIndex = 7;
            // 
            // lbAddDescription
            // 
            lbAddDescription.AutoSize = true;
            lbAddDescription.Location = new Point(239, 104);
            lbAddDescription.Name = "lbAddDescription";
            lbAddDescription.Size = new Size(67, 15);
            lbAddDescription.TabIndex = 8;
            lbAddDescription.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(312, 101);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(166, 23);
            tbDescription.TabIndex = 9;
            // 
            // btnAddInventory
            // 
            btnAddInventory.BackColor = SystemColors.Window;
            btnAddInventory.Location = new Point(108, 175);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(124, 35);
            btnAddInventory.TabIndex = 10;
            btnAddInventory.Text = "Add To Invenotry";
            btnAddInventory.UseVisualStyleBackColor = false;
            btnAddInventory.Click += btnAddInventory_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Window;
            btnClear.Location = new Point(312, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(551, 309);
            Controls.Add(btnClear);
            Controls.Add(btnAddInventory);
            Controls.Add(tbDescription);
            Controls.Add(lbAddDescription);
            Controls.Add(tbCategory);
            Controls.Add(lbAddCategory);
            Controls.Add(tbPrice);
            Controls.Add(lbAddPrice);
            Controls.Add(tbQty);
            Controls.Add(lbAddQty);
            Controls.Add(tbName);
            Controls.Add(lbAddName);
            Name = "Form2";
            Text = "Inventory Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAddName;
        private TextBox tbName;
        private Label lbAddQty;
        private TextBox tbQty;
        private Label lbAddPrice;
        private TextBox tbPrice;
        private Label lbAddCategory;
        private TextBox tbCategory;
        private Label lbAddDescription;
        private TextBox tbDescription;
        private Button btnAddInventory;
        private Button btnClear;
    }
}