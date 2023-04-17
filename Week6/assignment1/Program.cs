using System;

namespace assignment1
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
            //creating high budget shop
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop expensiveShop = new ExpensiveComputerShop();
            Computer expensivepc = expensiveShop.AssembleMachine();
            expensivepc.Test();
            

            Console.WriteLine();

            //creating low budget shop
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop cheapShop = new CheapComputerShop();
            Computer cheapPC = cheapShop.AssembleMachine();
            cheapPC.Test();

            Console.ReadKey();
        }
    }
}
