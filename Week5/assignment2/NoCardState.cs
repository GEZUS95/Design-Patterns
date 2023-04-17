using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        private ATMMachine _machine;

        public NoCardState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            _machine.SetMachineState(_machine.GetCardPresentState());
            Console.WriteLine();
        }

        public void EnterPin(int pin)
        {
            Console.WriteLine("You have entered the correct pincode");
            Console.WriteLine();
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            Console.WriteLine();
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("{0} withdrawn from machine.", amount);
        }
    }
}
