using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine _machine;

        public CardPresentState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
            Console.WriteLine();
        }
       
        public void EnterPin(int pin)
        {
            Console.WriteLine("You have entered the correct pincode.");
            _machine.SetMachineState(_machine.GetCorrectPinState());
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
            Console.WriteLine();
        }
    }
}
