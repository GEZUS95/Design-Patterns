namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigDataLoader call = new CallDataLoader();
            BigDataLoader twitter = new TwitterDataLoader();
            BigDataLoader sensor = new SensorDataLoader();

            BatchProcessor batchProcessor = new BatchProcessor();

            batchProcessor.addObjectToList(call);
            batchProcessor.addObjectToList(twitter);
            batchProcessor.addObjectToList(sensor);

            batchProcessor.processList();
        }
    }
}
