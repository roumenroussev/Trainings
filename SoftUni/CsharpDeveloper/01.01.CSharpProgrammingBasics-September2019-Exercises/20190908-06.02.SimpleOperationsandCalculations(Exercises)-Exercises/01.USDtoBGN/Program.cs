﻿using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usdRate = 1.79549;
            double bgn = usd * usdRate;
            Console.WriteLine($"{bgn:F2}");
        }
    }
}
