namespace assignment1
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            System.Console.WriteLine("storing data not so quickly...");
        }
    }
}