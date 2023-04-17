using System;

namespace Opgave4.Interfaces
{
    public interface IAlarmObserver
    {
        void Update(DateTime datumtijd, string melding);
     }
}
