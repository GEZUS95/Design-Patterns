using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
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
            ATMMachine machine = new ATMMachine(2000);

            Console.Write("Please enter your command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            Console.ResetColor();
            while(input != "stop")
            {
                switch (input)
                {
                    case "insert card": machine.InsertCard(); break;
                    case "reject card": machine.RejectCard() ; break;
                    case "enter pincode":
                        Console.Write("Please enter your pincode: ");
                        int pincode = int.Parse(Console.ReadLine());
                        machine.EnterPincode(pincode) ; break;
                    case "withdraw cash":
                        Console.Write("Please enter amount of cash: ");
                        int amount = int.Parse(Console.ReadLine());
                        machine.WithdrawCash(amount); ; break;
                    default:
                        Console.WriteLine("entered unkown command \n");
                        break;
                }

                Console.Write("Please enter your command: ");
                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();
                Console.ResetColor();
            }
        }
    }
}
