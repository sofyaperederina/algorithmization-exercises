﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Задача_3
    {
        
        
        
        static void Main(string[] args)
        {

            int max_n = int.Parse(Console.ReadLine());
            ulong ans = 0;
            for (int z = 1; z < ((int)Math.Log(max_n) / Math.Log(2) + 2); z++)
            {
                int d = (int)(Math.Pow(2, z) - 1);
                ans += (ulong)(max_n / d);
            }
            Console.WriteLine(ans);
        }
    }
}
