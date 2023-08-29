using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Form1 : Form
    {
        private InventoryManager inventoryManager; // Declare an instance of InventoryManager

        public Form1()
        {
            InitializeComponent(); // Initialize the form and its components
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            // Initialize the inventory manager with sample data
            inventoryManager = new InventoryManager(GetItems().ToList());


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
            dgvInventory.DataSource = inventoryManager.GetItems();

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
            string selectedCategory = ddInventory.SelectedItem.ToString();
            string selectedSortOption = ddSortInventory.SelectedItem.ToString();

            // Get the original items list
            List<InventoryItem> allItems = inventoryManager.GetItems();

            // Apply filtering if a specific category is selected
            List<InventoryItem> filteredItemsList = selectedCategory != "Show All"
                ? allItems.Where(item => item.Category == selectedCategory).ToList()
                : allItems.ToList();

            // Apply sorting based on the selected option
            if (selectedSortOption == "Name (Ascending)")
            {
                filteredItemsList.Sort((x, y) => x.Name.CompareTo(y.Name));
            }
            else if (selectedSortOption == "Name (Descending)")
            {
                filteredItemsList.Sort((x, y) => y.Name.CompareTo(x.Name));
            }
            else if (selectedSortOption == "Price (Ascending)")
            {
                filteredItemsList.Sort((x, y) => x.Price.CompareTo(y.Price));
            }

            // Suspend data binding while performing sorting and filtering
            dgvInventory.SuspendLayout();

            // Set the DataGridView data source
            dgvInventory.DataSource = filteredItemsList;

            // Resume data binding after setting data source
            dgvInventory.ResumeLayout();

            // Refresh the DataGridView to update the display
            dgvInventory.Refresh();
        }


        private List<InventoryItem> GetItems()
        {
            // Create a List<InventoryItem> and populate it with sample data
            return new List<InventoryItem>
            {
                new InventoryItem()
                {
                    Name = "Sword",
                    Quantity = 10,
                    Price = 20,
                    Category = "Weapon",
                    Description = "For close combat"
                },
                new InventoryItem()
                {
                    Name = "Bow",
                    Quantity = 5,
                    Price = 40,
                    Category = "Weapon",
                    Description = "For distant combat"
                },
                new InventoryItem()
                {
                    Name = "Shield",
                    Quantity = 100,
                    Price = 15,
                    Category = "Defense",
                    Description = "Adds 50 health"
                },
                new InventoryItem()
                {
                    Name = "Health Potion",
                    Quantity = 200,
                    Price = 10,
                    Category = "Health",
                    Description = "Restores 20 health"
                },
                new InventoryItem()
                {
                    Name = "Armor",
                    Quantity = 75,
                    Price = 30,
                    Category = "Defense",
                    Description = "Adds 100 health"
                },
                new InventoryItem()
                {
                    Name = "Magic Staff",
                    Quantity = 8,
                    Price = 60,
                    Category = "Weapon",
                    Description = "For magic attacks"
                },
                new InventoryItem()
                {
                    Name = "Crossbow",
                    Quantity = 3,
                    Price = 35,
                    Category = "Weapon",
                    Description = "Percise accuracy"
                },
                new InventoryItem()
                {
                    Name = "Amulet of Protection",
                    Quantity = 50,
                    Price = 25,
                    Category = "Defense",
                    Description = "Temporary invisiblity"
                },
                new InventoryItem()
                {
                    Name = "Mana Elixir",
                    Quantity = 150,
                    Price = 12,
                    Category = "Health",
                    Description = "Restores 30 health"
                },
                new InventoryItem()
                {
                    Name = "Enchanted Robes",
                    Quantity = 60,
                    Price = 45,
                    Category = "Weapon",
                    Description = "Stronger attack"
                }

            };
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            // Call the method to remove selected items from inventory
            RemoveSelectedItemsFromInventory();
        }

        private void RemoveSelectedItemsFromInventory()
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

            // Remove the selected items from the inventory manager
            foreach (InventoryItem itemToRemove in itemsToRemove)
            {
                inventoryManager.RemoveItems(new List<InventoryItem> { itemToRemove });
            }

            // Clear the DataGridView selection
            dgvInventory.ClearSelection();

            // Update the DataGridView after removing items
            UpdateDataGridView();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open Form2 for adding new items to inventory
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

            // Add the new item to the inventory if it was saved in Form2
            if (form2.NewItem != null)
            {
                inventoryManager.AddItem(form2.NewItem);
                UpdateDataGridView();
            }
        }

        private void UpdateItemInInventory(int index, DataGridViewRow editedRow)
        {
            if (index >= 0 && index < inventoryManager.GetItems().Count)
            {
                InventoryItem itemToUpdate = inventoryManager.GetItems()[index];
                itemToUpdate.Name = editedRow.Cells["Name"].Value.ToString();
                itemToUpdate.Quantity = int.Parse(editedRow.Cells["Quantity"].Value.ToString());
                itemToUpdate.Price = int.Parse(editedRow.Cells["Price"].Value.ToString());
                itemToUpdate.Category = editedRow.Cells["Category"].Value.ToString();
                itemToUpdate.Description = editedRow.Cells["Description"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = tbSearch.Text; // Get the search text from the TextBox

            // Find the item in the inventory manager based on the search name
            InventoryItem foundItem = inventoryManager.SearchByName(searchName);

            if (foundItem != null)
            {
                // Display the found item in the DataGridView
                dgvInventory.DataSource = new List<InventoryItem> { foundItem };
            }
            else
            {
                // Display a message if item is not found
                dgvInventory.DataSource = null; // Clear the DataGridView
                MessageBox.Show("Item not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the path to the user's Downloads folder and append "Inventory.txt"
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Inventory.txt";

            try
            {
                // Retrieve the list of items from the inventory manager
                List<InventoryItem> itemsToSave = inventoryManager.GetItems();

                // Create or overwrite the "Inventory.txt" file in the Downloads folder
                using (StreamWriter writer = new StreamWriter(downloadsPath))
                {
                    foreach (InventoryItem item in itemsToSave)
                    {
                        // Format the item attributes as a comma-separated values (CSV) line
                        string csvLine = $"{item.Name},{item.Quantity},{item.Price},{item.Category},{item.Description}";
                        writer.WriteLine(csvLine); // Write the CSV line to the file
                    }
                }

                // Display a success message with the saved file path
                MessageBox.Show($"Inventory saved to {downloadsPath}", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}



