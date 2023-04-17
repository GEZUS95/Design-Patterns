using System;

namespace assignment1
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void extracting()
        {
            Console.WriteLine("extracting twitter data...");
        }

        public override void transforming()
        {
            Console.WriteLine("transforming twitter data...");
        }
    }
}
