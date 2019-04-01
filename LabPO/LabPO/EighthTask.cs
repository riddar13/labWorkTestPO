using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class EighthTask
    {
        public int[,] Method(int[,] a)
        {
            int minElement = a[0, 0] , minX = 0, minY = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (minElement > a[i, j])
                    {
                        minElement = a[i, j];
                        minX = i;
                        minY = j;
                    }
                }
            }

            int maxElement = a[0, 0], maxX = 0, maxY = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (maxElement < a[i, j])
                    {
                        maxElement = a[i, j];
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            int[,] stolb = new int[a.GetLength(0), 1];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                stolb[i, 0] = a[i, minY] - a[i, maxY];
                Console.WriteLine(stolb[i, 0]);
            }

            int colvoOtric = 0, colvo = 0;
            int[] chetOtric = new int[a.GetLength(1)];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if ((a[i, j] < 0) && (a[i, j] % 2 == 0))
                        colvo++;
                }
                if (colvo > 0)
                {
                    chetOtric[j] = 1;
                    colvoOtric++;
                }
                else
                    chetOtric[j] = 0;
                colvo = 0;
            }
            Console.WriteLine();
           /* foreach(int arrr in chetOtric)
            {
                Console.WriteLine(chetOtric[arrr]);
            }*/

            int[,] resultMatrix = new int[a.GetLength(0),a.GetLength(1) + colvoOtric];
            int schet = 0;
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                if (chetOtric[schet] == 1)
                {
                    for (int i = 0; i < resultMatrix.GetLength(0); i++)
                    {
                        resultMatrix[i, j] = a[i, schet];
                    }
                    for (int i = 0; i < resultMatrix.GetLength(0); i++)
                    {
                        resultMatrix[i, j+1] = stolb[i, 0];
                    }
                    schet++;
                    if (schet > a.GetLength(1))
                        schet--;
                    j++;
                }
                else
                {
                    for (int i = 0; i < resultMatrix.GetLength(0); i++)
                    {
                        resultMatrix[i, j] = a[i, schet];
                    }
                    schet++;
                    if (schet > a.GetLength(1))
                        schet--;
                }
            }

            return resultMatrix;
        }
    }
}
