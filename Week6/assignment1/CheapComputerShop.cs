namespace assignment1
{
    public class CheapComputerShop : ComputerShop
    {
        public override IHardDisk AddHardDisk()
        {
            return new CheapHardDisk();
        }
        public override IMonitor AddMonitor()
        {
            return new CheapMonitor();
        }
        public override IProcessor AddProcessor()
        {
            return new CheapProcessor();
        }
    }
}
