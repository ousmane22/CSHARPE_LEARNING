using System;

namespace WiredBrainCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackSimple();
            stack.Push(1.3);
            stack.Push(2.9);
            stack.Push(20.2);

            double sum = 0;

            while(stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"item: {item}");
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }

    
}
