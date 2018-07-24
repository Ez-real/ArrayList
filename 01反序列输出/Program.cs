using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01反序列输出
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "a","b","c","d","e","f"};
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}

            //反序列输出函数 Array.Reverse();
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                Console.WriteLine("hello");
            }
            Console.ReadKey();          
        }
    }
}
