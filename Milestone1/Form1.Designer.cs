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
            btnAdd = new Button();
            btnRemove = new Button();
            dgvInventory = new DataGridView();
            tbSearch = new TextBox();
            btnSearch = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // ddInventory
            // 
            ddInventory.FormattingEnabled = true;
            ddInventory.Items.AddRange(new object[] { "Show All", "Weapon", "Health", "Defense" });
            ddInventory.Location = new Point(15, 12);
            ddInventory.Name = "ddInventory";
            ddInventory.Size = new Size(208, 23);
            ddInventory.TabIndex = 0;
            ddInventory.Text = "View Inventory";
            // 
            // ddSortInventory
            // 
            ddSortInventory.FormattingEnabled = true;
            ddSortInventory.Items.AddRange(new object[] { "Name (Ascending)", "Name (Descending)", "Price (Ascending)" });
            ddSortInventory.Location = new Point(229, 12);
            ddSortInventory.Name = "ddSortInventory";
            ddSortInventory.Size = new Size(237, 23);
            ddSortInventory.TabIndex = 1;
            ddSortInventory.Text = "Sort Inventory ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(16, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(207, 30);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Window;
            btnRemove.Location = new Point(245, 290);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(207, 30);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // dgvInventory
            // 
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvInventory.BackgroundColor = SystemColors.MenuHighlight;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(15, 41);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(664, 243);
            dgvInventory.TabIndex = 21;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(472, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(126, 23);
            tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Window;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(604, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Window;
            btnSave.Location = new Point(472, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 30);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save To File";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(691, 325);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvInventory);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(ddSortInventory);
            Controls.Add(ddInventory);
            Name = "Form1";
            Text = "Inventory Manager";
            Load += Form1_Load1;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ddInventory;
        private ComboBox ddSortInventory;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dgvInventory;
        private TextBox tbSearch;
        private Button btnSearch;
        private Button btnSave;
    }
}