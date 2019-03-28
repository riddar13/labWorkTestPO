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
            foreach (int i in mas)
            {
                if (i < num[0])
                    list.Add(i);
            }
            list.Add(num[0]);
            foreach (int i in mas)
            {
                if (i > num[0])
                    list.Add(i);
            }
            foreach (int i in list)
                Console.Write(i + " ");
            return list;
        }
    }
}
