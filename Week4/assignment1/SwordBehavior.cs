using System;

namespace assignment1
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}