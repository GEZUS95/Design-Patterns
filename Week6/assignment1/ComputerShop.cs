namespace assignment1
{
    public abstract class ComputerShop
    {
        public Computer AssembleMachine()
        {
            Computer pc = new Computer();
            pc.hardDisk = AddHardDisk();
            pc.processor = AddProcessor();
            pc.monitor = AddMonitor();

            return pc;
        }

        public abstract IHardDisk AddHardDisk();
        public abstract IMonitor AddMonitor();
        public abstract IProcessor AddProcessor();

    }
}
