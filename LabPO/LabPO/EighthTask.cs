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
            //вывод матрицы
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(j == minY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,4}", a[i, j]);
                        Console.ResetColor();
                    }
                   else
                    {
                        if(j == maxX)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,4}", a[i, j]);
                            Console.ResetColor();
                        }
                        else
                            Console.Write("{0,4}", a[i, j]);
                    }
                    //Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // создаем новый массив в котором сохраняем разнизцу: 
            // минСтолбец - максСтолбец
            int[,] stolb = new int[a.GetLength(0), 1];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                stolb[i, 0] = a[i, minY] - a[i, maxY];
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(stolb[i, 0]);
                Console.ResetColor();
            }
            // считаем колво столбцов, в которых есть четный отрицательный
            // элемент и сохраняем в новом массиве 1 или 0
            // 1 - есть отрицательный, 0 - нет отрицательного
            int colvoOtric = 0, colvo = 0; //otrik = 0;
            int[] chetOtric = new int[a.GetLength(1)];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if ((a[i, j] < 0) && (a[i, j] % 2 == 0))
                    {
                        colvo++; 
                    }
                        
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

            int[] stolbBlue = new int[resultMatrix.GetLength(1)];
            var prove = 0;
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    if (resultMatrix[i, j] == stolb[i, 0])
                        prove++;
                }
                if (prove == resultMatrix.GetLength(0))
                    stolbBlue[j] = 1;
                else
                    stolbBlue[j] = 0;
                prove = 0;
                //Console.WriteLine();
            }
            //Console.WriteLine();

            int otrik = 0;
            int[,] Otric = new int[2, resultMatrix.GetLength(1)];
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    if ((resultMatrix[i, j] < 0) && (resultMatrix[i, j] % 2 == 0))
                    {
                        colvo++; otrik = resultMatrix[i, j];
                    }

                }
                if (colvo > 0)
                {
                    Otric[0, j] = 1;
                    Otric[1, j] = otrik;
                    colvoOtric++;
                }
                else
                    Otric[0, j] = 0;
                colvo = 0;
            }

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    if (stolbBlue[j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,4}", resultMatrix[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        if (resultMatrix[i, j] == Otric[1, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,4}", resultMatrix[i, j]);
                            Console.ResetColor();
                        }
                        else
                            Console.Write("{0,4}", resultMatrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return resultMatrix;
        }
    }
}
