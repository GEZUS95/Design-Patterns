namespace Opgave2
{
    public abstract class Laptop : IProcessor
    {
        private string _serialNumber;

        public IProcessor Processor { get; set; }

        public abstract void Execute(string program);

        public Laptop(string SN)
        {
            _serialNumber = SN;
        }
    }
}