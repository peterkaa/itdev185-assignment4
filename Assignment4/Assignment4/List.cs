using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class List
    {
        public List<int> items = new List<int>();

        Random rand = new Random();

        public void AddItemsSeq()
        {
            items.Add(1);
            items.Add(2);
            items.Add(3);
            items.Add(4);
            items.Add(5);
            items.Add(6);
            items.Add(7);
            items.Add(8);
            items.Add(9);
            items.Add(10);
        }
        
        public void AddItemsRand()
        {
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(0, 20);
                items.Add(x);
            }
        }

        public void ClearItems()
        {
            items.Clear();
        }
        
    }
}
