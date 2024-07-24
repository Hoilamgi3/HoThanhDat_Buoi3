using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhanKhongDeQui
{
    class Program
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13 };
        int target = 11;
        int result = BinarySearch(arr, target);
        if (result != -1)
            Console.WriteLine("Phan tu {0} đuoc tim thay tai vi tri {1} trong mang",target,result);
        else
            Console.WriteLine("Phan tu {0} khong ton tai trong mang." ,target);
        Console.ReadLine();
        }
    }
}
