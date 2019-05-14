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
        public bool IsCyrillic(char c)
        {
            if (('А' <= c && c <= 'Я') || ('а' <= c && c <= 'я') || (192 <= c && c <= 255) || c == 'ё' || c == 'Ё' || c == ' ')
                return true;
            return false;
        }
    }
}
