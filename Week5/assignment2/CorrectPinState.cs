using System;

namespace assignment2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine _machine;
        public CorrectPinState(ATMMachine machine)
        {
            _machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            Console.WriteLine();
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            Console.WriteLine();
        }
        public void EnterPin(int pin)
        {
            Console.WriteLine("You have entered the correct pincode.");
            Console.WriteLine();
        }
        public void WithdrawCash(int amount)
        {
            _machine.AmmountInMachine -= amount;
            if (_machine.AmmountInMachine <= 0)
            {
                Console.WriteLine("Not enough cash available in machine.");
                //when no money exists in the atm it changes state to no cash
                _machine.SetMachineState(_machine.GetNoCashState());
            }
            else
            {
                Console.WriteLine("{0} withdrawn from machine.", amount);
                //when money has been withdrawed the state changes to no card
                _machine.SetMachineState(_machine.GetNoCardState());
            }
            //whether withdraw has been successful or not card gets rejected, like in the example
            RejectCard();
        }
    }
    }
