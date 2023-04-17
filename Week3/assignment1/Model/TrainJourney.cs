using assignment1.Model.Interfaces;
using assignment1.View.Interfaces;
using System;
using System.Collections.Generic;

namespace assignment1.Model
{
    public class TrainJourney : ITrainJourney
    {
        private List<TrainStation> DenHelderAmsterdam = new List<TrainStation>();
        public int NrOfObservers { get; set; }
        private List<ITrainDisplay> _trainDisplays = new List<ITrainDisplay>();
        private int _currentStation;


        public TrainJourney()
        {
            DenHelderAmsterdam.Add(new TrainStation("Den Helder", "2", new DateTime(2021, 4, 28, 19, 34, 00), new DateTime(2021, 4, 28, 19, 34, 00)));
            DenHelderAmsterdam.Add(new TrainStation("Den Helder Zuid", "1", new DateTime(2021, 4, 28, 19, 37, 00), new DateTime(2021, 4, 28, 19, 38, 00)));
            DenHelderAmsterdam.Add(new TrainStation("Anna Paulowna", "1", new DateTime(2021, 4, 28, 19, 44, 00), new DateTime(2021, 4, 28, 19, 45, 00)));
            DenHelderAmsterdam.Add(new TrainStation("Schagen", "1", new DateTime(2021, 4, 28, 19, 52, 00), new DateTime(2021, 4, 28, 19, 52, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Heerhugowaard", "1", new DateTime(2021, 4, 28, 20, 01, 00), new DateTime(2021, 4, 28, 20, 01, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Alkmaar Noord", "1", new DateTime(2021, 4, 28, 20, 07, 00), new DateTime(2021, 4, 28, 20, 07, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Alkmaar", "5", new DateTime(2021, 4, 28, 20, 11, 00), new DateTime(2021, 4, 28, 20, 14, 00)));
            DenHelderAmsterdam.Add(new TrainStation("Heilo", "2", new DateTime(2021, 4, 28, 20, 19, 00), new DateTime(2021, 4, 28, 20, 19, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Castricum", "2", new DateTime(2021, 4, 28, 20, 25, 00), new DateTime(2021, 4, 28, 20, 25, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Zaandam", "4", new DateTime(2021, 4, 28, 20, 39, 00), new DateTime(2021, 4, 28, 20, 39, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Amsterdam Sloterdijk", "5", new DateTime(2021, 4, 28, 20, 45, 00), new DateTime(2021, 4, 28, 20, 45, 59)));
            DenHelderAmsterdam.Add(new TrainStation("Amsterdam Centraal", "4b", new DateTime(2021, 4, 28, 20, 51, 00), new DateTime(2021, 4, 28, 20, 54, 00)));
            DenHelderAmsterdam.Add(new TrainStation("Amsterdam Amstel", "4", new DateTime(2021, 4, 28, 21, 01, 00), new DateTime(2021, 4, 28, 21, 03, 00)));
        }

        public void NextStation()
        {
            if (_currentStation >= DenHelderAmsterdam.Count - 1) { DenHelderAmsterdam.Reverse(); }
            if (_currentStation != DenHelderAmsterdam.Count - 1)
            {
                _currentStation++;
            }
            else
            {
                _currentStation = 0;
            }
            UpdateObserver();
        }

        public void AddObserver(ITrainDisplay display)
        {
            _trainDisplays.Add(display);
            NrOfObservers++;
            UpdateObserver();
        }

        public void RemoveObserver(ITrainDisplay display)
        {
            _trainDisplays.Remove(display);
        }

        public void UpdateObserver()
        {
            NotifiDisplays();
        }

        private void NotifiDisplays()
        {
            foreach (ITrainDisplay display in _trainDisplays)
            {
                display.Update(DenHelderAmsterdam[_currentStation]);
            }
        }
    }
}
