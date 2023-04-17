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

        private void Start()
        {
            Logger logger = Logger.GetInstance();

            logger.Log("main", "starting");
            MainSystem mainSys = new MainSystem();
            logger.Log("main", "finishing");

            Console.ReadKey();
        }
    }
}
