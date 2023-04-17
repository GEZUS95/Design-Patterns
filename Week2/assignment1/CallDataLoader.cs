using System;

namespace assignment1
{
    public class CallDataLoader : BigDataLoader
    {
        public override void extracting()
        {
            Console.WriteLine("extracting call data...");
        }

        public override void transforming()
        {
            Console.WriteLine("transforming call data...");
        }
    }
}
