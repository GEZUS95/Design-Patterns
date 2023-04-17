namespace assignment1
{
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            System.Console.WriteLine("performing operation very quickly...");        }
    }
}