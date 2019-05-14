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

           // foreach (int i in a)
          //      Console.Write(i + " ");
          //  Console.WriteLine();

            int index = 0, startLine = 0, startLineFin = 0, colvo = 0, colvoFin = 0;
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
                        startLine = 0;
                        break;
                    }
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                if ( (i >= startLineFin) && (i <= (startLineFin + colvoFin)))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(a[i] + " ");
                    Console.ResetColor();
                }
                else
                    Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = startLineFin + colvoFin; i >= startLineFin; i--)
            {
                    a.RemoveAt(i);
            }
           
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();

            return a;
        }
    }
}
