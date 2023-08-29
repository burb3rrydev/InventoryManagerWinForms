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

        private Form1 _form1; // Reference to Form1

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        // Constructor for Edit mode
        public Form2(InventoryItem item) : this()
        {
            originalItem = item;
            FillTextBoxesWithItem(item);
        }

        public Form2()
        {
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
            // Check if the user input is valid
            if (ValidateInput())
            {
                // Check if all required text boxes are not empty and if parsing quantity and price is successful
                if (!string.IsNullOrWhiteSpace(tbName.Text) &&
                    !string.IsNullOrWhiteSpace(tbDescription.Text) &&
                    !string.IsNullOrWhiteSpace(tbCategory.Text) &&
                    int.TryParse(tbQty.Text, out int quantity) && // Parse quantity from text box
                    int.TryParse(tbPrice.Text, out int price))   // Parse price from text box
                {
                    if (originalItem == null)
                    {
                        // Add a new item
                        NewItem = new InventoryItem
                        {
                            Name = tbName.Text,           // Set item name from text box
                            Quantity = quantity,          // Set item quantity parsed from text box
                            Price = price,                // Set item price parsed from text box
                            Category = tbCategory.Text,   // Set item category from text box
                            Description = tbDescription.Text // Set item description from text box
                        };
                    }
                    else
                    {
                        // Modify the existing item
                        ModifiedItem = new InventoryItem
                        {
                            Name = tbName.Text,           // Set item name from text box
                            Quantity = quantity,          // Set item quantity parsed from text box
                            Price = price,                // Set item price parsed from text box
                            Category = tbCategory.Text,   // Set item category from text box
                            Description = tbDescription.Text // Set item description from text box
                        };
                    }
                    this.Close(); // Close the form
                }
                else
                {
                    // Show an error message if any input is missing or invalid
                    MessageBox.Show("Please fill in all attributes correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

    }
}


