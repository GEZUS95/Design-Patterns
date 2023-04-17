using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Model
{
    public class TrainStation
    {
        public TrainStation(string name, string platform, DateTime toa, DateTime tod)
        {
            Name = name;
            Platform = platform;
            TimeOfArrival = toa;
            TimeOfDepature = tod;
        }

        public string Name { get; set; }
        public string Platform { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public DateTime TimeOfDepature { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
