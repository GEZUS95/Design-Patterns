using System;

namespace assignment1
{
    public class BowAndArrowBehaviour : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}
