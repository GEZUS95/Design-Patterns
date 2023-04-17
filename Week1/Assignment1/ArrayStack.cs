using System;
using System.Linq;

namespace Assignment1
{
    class ArrayStack : IStack
    {
        public int Count { get { return iterator + 1; } }

        public bool IsEmpty { get { return iterator == -1; } }

        private int[] arrayStack;
        private int iterator = -1;
        private int arraySize { get; set; }

        public ArrayStack(int size)
        {
            arrayStack = new int[size];

        }

        public bool Contains(int value)
        {
            return arrayStack.Contains(value);
        }

        public int Pop()
        {
            if (!IsEmpty)
            {
                int popedVal = arrayStack[iterator];
                iterator--;
                return popedVal;
            }
            else
            {
                throw new Exception("Stack empty!");
            }
        }

        public void Push(int value)
        {
            if (iterator + 1 == arraySize)
            {
                Array.Resize(ref arrayStack, arrayStack.Length + 1);
            }
            if (iterator + 1 == arrayStack.Length)
            {
                throw new Exception("Stack Full!");
            }

            iterator++;
            arrayStack[iterator] = value;
        }
    }
}
