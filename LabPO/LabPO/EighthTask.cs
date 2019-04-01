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
            // находим минимальный элемент и сохраняем его коорды
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
            // находим максимальный элемент и сохраняем его коорды
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
            // создаем новый массив в котором сохраняем разнизцу: 
            // минСтолбец - максСтолбец
            int[,] stolb = new int[a.GetLength(0), 1];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                stolb[i, 0] = a[i, minY] - a[i, maxY];
                Console.WriteLine(stolb[i, 0]);
            }

            // считаем колво столбцов, в которых есть четный отрицательный
            // элемент и сохраняем в новом массиве 1 или 0
            // 1 - есть отрицательный, 0 - нет отрицательного
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
            // это я для проверки правильности выполнения кода выводил
           /* foreach(int arrr in chetOtric)
            {
                Console.WriteLine(chetOtric[arrr]);
            }*/

            // создали новую матрицу с увеличенным колвом столбцов
            // и теперь тупо переписываем значения в новую матрицу
            // если в элементе массива, который хранит 0 и 1, единица, то записываем в массив 
            // столбец из начальной матрицы и столбец разницы
            // иначе только столбец из начальной матрицы
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
