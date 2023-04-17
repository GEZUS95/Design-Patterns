using Opgave4.Interfaces;
using System;

namespace Opgave4.Schermen
{
    public class AlarmDisplay : IAlarmObserver
    {
        public void Update(DateTime datumtijd, string melding)
        {
            Console.WriteLine("[alarm-display]: alarm geactiveerd om {0}", datumtijd.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        private IAlarmSysteem _alarmSysteem;

        public AlarmDisplay(IAlarmSysteem observer)
        {
            _alarmSysteem = observer;
            _alarmSysteem.AddObserver(this);
        }
    }
}
