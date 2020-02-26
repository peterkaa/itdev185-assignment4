using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Controller
    {
        List theList = new List();
        

        public void MainMethod()
        {
            theList.AddItemsSeq();
            IEnumerable<int> able = (IEnumerable<int>)theList.items;
            IEnumerator<int> rate = theList.items.GetEnumerator();

            Console.WriteLine("\n\tLets use IEnumerable first\n");
            usingIEnumerable(able);
          
            usingIEnumerator(rate);

            Console.WriteLine("\n\n\tLooks the same right?");
            Console.WriteLine("\tWhats the difference?\n\t");

            Console.WriteLine("\tI'll show you! Press enter!");
            Console.ReadLine();

            Console.Clear();
            rate.Reset();

            Iterate1to5(rate, able);

            Console.WriteLine("\n\n\tSee how the IEnumerator saves the current state of the List?");
            Console.WriteLine("\tBut the IEnumerable does not!");
            Console.WriteLine("\n\tNow lets use the 'yield' keyword to filter some data. Press enter!");
            Console.ReadLine();

            Console.Clear();
            theList.ClearItems();
            theList.AddItemsRand();

            Console.WriteLine("\n\tThese are our values. Using IEnumerable to iterate\n");
            usingIEnumerable(able);

            Console.WriteLine("\n\n\tNow lets filter this data with the 'yield' keyword.");
            Console.WriteLine("\tWe will only display numbers greater than 10\n");
            IterateWithFilter(able);
            Console.WriteLine("\n\n\tExcellent! Press enter to exit!");


            Console.ReadLine();
        }

        public void usingIEnumerable(IEnumerable<int> able)
        {
            Console.Write("\t");
            foreach (int i in able)
            {
                Console.Write(i + " ");
            }
        }

        public void usingIEnumerator(IEnumerator<int> rate)
        {
            Console.WriteLine("\n\n\tNow lets use IEnumerator\n");

            Console.Write("\t");
            while (rate.MoveNext())
            {
                Console.Write(rate.Current + " ");
            }

        }

        public void Iterate1to5(IEnumerator<int> rate, IEnumerable<int> able)
        {

            Console.WriteLine("\n\tUsing IEnumerable\n");
            Console.Write("\t");
            foreach (int i in able)
            {
                if (i < 6)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n\n\tUsing IEnumerator\n");
            Console.Write("\t");
            while (rate.MoveNext())
            {
                
                Console.Write(rate.Current + " ");
                if (rate.Current > 4)
                {
                    break;
                }

            }

            Iterate6to10(rate, able);


        }

        public void Iterate6to10(IEnumerator<int> rate, IEnumerable<int> able)
        {

            Console.WriteLine("\n\n\tIn seperate method");
            Console.WriteLine("\tBoth Loops broke at the same point\n");

            Console.WriteLine("\tUsing IEnumerable\n");
            Console.Write("\t");
            foreach (int i in able)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n\tUsing IEnumerator\n");
            Console.Write("\t");
            while (rate.MoveNext())
            {
                Console.Write(rate.Current + " ");
            }

        }

        public void IterateWithFilter(IEnumerable<int> able)
        {
            Console.Write("\t");
            foreach (int i in Filter(able))
            {
                Console.Write(i + " ");
            }
        }

        public IEnumerable<int> Filter(IEnumerable<int> able)
        {
            
            foreach (int i in able)
            {
                if (i > 10)
                {
                    yield return i;
                }
            }
        }
    }
}
