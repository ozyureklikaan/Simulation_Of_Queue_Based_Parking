using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfQueueBasedParking
{
    class PriorityQueue
    {
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int carNumber)
        {
            this.size = carNumber;
            Queue = new object[size];
        }

        public void Insert(object car)
        {
            if (count == size)
            {
                throw new Exception("Parking Full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = car;
                count++;
            }
            else
            {
                int i;
                for (i = (count - 1); i >= 0; i--)
                {
                    if (Convert.ToInt32(((Car)car).ProcessingTime) < Convert.ToInt32(((Car)Queue[i]).ProcessingTime))
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                    {
                        break;
                    }
                }
                Queue[i + 1] = car;
                front++;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object[] Peek()
        {
            return Queue;
            //return 0;
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Parking Empty");
            }
            object removedCar = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return removedCar;
        }
    }
}
