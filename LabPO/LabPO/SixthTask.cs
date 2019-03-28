using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class SixthTask
    {
        public List<int> Method(List<int> a)
        {
            var list = new List<int>();

            /* foreach (int i in a)
                 Console.Write(i + " ");
             Console.WriteLine();

             var count = 1;
             var number = a[0];
             list.Add(a[0]);
             for (int i = 1; i < a.Count; i++)
             {
                 if (a[i] == number)
                     count++;
                 else
                 {
                     list.Add(count);
                     Console.Write(count + "(" + number + ")");
                     count = 1;
                     number = a[i];
                 }
             }
             Console.WriteLine("Enter number of max sequense:");
             string strg = Console.ReadLine();
             count = Convert.ToInt32(strg);
             Console.WriteLine(list.Max());
             Console.WriteLine(a.IndexOf(list.Max()));
             for (int i = 0; i < count; i++)
             {
                 a.Remove(a.IndexOf(list.Max() + i));
             }
             foreach (var item in a)
             {
                 Console.Write(item + " ");
             }*/
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();

            int index = 0, startLine = 0, startLineFin = 0, colvo = 1, colvoFin = 0;
            while (index < a.Count - 1)
            {
                for (int i = index; i < a.Count; i++)
                {
                    if (a[i] == a[i + 1])
                    {
                        startLine = index;
                        colvo += 1;
                    }
                    else
                    {
                        index = i + 1;
                        if (colvo > colvoFin)
                        {
                            colvoFin = colvo;
                            startLineFin = startLine;
                        }
                        colvo = 0;
                        break;
                    }
                }
            }
           /* foreach (int i in a)
            {
                if ( (startLineFin <= i) && (i <= colvo) )
                {
                    a.Remove(i);
                }
            }*/
            for (int i = startLineFin + colvoFin; i >= startLineFin; i--)
            {
                    a.RemoveAt(i);
            }
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
            /*int max = 0, index = 1;
            bool flag = false;
            List<int> longest = new List<int>();
            while (index < list.Count - 1)
            {
                List<int> current = new List<int>();
            
                for (int i = index; i < list.Count; i++)
                {
                   
                    if (list[i] % list[i - 1] == 0)
                    {
                        if (!flag)
                        {
                            current.Add(list[i - 1]);
                            flag = true;
                        }
                        current.Add(list[i]);
                    }
                        
                        
                    else
                    {
                        index = i + 1;
                        if (max < current.Count)
                        {
                            max = current.Count;
                            longest = current;
                        }
                        break;
                    }
                }
            }
            return longest;*/

            return a;
        }
    }
}
