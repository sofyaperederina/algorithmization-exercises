﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class задача_3

    {
        static void Main(string[] args)
        {
            /*Необходимо перевернуть число, удалив нечетные числа. 0 или отр. число - признак окончания последовательности*/
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                bool evenHere = false;
                int newNumber = 0;
                while (a != 0)
                {
                    int lastDidgit = a % 10;
                    if ((lastDidgit % 2) == 0)
                    {
                        newNumber = newNumber * 10 + lastDidgit;
                        evenHere = true;

                    }
                    a /= 10;
                }
                if (evenHere) Console.WriteLine(newNumber);
                else Console.WriteLine("Среди введённых чисел нет чётных");
                a = int.Parse(Console.ReadLine());
            }

        }
    }
}