using System;

namespace assignment1
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void extracting()
        {
            Console.WriteLine("extracting sensor data...");
        }

        public override void transforming()
        {
            Console.WriteLine("transforming sensor data...");
        }
    }
}
