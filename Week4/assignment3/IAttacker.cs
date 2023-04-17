namespace assignment3
{
    public interface IAttacker
    {
        string Driver {get; }
        void AssignDriver();
        void DriveForward();
        void UseWeapon();
    }
}