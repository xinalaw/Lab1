using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            const double charka = 0.123;
            const double shkalik = 0.06;
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            Console.WriteLine("Введите последовательно величины: x,y,z,w.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            double [] Volumes = new double[3];
            Volumes[0] = x * charka;
            Volumes[1] = y * shkalik;
            Volumes[2] = z * charka + w * shkalik;
            string s2 = "";
            if (Volumes[0] > 0.5 && Volumes[0]<1)
            {
                s2 = s2 + name1 + " ";
            }
            if (Volumes[1] > 0.5 && Volumes[1] < 1)
            {
                s2 = s2 + name2 + " ";
            }
            if (Volumes[2] > 0.5 && Volumes[2] < 1)
            {
                s2 = s2 + name3 + " ";
            }

            Console.WriteLine($"A) {name1} выпил ровно {Volumes[0]}.\n {name2} выпил ровно {Volumes[1]}. \n {name3} выпил ровно {Volumes[2]}.");
            Console.WriteLine($"B) Имена тех, кто выпил больше 0,5 и меньше 1 литра:\n {s2}");
            Console.WriteLine($"C) Всего было выпито: {Volumes[2]+ Volumes[1]+ Volumes[0]}");
            Console.WriteLine($"D) Наибольший из выпитых объемов: {Volumes.Max()}");
            Console.ReadKey();






        }
    }
}
