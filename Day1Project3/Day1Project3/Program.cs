﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a ==b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
