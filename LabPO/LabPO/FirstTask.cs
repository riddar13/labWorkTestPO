using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
   public class FirstTask
    {
        public int Method(int n)
        {
            if (n < 0 || n > 100)
            {
                Console.WriteLine("wrong n");
                return 0;
            }
            else
            {
                var result = 1;
                for (int i = 2; i <= n; i++)
                    result = result * i;
                return result * 2;
            }
        }
    }
}
