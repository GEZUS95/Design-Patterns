namespace assignment2
{
    public interface IComputerFactory
    {
        IProcessor AddProcessor();
        IHardDisk AddHardDisk();
        IMonitor AddMonitor();
    }
}
