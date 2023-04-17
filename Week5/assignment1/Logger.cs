using System;

namespace assignment1
{
    public class Logger
    {
        private int _numberOfLines;
        private static Logger _uniqueInstance;

        private Logger()
        {
            _numberOfLines = 0;
        }

        public static Logger GetInstance()
        {
            if(_uniqueInstance is null)
            {
                _uniqueInstance = new Logger();
            }
            return _uniqueInstance;
        }

        public void Log(string system, string message)
        {
            _numberOfLines++;
            Console.WriteLine($"{_numberOfLines} - [{system}] {message}");
        }
    }
}
