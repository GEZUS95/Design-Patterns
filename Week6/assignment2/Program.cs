using System;

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
            //creating high budget shop
            Console.WriteLine("[shop creating expensive computers]");
            IComputerFactory expensiveFactory = new ExpensiveFactory();
            ComputerShop expensive = new ComputerShop(expensiveFactory);
            Computer expensivePC = expensive.AssembleMachine();
            expensivePC.Test();

            Console.WriteLine();

            //creating low budget shop
            Console.WriteLine("[shop creating cheap computers]");
            IComputerFactory cheapFactory = new CheapFactory();
            ComputerShop cheapShop = new ComputerShop(cheapFactory);
            Computer cheapPC = cheapShop.AssembleMachine();
            cheapPC.Test();

            Console.ReadKey();
        }
    }
}
