using assignment1.Controller.Interfaces;
using assignment1.Model.Interfaces;

namespace assignment1.Controller
{
    public class TrainController : ITrainController
    {
        private ITrainJourney _trainJourney;

        public TrainController(ITrainJourney trainJourney)
        {
            this._trainJourney = trainJourney;
        }

        public void NextStation()
        {
            _trainJourney.NextStation();
        }
    }
}
