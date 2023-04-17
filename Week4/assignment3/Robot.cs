using System;

namespace assignment3
{
    public class Robot
    {
        public string Person { get; set; }

        public Robot(string person)
        {
            Person = person;
        }

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands \n");
        }
        public void MovedByPerson()
        {
            Console.WriteLine("Robot is moved by {0}", Person);
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }
    }
}
