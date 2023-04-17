using Opgave4.Interfaces;
using System;
using System.Collections.Generic;

namespace Opgave4
{
    public class AlarmSysteem : IAlarmSysteem
    {
        private List<IAlarmObserver> _alarmObservers = new List<IAlarmObserver>();

        public DateTime AlarmDatumTijd { get; set; }
        public string AlarmMelding { get; set; }

        public void ActiveerAlarm(string melding)
        {
            AlarmDatumTijd = DateTime.Now;
            AlarmMelding = melding;
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            foreach(IAlarmObserver display in _alarmObservers )
            {
                display.Update(AlarmDatumTijd, AlarmMelding);
            }
        }

        public void AddObserver(IAlarmObserver observer)
        {
            _alarmObservers.Add(observer);
        }

        public void RemoveObserver(IAlarmObserver observer)
        {
            _alarmObservers.Remove(observer);
        }

        public AlarmSysteem()
        {

        }
    }
}
