using System;
using System.Collections.Generic;

namespace TDEMARCOS
{
    internal class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully!\n");
        }

        public void ListItems()
        {
            Console.WriteLine("\n--- Items in Inventory ---");
            if (items.Count == 0)
            {
                Console.WriteLine("No items registered.");
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i]}");
                }
            }
            Console.WriteLine();
        }

        public void EditItem(int index, Item newItem)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = newItem;
                Console.WriteLine("Item updated successfully!\n");
            }
            else
            {
                Console.WriteLine("Invalid index!\n");
            }
        }

        public void RemoveItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
                Console.WriteLine("Item removed successfully!\n");
            }
            else
            {
                Console.WriteLine("Invalid index!\n");
            }
        }
    }
}
