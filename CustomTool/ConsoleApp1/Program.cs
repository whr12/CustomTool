using System;
using Tool.ExternContainer;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap1 = new MinHeap<int>();
            heap1.Push(1);
            heap1.Push(8);
            heap1.Push(4);
            heap1.Push(6);
            heap1.Push(3);
            Console.WriteLine("Minheap:");
            while (heap1.Count > 0)
            {
                int value = heap1.GetHeap();
                Console.WriteLine(value);
                heap1.Pop();
            }

            Heap<int> heap2 = new MaxHeap<int>();
            heap2.Push(3);
            heap2.Push(4);
            heap2.Push(2);
            heap2.Push(1);
            Console.WriteLine("Maxheap:");
            while (heap2.Count > 0)
            {
                int value = heap2.GetHeap();
                Console.WriteLine(value);
                heap2.Pop();
            }
        }
    }
}
