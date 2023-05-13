using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите дату рождения в столбик: сначала день, месяц, потом год.");
            int day = Convert.ToInt32(Console.ReadLine());
            int mounth = Convert.ToInt32(Console.ReadLine());
            int year  = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime d1 = new DateTime(year, mounth, day);
            Console.WriteLine(d1);
            TimeSpan inter = now.Subtract(d1);
            Console.WriteLine($"Вы прожили более или менее примерно или ровно или чуть больше или чуть меньше, но в общих словах где-то плюс минус  {(inter.Days)/ 365} лет!");
            Console.ReadKey();
           
        }
    }
}
