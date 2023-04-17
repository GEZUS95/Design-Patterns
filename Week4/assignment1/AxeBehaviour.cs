using System;

namespace assignment1
{
    public class AxeBehaviour : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}
