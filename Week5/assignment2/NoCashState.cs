using System;

namespace assignment2
{
    public class NoCashState : IATMState
    {
        private ATMMachine _machine;

        public NoCashState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            Console.WriteLine();
        }

        public void EnterPin(int pin)
        {
            Console.WriteLine("You have entered the correct pincode.");
            Console.WriteLine();
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            _machine.SetMachineState(_machine.GetNoCardState());
            Console.WriteLine();
        }
        
        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Not enough cash available in machine.");
            Console.WriteLine();
        }
    }
}
