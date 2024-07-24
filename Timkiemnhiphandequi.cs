using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhanDeQui
{
    class Program
    {
        public static int BinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (target < arr[mid])
                return BinarySearch(arr, target, left, mid - 1);
            else
                return BinarySearch(arr, target, mid + 1, right);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13 };
            int target = 8;
            int result = BinarySearch(arr, target, 0, arr.Length - 1);
            if (result != -1)
                Console.WriteLine("Phan tu {0} đuoc tim thay tai vi tri {1} trong mang.", target, result);
            else
                Console.WriteLine("Phan tu {0} khong ton tai trong mang.",target);
            Console.ReadLine();
        }
    }
}
