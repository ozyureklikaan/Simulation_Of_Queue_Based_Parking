using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfQueueBasedParking
{
    class SimpleQueue : IQueue
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public SimpleQueue(int carNumber)
        {
            this.size = carNumber;
            Queue = new object[size];
        }

        public void Insert(object car)
        {
            if ((count == size) || (rear == (size - 1)))
            {
                throw new Exception("Parking Full");
            }
            if (front == -1)
            {
                front = 0;
            }
            Queue[++rear] = car;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object[] Peek()
        {
            return Queue;
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Parking Empty");
            }
            object removedCar = Queue[front];
            Queue[front] = null;
            front++;
            count--;
            return removedCar;
        }
    }
}
