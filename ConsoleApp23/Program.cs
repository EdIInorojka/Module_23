﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            double num = Converter.StringToDouble(str);

            Console.WriteLine(num);
        }
    }
}
