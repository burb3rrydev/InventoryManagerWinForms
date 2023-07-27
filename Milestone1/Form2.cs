// Form2.cs
using System;
using System.Windows.Forms;

namespace Milestone1
{

    public partial class Form2 : Form
    {
        // Properties to store the new item and modified item
        public InventoryItem NewItem { get; private set; }
        public InventoryItem ModifiedItem { get; private set; }

        private InventoryItem originalItem; // Store the original item if in Edit mode

        public Form2()
        {
            InitializeComponent();
        }

        // Constructor for Edit mode
        public Form2(InventoryItem item) : this()
        {
            originalItem = item;
            FillTextBoxesWithItem(item);
        }

        private void FillTextBoxesWithItem(InventoryItem item)
        {
            tbName.Text = item.Name;
            tbQty.Text = item.Quantity.ToString();
            tbPrice.Text = item.Price.ToString();
            tbCategory.Text = item.Category;
            tbDescription.Text = item.Description;
        }


        private bool ValidateInput()
        {
            // Implement your validation logic here
            // For example, check if the required fields are filled, if the quantity and price are valid numbers, etc.
            // You can use int.TryParse() to check if the quantity and price are valid integers.

            // For simplicity, let's assume the input is always valid in this example.
            return true;
        }

        private void ClearTextBoxes()
        {
            tbName.Text = "";
            tbQty.Text = "";
            tbPrice.Text = "";
            tbCategory.Text = "";
            tbDescription.Text = "";
        }

        private void btnAddInventory_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (originalItem == null)
                {
                    // Add a new item
                    NewItem = new InventoryItem
                    {
                        Name = tbName.Text,
                        Quantity = int.Parse(tbQty.Text),
                        Price = int.Parse(tbPrice.Text),
                        Category = tbCategory.Text,
                        Description = tbDescription.Text
                    };
                }
                else
                {
                    // Modify the existing item
                    ModifiedItem = new InventoryItem
                    {
                        Name = tbName.Text,
                        Quantity = int.Parse(tbQty.Text),
                        Price = int.Parse(tbPrice.Text),
                        Category = tbCategory.Text,
                        Description = tbDescription.Text
                    };
                }
                this.Close();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}


