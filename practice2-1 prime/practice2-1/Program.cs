using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_1
{
    class Program
    {
        static int get_input()
        {
            int num = 0;
            Console.WriteLine("请输入一个大于1的正整数：");
            bool right = Int32.TryParse(Console.ReadLine(),out num);
            if (!right || num <= 1)
            {
                Console.WriteLine("请输入大于1的正整数！");
                return get_input();
            }
            return num;
        }
        static void output_result(int num)
        {
            Console.WriteLine("该数的素数因子包括：");
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    do
                    {
                        num /= i;
                    } while (num % i == 0);
                }
            }
        }
        static void Main(string[] args)
        {
            int num = get_input();
            output_result(num);
            Console.ReadKey();
        }
    }
}
