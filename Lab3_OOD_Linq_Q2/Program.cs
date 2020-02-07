using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_OOD_Linq_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuerySyntax();


        }

        private static void QuerySyntax()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            foreach (var item in query)
            {
                //Console.WriteLine($"{item.Name} - {item.Length}");
                Console.WriteLine(item);
            }
        }


        private static void LambdaSyntax()
        {

        }

        public class MyFileInfo
        {
            public string Name { get; set; }
            public long Length { get; set; }
            public DateTime CreationTime { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Length} - {CreationTime.ToShortDateString()}";
            }
        }
    }
}



