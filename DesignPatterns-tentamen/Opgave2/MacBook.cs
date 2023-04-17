namespace Opgave2
{
    internal class MacBook : Laptop
    {

        public MacBook(string sn) : base(sn)
        {

        }

        public override void Execute(string program)
        {
            System.Console.WriteLine("Executing program '{0}' with processor {1}", program, Processor.ToString());
        }
    }
}