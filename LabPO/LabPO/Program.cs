using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while (true)
            {
                Console.WriteLine("Number of task (1-10) or 'q' to exit:");
                var num = Console.ReadLine();
                string result;
                Console.Clear();

                switch (num)
                {
                    case "1":
                        FirstTask Task = new FirstTask();

                        Console.WriteLine("------1st task------\n" +
                            "Вывести на экран число 2n!, n<=100, n - натуральное.\nEnter n (0-100):");

                        var st = Console.ReadLine();
                        int n;

                        if (Int32.TryParse(st, out n))
                        {
                            var result1 = Task.Method(n);
                            Console.WriteLine("2n! = " + result1);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();

                        break;

                    case "2":
                        Console.WriteLine("------2nd task------\n" +
                            "Дана строка, состоящая из слов, разделенных пробелами" +
                            "(одним или несколькими).Вывести строку, содержащую эти же слова" +
                            "(разделенные одним пробелом), но расположенные в обратном порядке. \nEnter string:");

                        SecondTask TaskSecond = new SecondTask();
                        st = Console.ReadLine();
                        result = TaskSecond.Method(st);
                        Console.WriteLine("Result: {0}", result);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("------3rd task------\n" +
                            "В заданной последовательности целых чисел найти максимально длинную " +
                            "подпоследовательность чисел такую, что каждый последующий элемент " +
                            "подпоследовательности делился нацело на предыдущий. ");

                        ThirdTask TaskThree = new ThirdTask();

                        //List<int> list = Enumerable.Range(0, 10).Select(q => r.Next(1, 10)).ToList();
                        var list = new List<int>();
                        for (int i = 0; i < 10; i++)
                        {
                            var str = Console.ReadLine();
                            if (Int32.TryParse(str, out n))
                            {
                                n = Int32.Parse(str);
                                if ((n == 0) || (n<0))
                                {
                                    Console.WriteLine("Некорректный ввод");
                                }
                                else
                                    list.Add(n);
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод");
                            }
                        }
                        foreach (int i in list)
                            Console.Write(i + " ");
                        Console.WriteLine();

                        foreach (int i in TaskThree.Procedure(list))
                               Console.Write(i + " ");
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("------4th task------\n" +
                            "Дан массив a[1..n] и число b. Переставить числа в массиве таким образом, " +
                            "чтобы слева от некоторой границы стояли числа, меньшие или равные b, " +
                            "а справа от границы - большие или равные b. ");
                        FouthTask TaskF = new FouthTask();

                        //int[] arr = new[] { 1, 9, 4, 3, 6, 7, 2, 5, 8, 0 };
                        var spis = new List<int>()
                        {
                            1,
                            9,
                            4,
                            3,
                            6,
                            7,
                            2,
                            5,
                            8,
                            0
                        };
                        foreach (int i in spis)
                            Console.Write(i + " ");
                        Console.Write("\n");
                        
                        st = Console.ReadLine();
                        int y = Convert.ToInt32(st);
                        var numCent = new List<int>()
                        {
                            y
                        };
                        
                        TaskF.Method(spis, numCent);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("------5th task------\n" +
                            "Вставить в массив максимальный элемент после каждого участка, " +
                            "на котором его элементы образуют возрастающую последовательность.");
                        FifthTask TaskFive = new FifthTask();
                        list = Enumerable.Range(0, 10).Select(q => r.Next(1, 10)).ToList();
                
                        TaskFive.Method(list);


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("------6th task------\n" +
                            "Дан целочисленный массив размера N. " +
                            "Назовем серией группу подряд идущих одинаковых элементов, " +
                            "а длиной серии — количество этих элементов(длина серии может быть равна 1). " +
                            "Удалить из массива самую длинную серию.");
                        SixthTask sixthTask = new SixthTask();
                        List<int> listSix;
                        string strg = Console.ReadLine();
                        int range = Convert.ToInt32(strg);
        
                        listSix = Enumerable.Range(0, range).Select(q => r.Next(1, 10)).ToList();
                        sixthTask.Method(listSix);


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("------7th task------\n" +
                            "Найти количество цифр в массиве и определить, какая из них сколько " +
                            "встречается.");
                        SeventhTask seventhTask = new SeventhTask();

                        //int[] arrey = { 1, 4, 3, 5, 4, 7, 6, 5, 4, 5, 3, 1, 8, 9, 8, 4 };
                        int[] array = new int[10];
                        Random rand = new Random();
                        for (int i = 0; i < array.Length; i++)
                            array[i] = rand.Next(1, 10); // [0 - 2^31)


                        seventhTask.Method(array);


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("------8th task------\n" +
                            "Добавить столбец, содержащий разницу между столбцами с " +
                            "минимальным и максимальным элементом после каждого столбца с " +
                            "четным отрицательным элементом. ");
                        EighthTask eiTask = new EighthTask();
                        int[,] a = new int[4, 4];

                        Random random = new Random();
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                a[i, j] = random.Next(-9,10);
                                Console.Write("{0,4}", a[i, j]);
                            }
                            Console.WriteLine();
                        }
                        var resultEig = eiTask.Method(a);
                        for (int i = 0; i < resultEig.GetLength(0); i++)
                        {
                            for (int j = 0; j < resultEig.GetLength(1); j++)
                                Console.Write("{0,4}", resultEig[i, j]);
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "9":
                        Console.WriteLine("------9th task------\n" +
                            "Отсортировать по убыванию столбцы матрицы по строке, " +
                            "содержащей максимальный элемент матрицы. ");

                        NinthTask nineTask = new NinthTask();
                        int[,] mat = new int[4, 4];

                        random = new Random();
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                mat[i, j] = random.Next(-9, 10);
                                Console.Write("{0,4}", mat[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        var resultMatrix = nineTask.Method(mat);
                        for (int i = 0; i < resultMatrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < resultMatrix.GetLength(1); j++)
                                Console.Write("{0,4}", resultMatrix[i, j]);
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "10":
                        Console.WriteLine("------10th task------\n" +
                            "В данном разделе предполагаются задачи вида: взять любую " +
                            "программу из написанных ранее и переделать ее таким образом, чтобы " +
                            "входные данные считывались из одного файла, а результат решения " +
                            "выводился в другой.\n");

                        FirstTask First = new FirstTask();
                        if (File.Exists("input.txt"))
                        {
                            Console.WriteLine("File exists...");
                            var textInFile = File.ReadAllText("input.txt");

                            if (Int32.TryParse(textInFile, out n))
                            {
                                Console.WriteLine("n = " + n);
                                var result1 = First.Method(n);
                                Console.WriteLine("2n! = " + result1);
                                string text = result1.ToString();
                                File.WriteAllText("output.txt", text);
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод");
                            }                           
                        }
                        else
                            Console.WriteLine("File not found.");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case "q":
                        return;

                    default:
                        break;
                }

                Console.Clear();
            }
        }
    }
}
