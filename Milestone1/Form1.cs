
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Milestone1
{

    public partial class Form1 : Form
    {
        private List<InventoryItem> items; // Declare a list to store InventoryItem objects

        public Form1()
        {
            items = GetItems(); // Initialize the list by calling the GetItems() method
            InitializeComponent(); // Initialize the form and its components
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = items; // Set the data source for the DataGridView to the items list
        }

        private void ddInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(); // Event handler for when the selected category in the ComboBox changes
        }

        private void ddSortInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(); // Event handler for when the selected sorting option in the ComboBox changes
        }

        private void UpdateDataGridView()
        {
            // Get the selected category and sorting option from ComboBoxes
            string selectedCategory = ddInventory.SelectedItem.ToString();
            string selectedSortOption = ddSortInventory.SelectedItem.ToString();

            // Filter the items based on the selected category
            List<InventoryItem> filteredItems;
            if (selectedCategory == "Show All")
            {
                filteredItems = items; // If "Show All" is selected, display all items
            }
            else
            {
                filteredItems = items.FindAll(item => item.Category == selectedCategory); // Filter items based on selected category
            }

            // Sort the filtered items based on the selected sorting option
            switch (selectedSortOption)
            {
                case "Name (Ascending)":
                    filteredItems.Sort((x, y) => x.Name.CompareTo(y.Name)); // Sort items by name in ascending order
                    break;
                case "Name (Descending)":
                    filteredItems.Sort((x, y) => y.Name.CompareTo(x.Name)); // Sort items by name in descending order
                    break;
                case "Price (Ascending)":
                    filteredItems.Sort((x, y) => x.Price.CompareTo(y.Price)); // Sort items by price in ascending order
                    break;
            }

            // Update the DataGridView
            dgvInventory.DataSource = null; // Clear the data source
            dgvInventory.DataSource = filteredItems; // Set the filtered and sorted items as the new data source
        }

        private List<InventoryItem> GetItems()
        {
            // Create a list of InventoryItem objects and populate it with sample data
            var list = new List<InventoryItem>();
            list.Add(new InventoryItem()
            {
                Name = "Sword",
                Quantity = 10,
                Price = 20,
                Category = "Weapon",
                Description = "For close combat"
            });
            list.Add(new InventoryItem()
            {
                Name = "Bow",
                Quantity = 5,
                Price = 40,
                Category = "Weapon",
                Description = "For distant combat"
            });
            list.Add(new InventoryItem()
            {
                Name = "Shield",
                Quantity = 100,
                Price = 15,
                Category = "Defense",
                Description = "Adds 50 health"
            });
            list.Add(new InventoryItem()
            {
                Name = "Health Potion",
                Quantity = 200,
                Price = 10,
                Category = "Health",
                Description = "Restores 20 health"
            });
            list.Add(new InventoryItem()
            {
                Name = "Armor",
                Quantity = 75,
                Price = 30,
                Category = "Defense",
                Description = "Adds 100 health"
            });
            return list;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgvInventory.AutoGenerateColumns = false; // Disable auto-generating columns for DataGridView

            // Set the initial selected index for ComboBoxes
            ddInventory.SelectedIndex = 0; // Select "Show All"
            ddSortInventory.SelectedIndex = 0; // Select "Sort by name (Ascending)"

            // Attach event handlers for ComboBoxes
            ddInventory.SelectedIndexChanged += ddInventory_SelectedIndexChanged;
            ddSortInventory.SelectedIndexChanged += ddSortInventory_SelectedIndexChanged;

            // Set the "FullRowSelect" selection mode for DataGridView
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set the initial data source for the DataGridView
            dgvInventory.DataSource = items;

            // Create and bind the DataGridView columns to the properties of the InventoryItem class
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            // Set the initial data source for the DataGridView
            dgvInventory.DataSource = items;

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            // Create a list to store the items to be removed
            List<InventoryItem> itemsToRemove = new List<InventoryItem>();

            // Collect selected items to remove
            foreach (DataGridViewRow selectedRow in dgvInventory.SelectedRows)
            {
                if (selectedRow.DataBoundItem is InventoryItem selectedItem)
                {
                    itemsToRemove.Add(selectedItem); // Add the selected items to the list
                }
            }

            // Remove the selected items from the inventory list
            foreach (InventoryItem itemToRemove in itemsToRemove)
            {
                items.Remove(itemToRemove); // Remove the selected items from the main list
            }

            // Clear the DataGridView selection
            dgvInventory.ClearSelection();

            // Update the DataGridView after removing items
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open Form2 for adding new items to inventory
            Form2 form2 = new Form2();
            form2.ShowDialog();

            // Add the new item to the inventory if it was saved in Form2
            if (form2.NewItem != null)
            {
                items.Add(form2.NewItem); // Add the new item to the main list
                UpdateDataGridView(); // Update the DataGridView to reflect the changes
            }
        }

    }
}


