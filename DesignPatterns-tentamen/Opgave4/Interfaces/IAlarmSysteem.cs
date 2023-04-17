namespace Opgave4.Interfaces
{
    public interface IAlarmSysteem
    {
        void ActiveerAlarm(string melding);

        void AddObserver(IAlarmObserver observer);
        void RemoveObserver(IAlarmObserver observer);
    }
}
