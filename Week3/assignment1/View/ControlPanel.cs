using assignment1.Controller;
using assignment1.Controller.Interfaces;
using assignment1.Model;
using assignment1.Model.Interfaces;
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
    public partial class ControlPanel : Form
    {
        private readonly ITrainJourney _trainJourney;
        private ITrainController _trainController;

        public ControlPanel()
        {
            InitializeComponent();

            _trainJourney = new TrainJourney();
            _trainController = new TrainController(_trainJourney);
        }

        private void btn_NextStation_Click(object sender, EventArgs e)
        {
            _trainController.NextStation();
        }

        private void btn_AddDisplay_Click(object sender, EventArgs e)
        {
            Form display = new TrainDisplay(_trainJourney);
            display.Show();
        }
    }
}
