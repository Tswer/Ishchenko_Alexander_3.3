using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Arr = { "mama", "papa", "brat", "asd" };
            string s = "";
            var result = Arr.Aggregate(s, (x, y) => s+=y[0]);
            Console.WriteLine(result);
        }
    }
}
