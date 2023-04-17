namespace assignment1
{
    public class MainSystem
    {
        private Logger _logger;
        private SubSystem subSys;

        public MainSystem()
        {
            _logger = Logger.GetInstance();
            subSys = new SubSystem();
            
            DoSomeMainWork();
            subSys.DoSomeWork();
            subSys.DoSomeMoreWork();
        }

        void DoSomeMainWork()
        {
            _logger.Log("MainSystem", "doing some main work");
        }
    }
}
