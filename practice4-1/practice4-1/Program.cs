using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4_1
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get { return head; }
        }

        public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
        
        public void ForEach(Action<T> action)
        {
            for(Node<T> t = this.head; t != null; t=t.Next)
            {
                action(t.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            // 逐个打印
            intlist.ForEach(m => Console.WriteLine(m));
            // 最大
            int max = int.MinValue;
            intlist.ForEach(m => { if (max < m) max = m; });
            Console.WriteLine($"最大值：{max}");
            // 最小
            int min = int.MaxValue;
            intlist.ForEach(m => { if (min > m) min = m; });
            Console.WriteLine($"最小值：{min}");
            // 总和
            int sum = 0;
            intlist.ForEach(m => { sum += m; });
            Console.WriteLine($"总和：{sum}");


            Console.ReadKey();
        }
    }
}

