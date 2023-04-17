namespace assignment3
{
    public class RobotAdapter : IAttacker
    {
        private Robot _robot;

        public string Driver { get { return _robot.Person; }}

        public RobotAdapter(Robot robot)
        {
            _robot = robot;
        }

        public void AssignDriver()
        {
            _robot.MovedByPerson();
        }

        public void DriveForward()
        {
            _robot.WalkForward();
        }

        public void UseWeapon()
        {
            _robot.BashWithHands();
        }
    }
}
