using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            // Nieuwe tank met bestuurder aanmaken
            IAttacker tank = new Tank("Frank");
            tank.AssignDriver();

            // Nieuwe robot met bestuurder aanmaken
            Robot robot = new Robot("Mark");
            IAttacker robotAdapter = new RobotAdapter(robot);
            robotAdapter.AssignDriver();
            Console.WriteLine();

            // een lijst met 'attackers' maken en een tank & robot toevoegen
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robotAdapter);

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }

            Console.ReadKey();
        }
    }
}
