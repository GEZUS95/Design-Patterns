namespace assignment2
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            System.Console.WriteLine("storing data very quickly...");        }
    }
}