using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class FouthTask
    {
        public List<int> Method(List<int> mas, List<int> num)
        {
            var list = new List<int>();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int i in mas)
            {
                if (i < num[0])
                    list.Add(i);
            }
            foreach (int i in list)
                Console.Write(i + " ");
            Console.ResetColor();
            list.Clear();
            list.Add(num[0]);
            foreach (int i in list)
                Console.Write(i + " ");
            list.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int i in mas)
            {
                if (i >= num[0])
                    list.Add(i);
            }
            foreach (int i in list)
                Console.Write(i + " ");
            return list;
        }
    }
}
