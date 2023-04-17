using Opgave4.Interfaces;
using System;


namespace Opgave4.Schermen
{
    public class AlarmExtendedDisplay : IAlarmObserver
    {
        public void Update(DateTime datumtijd, string melding)
        {
            Console.WriteLine("[extended alarm-display]: alarm geactiveerd om {0} - {1}", datumtijd.ToString("dd/MM/yyyy HH:mm:ss"), melding);
        }

        private IAlarmSysteem _alarmSysteem;
        public AlarmExtendedDisplay(IAlarmSysteem observer)
        {
            _alarmSysteem = observer;
            _alarmSysteem.AddObserver(this);
        }
    }
}
