using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void show_error_and_end(String info)
        {
            Console.WriteLine(info);
            Console.ReadKey();
            Environment.Exit(1);
        }
        static double get_num_from_console()
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Data);
                show_error_and_end("输入错误！");
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            double num1 = get_num_from_console();
            Console.WriteLine("请输入第二个数：");
            double num2 = get_num_from_console();
            Console.WriteLine("请输入运算符：+ - * /");
            double result = 0;
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        show_error_and_end("输入错误！除数不可为0！");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    show_error_and_end("请输入正确的运算符！");
                    break;
            }
            Console.WriteLine("运算结果结果是：" + result);
            Console.ReadKey();
        }
    }
}
