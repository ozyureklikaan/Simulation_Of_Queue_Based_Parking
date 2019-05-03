using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfQueueBasedParking
{
    class Car : Parking
    {
        public int Number { get; set; }
        public int ProcessingTime { get; set; }
    }
}
