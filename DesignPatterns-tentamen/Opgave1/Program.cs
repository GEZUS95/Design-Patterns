using System;

namespace Opgave1
{
    class Program
    {
        // template
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        private void Start()
        {
            PrintHeader("[houten woning]");
            BasisWoning huis1 = new HoutenWoning();
            huis1.WoningBouwen();

            Console.WriteLine();

            PrintHeader("[glazen woning]");
            BasisWoning huis2 = new GlazenWoning();
            huis2.WoningBouwen();

            Console.WriteLine();

            PrintHeader("[betonnen woning]");
            BasisWoning huis3 = new BetonnenWoning();
            huis3.WoningBouwen();

            Console.ReadKey();
        }

        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
