namespace assignment2
{
    public class ExpensiveFactory : IComputerFactory
    {
        public IProcessor AddProcessor()
        {
            return new ExpensiveProcessor();
        }

        public IHardDisk AddHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public IMonitor AddMonitor()
        {
            return new ExpensiveMonitor();
        }
    }
}
