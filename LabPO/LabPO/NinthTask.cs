﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPO
{
    public class NinthTask
    {
        public int[,] Method(int[,] a)
        {
            // find the maximum element
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

            Console.WriteLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == maxX)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,4}", a[i, j]);
                        Console.ResetColor();
                    }
                    else
                        Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] stroka = new int[a.GetLength(1)];
            for (int i = 0; i < stroka.Length; i++)
            {
                stroka[i] = a[maxX, i];
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(stroka[i]);
                Console.ResetColor();
            }
            Console.WriteLine();

            int[,] creat = new int[a.GetLength(0), a.GetLength(1)];
            int x = int.MinValue;
            int m = 0;
            int findj = 0;//считает столбец с наименьшими элементами
            while (m < creat.GetLength(1))
            {
                for (int i = 0; i < stroka.GetLength(0); i++)
                {
                    if (x < stroka[i])
                    {
                        x = stroka[i];
                        findj = i;
                    }
                }
                x = int.MinValue;
                for (int k = findj; k < findj + 1; k++)//сохраняем в начале столбец с наименьшим членов
                {
                    for (int z = 0; z < creat.GetLength(0); z++)
                    {
                        creat[z, m] = a[z, findj];
                        stroka[findj] = int.MinValue;//присваивание максимального значения элементу,чтобы при повторной итерации н было такого же столбцы
                    }
                }

                m++;
            }


        int[,] resultMatrix = new int[2, 2];

            for (int i = 0; i < creat.GetLength(0); i++)
            {
                for (int j = 0; j < creat.GetLength(1); j++)
                {
                    if (i == maxX)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,4}", creat[i, j]);
                        Console.ResetColor();
                    }
                    else
                        Console.Write("{0,4}", creat[i, j]);
                }
                Console.WriteLine();
            }
            return creat;
        }
    }
}
