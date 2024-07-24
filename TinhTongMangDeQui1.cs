using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMangDeQui
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            int sum = SumArray(arr, 0, n - 1);
            Console.WriteLine("Tong cua mang la: " + sum);
            Console.ReadLine();
        }
        static int SumArray(int[] arr, int left, int right)
        {
            if (left > right)
            {
                return 0;
            }
            if (left == right)
            {
                return arr[left];
            }
            int mid = (left + right) / 2;
            return SumArray(arr, left, mid) + SumArray(arr, mid + 1, right);
        }
    }
}
