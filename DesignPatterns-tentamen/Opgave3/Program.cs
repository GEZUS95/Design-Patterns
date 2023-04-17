using System;

namespace Opgave3
{
    class Program
    {
        // singelton
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            TicketSysteem systeem1 = TicketSysteem.GetInstance();
            TicketSysteem systeem2 = TicketSysteem.GetInstance();

            if (systeem1.Equals(systeem2))
            {
                Console.WriteLine("items zijn hetzelfde");
            }
            else
            {
                Console.WriteLine("items zijn niet hetzelfde");
            }
        }
    }
}
