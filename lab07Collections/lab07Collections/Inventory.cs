using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07Collections
{
    class Inventory<Product> : IEnumerable<Product>
    {
        Product[] items = new Product[8];
        int count = 0;

        public void Add(Product item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public void Remove(Product item)
        {
            items[count] = item;
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
