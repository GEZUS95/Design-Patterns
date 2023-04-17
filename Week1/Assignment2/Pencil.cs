using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;

        public bool CanWrite { get {return nrOfCharsWritten < maxToWrite ; } }

        public Pencil(int max)
        {
            maxToWrite = max;
        }

        public void Write(string message)
        {
            foreach(char c in message)
            {
                if (!CanWrite) { Console.Write("#"); }
                else { Console.Write(c); nrOfCharsWritten++; }
            }
            Console.Write("\n");
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }
    }
}
