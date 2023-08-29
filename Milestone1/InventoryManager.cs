using System;
using System.Collections.Generic;
using System.Linq;

namespace Milestone1
{
    public class InventoryManager
    {
        private List<InventoryItem> items; // Use List<> to store InventoryItem objects

        public InventoryManager(List<InventoryItem> initialItems)
        {
            items = initialItems; // Initialize the items list with the provided initial items
        }

        public List<InventoryItem> GetItems()
        {
            return items; // Return the list of InventoryItem objects
        }

        public void AddItem(InventoryItem newItem)
        {
            items.Add(newItem); // Add the new item to the list
        }

        public void RemoveItems(List<InventoryItem> itemsToRemove)
        {
            items.RemoveAll(item => itemsToRemove.Contains(item)); // Remove specified items from the list
        }

        public void UpdateItem(int index, InventoryItem editedItem)
        {
            if (index >= 0 && index < items.Count) // Check if the provided index is within valid bounds
            {
                items[index] = editedItem; // Update the item at the specified index with the edited item
            }
        }

        public List<InventoryItem> FilterItems(string selectedCategory)
        {
            if (selectedCategory == "Show All") // Check if the user wants to show all categories
            {
                return items; // Return all items if the selected category is "Show All"
            }
            else
            {
                // Return items that match the selected category using LINQ's Where() function
                return items.Where(item => item.Category == selectedCategory).ToList();
            }
        }

        public InventoryItem SearchByName(string itemName)
        {
            // Search for an item with the specified name using LINQ's FirstOrDefault() function
            // Case-insensitive comparison is used
            return items.FirstOrDefault(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        }
    }
}





