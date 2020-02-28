using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_2
{
    class Program
    {
        static int int_array_max(int [] num)
        {
            int max = num[0];
            foreach(int i in num)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        static int int_array_min(int [] num)
        {
            int min = num[0];
            foreach (int i in num)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            Console.WriteLine("最大值：" + int_array_max(num));
            Console.WriteLine("最小值：" + int_array_min(num));
            Console.WriteLine("平均值：" + (float)num.Sum() / num.Length);
            Console.WriteLine("总和：" + num.Sum());
            Console.ReadKey();
        }
    }
}
