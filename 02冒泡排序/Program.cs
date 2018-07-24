using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //排序是将一个数组中的元素按从小到大或从大到小的顺序进行排列
            //冒泡排序法是第i次将第一个元素依次跟以后n-i个元素进行比较，并按大小进行交换顺序
            int[] arr = {1,2,3,4,5,6,7,8,9,0};
            //for (int i = 1; i < arr.Length; i++)
            //{

            //    for (int j = 1; j <= arr.Length - i; j++)
            //    {
            //        if (arr[j-1] > arr[j])// <号就是降序
            //        {
            //            int temp;
            //            temp = arr[j-1];
            //            arr[j-1] = arr[j ];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //升序排列函数Array.Sort();
            Array.Sort(arr);

            //如果想要降序输出，调用升序函数后，再调用反序函数即可

            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            
            Console.ReadKey();

        }
    }
}
