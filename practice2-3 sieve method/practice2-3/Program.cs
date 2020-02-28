using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_3
{
    class Program
    {
        const int MAX = 101;
        static void ScanPrime(bool[] primeFlag)
        {
            for (int i = 2; i < (int)Math.Sqrt(MAX); i++)
            {
                for (int j = i * 2; j < MAX; j += i)
                {
                    primeFlag[j] = true;
                }
            }
        }

        static void OutputPrime(bool[] primeFlag)
        {
            Console.WriteLine("素数包括：");
            for(int i = 2; i < MAX; i++)
            {
                if (!primeFlag[i])
                {
                    Console.WriteLine("{0} ",i);
                }
            }
        }

        static void Main(string[] args)
        {
            bool[] primeFlag = new bool[MAX];
            ScanPrime(primeFlag);
            OutputPrime(primeFlag);
            Console.ReadKey();
        }
    }
}
