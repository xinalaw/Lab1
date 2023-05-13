using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Laba1._4
{
    internal class Program
    {

        static double[] Filling_an_array(int n)
        {
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {

                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return array;
        }
        static double[] Filling_an_array_with_functions(double[] array)
        {
            double[] igriki= new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                    if (array[i] < -3)
                    {
                        igriki[i] = (1 + array[i]) / Convert.ToDouble(2 * array[i]);
                    }
                    else if (array[i] <= (Math.PI / 4))
                    {
                        igriki[i] = (Math.Pow(Convert.ToDouble(array[i]), 2) - 3) * Math.Sin(Convert.ToDouble(array[i]));
                    }
                    else
                    {
                        igriki[i] = 7 / 3.0;
                    }
            }
            return igriki;
        }
        
        static void Opredelenie(double[] X, double[] Y)
        {
            int d = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] >= 0 && Y[i] >= 0)
                {
                    double x1 = 0, y1 = 4,x2 = 2, y2 = 0, x3 = 0, y3 = 0,x0 = X[i],y0= Y[i], first, second,third;
                    first= (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
                    second = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
                    third = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);
                    if((first >=0 && second >=0 && third>=0)||(first <= 0 && second <= 0 && third <= 0))
                    {
                        d++;
                    }
                }
                else if(X[i] > 0 && X[i] <= 2 && Y[i] < 0 && Y[i] >= -4)
                {
                    d++;
                }
                else if(X[i] < 0 && Y[i] < 0)
                {
                    double x1 = 0, y1 = -4, x2 = -4, y2 = 0, x3 = 0, y3 = 0, x0 = X[i], y0 = Y[i], first, second, third;
                    first = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
                    second = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
                    third = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);
                    if ((first >= 0 && second >= 0 && third >= 0) || (first <= 0 && second <= 0 && third <= 0))
                    {
                        d++;
                    }


                }
                else if (X[i] < 0 && Y[i] > 0)
                {
                    if(X[i] * X[i] + Y[i] * Y[i] <= 16)
                    {
                        d++;
                    }
                }
            }
            Console.WriteLine($"Всего точек попадающих в заштрихованную зону {d}.");
        }



        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Cколько будет чисел?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа x:");
            double[] numbers;
            numbers = Filling_an_array(n);
            double[] functions;
            functions = Filling_an_array_with_functions(numbers);
            Console.WriteLine("Вот точки, которые у нас получились:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]+" " + functions[i]+"\n");
            }
            Opredelenie(numbers,functions);
            Console.ReadKey();


        }
    }
}
