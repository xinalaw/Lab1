using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._7
{
    internal class Program
    {
        static int[] Filling_an_array(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {

                array[i] = Convert.ToUInt16(Console.ReadLine());
            }
            return array;
        }
        static int[] DeleteAllSame(int[] array,int r)
        {
            int H = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != r)
                {
                    H++;
                }
            }
            int[] array2= new int[H];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != r)
                {
                    array2[j] = array[i];
                    j++;
                }
            }
            return array2;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[] numbers;
            int n = Convert.ToUInt16(Console.ReadLine());
            numbers = Filling_an_array(n);
            Console.WriteLine("Введите число от которого хотите избавиться");
            int r = Convert.ToUInt16(Console.ReadLine());
            int[] sortednumbers;
            sortednumbers = DeleteAllSame(numbers, r);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < sortednumbers.Length; i++)
            {
                Console.WriteLine(sortednumbers[i]);
            }
            Console.ReadKey();
        }
    }
}
