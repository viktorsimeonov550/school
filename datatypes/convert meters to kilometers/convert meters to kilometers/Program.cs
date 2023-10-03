using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_meters_to_kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal n = num / 1000;

            Console.WriteLine(value: $"{n:f2}");
        }
    }
}
