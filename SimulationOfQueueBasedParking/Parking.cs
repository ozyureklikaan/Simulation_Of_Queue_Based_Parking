using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfQueueBasedParking
{
    class Parking
    {
        static int carNumber = FormParking.carNumber;
        public static SimpleQueue simpleQueue = new SimpleQueue(carNumber);
        public static PriorityQueue priorityQueue = new PriorityQueue(carNumber);

        public void AddCarToParking()
        {
            Random randomProcessingTime = new Random();

            for (int i = 0; i < carNumber; i++)
            {
                Car a = new Car();
                a.ProcessingTime = randomProcessingTime.Next(10, 300);
                a.Number = i + 1;
                simpleQueue.Insert(a);
            }
        }

        public string ListCarParking()
        {
            string strList = "";
            foreach (Car a in simpleQueue.Peek())
            {
                strList += "" + a.Number + " Numaralı aracın --> İşlem süresi : " + a.ProcessingTime + Environment.NewLine;
            }
            return strList;
        }

        public string RemoveCarParking()
        {
            int passingTime = 0, i = 1;
            string strList = "";
            foreach (Car a in simpleQueue.Peek())
            {
                passingTime += a.ProcessingTime;
                strList += "Otoparktan " + i++ + ". Çıkan Araba --> " + a.Number + "Numaralı aracın Kuyrukta Kalma Süresi : " + passingTime + Environment.NewLine;
                simpleQueue.Remove();
            }
            return strList;
        }

        public void AddToPriorityCar()
        {
            Car b = new Car();
            foreach (Car a in simpleQueue.Peek())
            {
                b = a;
                priorityQueue.Insert(b);
            }
        }

        public string ListPriorityCar()
        {
            string strList = "";
            foreach (Car a in priorityQueue.Peek())
            {
                strList += "" + a.Number + " Numaralı aracın --> İşlem süresi : " + a.ProcessingTime + Environment.NewLine;
            }
            return strList;
        }

        public string OncelikliArabaSil()
        {
            int passingTime = 0, i = 1;
            string strList = "";
            foreach (Car a in priorityQueue.Peek())
            {
                passingTime += a.ProcessingTime;
                strList += "Otoparktan " + i++ + ". Çıkan Araba --> " + a.Number + "Numaralı aracın Kuyrukta Kalma Süresi : " + passingTime + Environment.NewLine;
            }
            foreach (Car b in priorityQueue.Peek())
            {
                priorityQueue.Remove();
            }
            return strList;
        }

        public int IslemSuresiOrtalamaHesapla()
        {
            int total = 0, avg = 0;
            foreach (Car a in simpleQueue.Peek())
            {
                total += a.ProcessingTime;
            }
            avg = total / carNumber;
            return avg;
        }

        public string CalculateEarnings()
        {
            double[,] array = new double[carNumber, 3];
            int passingTime = 0, i = 0, carCounter = 1;
            double fark = 0, yuzde = 0;
            string strFarkYuzde = "";

            foreach (Car a in simpleQueue.Peek())
            {
                passingTime += a.ProcessingTime;
                array[i, 0] = carCounter;
                array[i, 1] = passingTime;
                i++;
                carCounter++;
            }

            passingTime = 0;
            foreach (Car b in priorityQueue.Peek())
            {
                for (i = 0; i < carNumber; i++)
                {
                    if (b.Number == array[i, 0])
                    {
                        passingTime += b.ProcessingTime;
                        array[i, 2] = passingTime;
                    }
                }
            }

            for (i = 0; i < carNumber; i++)
            {
                if (array[i, 1] > array[i, 2])
                {
                    fark = array[i, 1] - array[i, 2];
                    yuzde = ((array[i, 1] - array[i, 2]) / array[i, 2]) * 100;
                    yuzde = Math.Round(yuzde, 2);
                    strFarkYuzde += "" + array[i, 0] + " Numaralı Araç --> " + fark + " Saniye Daha Az Beklemiştir. Zamandan %" + yuzde + " Kazancı Vardır." + Environment.NewLine;
                }
            }
            if (strFarkYuzde == "")
            {
                strFarkYuzde = "Zamandan Kazanç Sağlayan Araç Bulunmamaktadır";
            }
            return strFarkYuzde;
        }
    }
}
