namespace assignment1
{
    public class SubSystem
    {
        private Logger _logger;

        public SubSystem()
        {
            _logger = Logger.GetInstance();
        }

        public void DoSomeMoreWork()
        {
            _logger.Log("SubSystem", "doing some more work");
        }

        public void DoSomeWork()
        {
            _logger.Log("SubSystem", "doing some work");
        }
    }
}
