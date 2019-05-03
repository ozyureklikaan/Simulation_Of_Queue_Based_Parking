using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfQueueBasedParking
{
    interface IQueue
    {
        void Insert(object car);
        object Remove();
        object[] Peek();
        Boolean IsEmpty();
    }
}
