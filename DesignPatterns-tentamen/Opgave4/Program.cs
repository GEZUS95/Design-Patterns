using Opgave4.Interfaces;
using Opgave4.Schermen;
using System;

namespace Opgave4
{
    class Program
    {
        // observer pattern
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        private void Start()
        {
            // maak alarmsysteem aan
            IAlarmSysteem alarmSysteem = new AlarmSysteem();

            // maak een controller aan
            IAlarmController controller = new AlarmController(alarmSysteem);

            // maak displays aan
            IAlarmObserver normalDisplay = new AlarmDisplay(alarmSysteem);
            IAlarmObserver fancyDisplay = new AlarmExtendedDisplay(alarmSysteem);

            // activeer het alarmsysteem een paar keer (om te testen)
            controller.ActiveerAlarm("achterdeur staat open");
            Console.WriteLine();
            controller.ActiveerAlarm("tocht bij raam 1e verdieping");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
