using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
            Console.ReadKey();
        }
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: { stack.Count}");
            }
        }
        void CheckValues(IStack stack)
        {
            Console.Write("\nEnter a number: ");
            int input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                if (stack.Contains(input))
                {
                    Console.WriteLine("stack contains value {0}", input);
                }
                else
                {
                    Console.WriteLine("stack does not contain value {0}", input);
                }

                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }
    }
}
