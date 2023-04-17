using System;

namespace assignment1
{
    public class KnifeBehaviour : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}
