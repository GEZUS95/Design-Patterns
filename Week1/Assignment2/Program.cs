using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
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
            IPencil pencil = new Pencil(20);
            IPencilSharpener sharpener = new PencilSharpener();

            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            while (input != "stop")
            {
                if (input == "sharpen")
                {
                    sharpener.Sharpen(pencil);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("sharpening the pencil...");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    pencil.Write(input);
                }
                Console.ResetColor();
                Console.Write("Enter a word: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("end of program...");
            Console.ReadKey();
        }
    }
}
