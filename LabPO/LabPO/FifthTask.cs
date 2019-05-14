using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class FifthTask
    {
        public List<int> Method(List<int> a)
        {
            var list = new List<int>();
            var b = a.Max();

            // list.Add(a[0]);
            Console.WriteLine(b);
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine(a.Count());


            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    list.Add(a[i]);    
                    list.Add(b);
                    //list.Add(a[i + 1]);
                }
                else
                {
                    list.Add(a[i]);
                    //list.Add(a[i + 1]);
                }
            }
            list.Add(a[a.Count - 1]);
            Console.ForegroundColor = ConsoleColor.Green;
            list.Add(b);
            Console.ResetColor();
            //foreach (int i in list)
             //   Console.Write(i + " ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(list[i] + " ");
                    Console.ResetColor();
                }
                else
                    Console.Write(list[i] + " ");
            }
            return list; 
        }
    }
}
