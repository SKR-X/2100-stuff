//2.13

using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxi = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >=1 )
            {

                double[] mas213 = new double[n];

                Console.WriteLine("2.13 Введите элементы массива:");

                for (int i = 0;  i < mas213.Length;  i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas213[i] = inp;
                }

                for (int i = 0; i < mas213.Length; i++)
                {
                    if (mas213[i] > max && i%2==0)
                    {
                        max = mas213[i];
                        maxi = i;
                    }
                }

                Console.WriteLine("2.13 Измененный массив:");

                Console.WriteLine(max);
                
                mas213[maxi] = maxi;

                for (int i = 0; i < mas213.Length; i++)
                {
                    Console.WriteLine(mas213[i]);
                }
            }
            


        }
    }
}


//2.15

using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, maxi = 0, i = 0, k = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.15 Введите размер массива A:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] masA = new double[n];

                Console.WriteLine("2.15 Введите элементы массива A:");

                for (i = 0; i < masA.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    masA[i] = inp;
                }

                Console.WriteLine("2.15 Введите размер массива B:");

                if (Int32.TryParse(Console.ReadLine(), out m) && m >= 1)
                {
                    double[] masB = new double[m];

                    Console.WriteLine("2.15 Введите элементы массива B:");

                    for (i = 0; i < masB.Length; i++)
                    {
                        Double.TryParse(Console.ReadLine(), out inp);
                        masB[i] = inp;
                    }

                    List<double> listAB = new List<double>();

                    Console.WriteLine("2.15 Введите K:");

                    if (Int32.TryParse(Console.ReadLine(), out k) && k >= 1)
                    {
                        for (i = 0; i < k; i++)
                        {
                            listAB.Add(masA[i]);
                        }

                        for (i = 0; i < masB.Length; i++)
                        {
                            listAB.Add(masB[i]);
                        }

                        for (i = k; i < masA.Length; i++)
                        {
                            listAB.Add(masA[i]);
                        }
                    }

                    Console.WriteLine("2.15 Измененный массив:");

                    for (i = 0; i < listAB.Count; i++)
                    {
                        Console.WriteLine(listAB[i]);
                    }
                }

            }



        }
    }
}

//3.1

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxi = 0, i = 0, c = 0, maxc = 0, inc = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] mas = new double[n];
                List<double> list = new List<double>();
                List<int> listi = new List<int>();

                Console.WriteLine("2.13 Введите элементы массива:");

                for (i = 0; i < mas.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas[i] = inp;
                }

                for (i = 0; i < mas.Length; i++)
                {
                    if (mas[i]>=max)
                    {
                        max = mas[i];
                        list.Add(mas[i]);
                        listi.Add(i);
                    }
                }

                for (i = 0; i < list.Count-1; i++)
                {
                    c = 0;
                    for (int j = i; j < list.Count; j++)
                    {
                        if(list[i] == list[j])
                        {
                            c++;
                        }
                    }
                    if (c > maxc)
                    {
                        maxc = c;
                        max = list[i];
                    }
                }

                int[] masmax = new int[maxc];

                for (i = 0; i < list.Count; i++)
                {
                    if (list[i] == max)
                    {
                        masmax[inc] = listi[i];
                        inc++;
                    }
                }

                Console.WriteLine("3.1 Массив индексов:");

                for (i = 0; i < maxc; i++)
                {
                    Console.WriteLine(masmax[i]);
                }
            }
        }
    }
}



