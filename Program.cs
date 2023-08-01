using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBinarySearch
{
    internal class Program
    {
        public static int BinarySearch(int[] arr,int Sitem)
        {
            int left = 0;
            int right=arr.Length-1;
            while (left <= right)
            {
                int mid=left+(right-left)/2;
                if (arr[mid] == Sitem)
                {
                    return mid;
                }
                else if (arr[mid] < Sitem)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20, 25, 30,35 };
            Console.WriteLine("Enter Item to Search Using Binary Search");
            int Sitem = int.Parse(Console.ReadLine());
            int result=BinarySearch(arr, Sitem);
            if (result != -1)
            {
                Console.WriteLine($"{Sitem} Found at Index {result}");
            }
            else
            {
                Console.WriteLine("No Such item {Sitem} exist in Array");
            }
            Console.ReadKey();


        }
    }
}
