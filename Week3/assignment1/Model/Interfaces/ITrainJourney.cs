using assignment1.View.Interfaces;

namespace assignment1.Model.Interfaces
{
    public interface ITrainJourney
    {
        void AddObserver(ITrainDisplay display);
        void RemoveObserver(ITrainDisplay display);
        void UpdateObserver();
        void NextStation();

        int NrOfObservers { get; }
    }
}
