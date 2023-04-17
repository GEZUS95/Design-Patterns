namespace assignment1
{
    public class ExpensiveComputerShop : ComputerShop
    {
        public override IHardDisk AddHardDisk()
        {
            return new ExpensiveHardDisk();
        }
        public override IMonitor AddMonitor()
        {
            return new ExpensiveMonitor();
        }
        public override IProcessor AddProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
