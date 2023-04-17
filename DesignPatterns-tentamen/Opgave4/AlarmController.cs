using Opgave4.Interfaces;

namespace Opgave4
{
    public class AlarmController : IAlarmController
    {
        private IAlarmSysteem _alarmSysteem;

        public AlarmController(IAlarmSysteem systeem)
        {
            _alarmSysteem = systeem;
        }

        public void ActiveerAlarm(string melding)
        {
            _alarmSysteem.ActiveerAlarm(melding);
        }
    }
}
