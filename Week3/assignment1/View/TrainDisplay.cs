using assignment1.Model;
using assignment1.Model.Interfaces;
using assignment1.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney _trainJourney;
        public TrainDisplay(ITrainJourney journey )
        {
            InitializeComponent();
            this._trainJourney = journey;
            _trainJourney.AddObserver(this);
            int NrOfObservers = _trainJourney.NrOfObservers;
            Name = $"TrainDisplay{NrOfObservers}";
            Text = $"TrainDisplay{NrOfObservers}";
        }

        public void Update(TrainStation station)
        {
            txt_CurrentStation.Text = station.Name;
            txt_Platform.Text = station.Platform;
            txt_TimeOfArrival.Text = station.TimeOfArrival.ToString();
        }

        private void TrainDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trainJourney.RemoveObserver(this);
        }
    }
}
