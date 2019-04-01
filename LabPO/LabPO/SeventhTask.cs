using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class SeventhTask
    {
        public string Method(int[] a)
        {
            int[] countArray = new int[9];
            foreach (int n in a)
                countArray[n - 1]++;
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("\nЦИФРА:  1   2   3   4   5   6   7   8   9" +
                "\n        |   |   |   |   |   |   |   |   |"
                + "\nКОЛВО:  " + string.Join("   ", countArray));
            return string.Join(" ", countArray);

        }
    }
}
