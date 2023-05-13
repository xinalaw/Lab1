using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            age = age + 1;

            Console.WriteLine($"Привет, {name}, через год тебе будет {age}.");
            Console.ReadKey();
        }
    }
}
