using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class ThirdTask
    {
        public List<int> Procedure(List<int> list)
        {
            int max = 0, index = 1;
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
            return longest;
        }
    }
}
