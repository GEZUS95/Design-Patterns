namespace assignment1
{
    public class Computer
    {
        public IProcessor processor { get; set; }
        public IHardDisk hardDisk { get; set; }
        public IMonitor monitor { get; set; }

        public void Test()
        {
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
    }
}
