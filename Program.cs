using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beecrowd1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, r;

            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A=" + (pi * (r * r)).ToString("0.0000"));
        }
    }
}
