namespace assignment2
{
    public class CheapFactory : IComputerFactory
    {
        public IProcessor AddProcessor()
        {
            return new CheapProcessor();
        }

        public IHardDisk AddHardDisk()
        {
            return new CheapHardDisk();
        }

        public IMonitor AddMonitor()
        {
            return new CheapMonitor();
        }
    }
}
