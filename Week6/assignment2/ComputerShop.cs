namespace assignment2
{
    public class ComputerShop
    {
        private IComputerFactory _factory;

        public ComputerShop(IComputerFactory factory)
        {
            this._factory = factory;
        }

        public Computer AssembleMachine()
        {
            Computer pc = new Computer();
            pc.processor = _factory.AddProcessor();
            pc.hardDisk = _factory.AddHardDisk();
            pc.monitor = _factory.AddMonitor();

            return pc;
        }
    }
}
