using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._8
{

    internal class Program
    {
        static int[] Filling_an_array(int n)
        {
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                
                array[i] = rnd.Next();
            }
            return array;
        }
        static int[] SortbyChoosing(int[] mas)
        {

            for (int i = 0; i < 67; i=i+2)
            {
                
                int min = i;
                for (int j = i + 2; j < 69; j=j+2)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n = 70;
            int[] numbers;
            numbers = Filling_an_array(n);
            numbers = SortbyChoosing(numbers);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
