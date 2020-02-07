using System;
using System.IO;
using System.Linq;

namespace Lab3_OOD_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            //Linq Query
            //var ouptut = from number in numbers
            //             where number > 5
            //             orderby number descending
            //             select number;

            var output = numbers
                .Where(num => num > 5)
                .OrderByDescending(n => n);

            foreach (int number  in output)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
