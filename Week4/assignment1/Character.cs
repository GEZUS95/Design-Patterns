namespace assignment1
{
    public abstract class Character
    {
        private IWeaponBehavior _weapon;
        public IWeaponBehavior Weapon { get { return _weapon; } set { _weapon = value; } }

        public Character()
        {
            Weapon = new SwordBehavior();
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
