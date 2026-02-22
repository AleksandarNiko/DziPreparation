using System;
using System.Collections.Generic;
using System.Text;

namespace _05.zad26May
{
    public class ItemList
    {
        private List<Item> items;
        public ItemList()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentException(nameof(item), "Item cannot be null.");
            }
            else if (items.Contains(item)) 
            {
                throw new ArgumentException("Item already exists in the list.", nameof(item));
            }
            items.Add(item);
        }

        public int Size()
        {
            return items.Count;
        }

        public Item Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentException(nameof(index), "Index is out of range.");
            }
            return items[index];
        }

        public void Sort()
        {
                items.Sort();
        }
    }
}
