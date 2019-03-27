using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class SecondTask
    {
        public string Method(string n)
        {
            n = string.Join(" ", n.Split(new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries).Reverse());
            return n;
        }
    }
}
