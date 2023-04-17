using System;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void etl()
        {
            extracting();
            transforming();
            loading();
        }
        public abstract void extracting();
        public abstract void transforming();
        public void loading()
        {
            Console.WriteLine("loading transformed data...");
        }
    }
}
