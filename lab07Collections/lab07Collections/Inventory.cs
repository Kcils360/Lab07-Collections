using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07Collections
{
    class Inventory<Product> : IEnumerable<Product>
    {
        Product[] items = new Product[8];
        public int count = 0;

        public void Add(Product item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            //items[count++] = item;
            items[count] = item;
            count++;
        }

        public void Remove(Product item)
        {
            int removeAt = Array.IndexOf(items, item);
            bool remove = false;
            Product[] newArray = new Product[items.Length];

            for (int i = 0; i <count; i ++)
            {
                if (remove)
                {
                    newArray[i - 1] = items[i];
                }
                if (i != removeAt && !remove)
                {
                    newArray[i] = items[i];
                }
                else
                {
                    remove = true;
                }
            }
            items = newArray;
            count--;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
