using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of array: ");

            //length
            int lengthoafrray = Convert.ToInt32(Console.ReadLine());

            //multply cells.
            Console.WriteLine("enter number to multiply: ");
            int numtomul = Convert.ToInt32(Console.ReadLine());

            //array
            int[] arr = new int[lengthoafrray];

            Console.WriteLine($"num of elemnts:{lengthoafrray}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * numtomul;
                Console.WriteLine(arr[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
