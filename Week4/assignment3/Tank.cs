using System;

namespace assignment3
{
    public class Tank : IAttacker
    {
        public string Driver { get; set; }

        public Tank(string driver)
        {
            Driver = driver;
        }

        public void AssignDriver()
        {
            Console.WriteLine("{0} is steering the tank", Driver);
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");       
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon \n");        
        }
    }
}
