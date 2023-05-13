using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n = Convert.ToInt32(Console.ReadLine());
            int d,r=1;
            for (int i = 3; i <= n; i++) 
            {
                d = 0;
                for(int m = 2; m < i; m++)
                {
                    if (i % m == 0)
                    {
                        m = i;
                        d = 1;
                    }
                     
                }
                if (d == 0)
                {
                    r++;
                }
               
            }
            Console.WriteLine(r);
            Console.ReadKey();

        }
    }
}
