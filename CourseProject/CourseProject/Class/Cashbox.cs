using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject
{
    class Cashbox
    { 
        Queue<Buyer> buyers = new Queue<Buyer>(); // очередь перед данной кассой
        public Buyer currentBuyer;                // обслуживаемый на данный момент покупатель
        bool busy;                                // свободна касса или нет
        public bool firstDowntimeCashbox = true;  // нужно для первой записи времени простоя кассы до 1-го покупателя
        int limitBuyers;                          // максимальная длина очереди
        int finBuyers;                            // количество обслуженных покупателей
        public int declineBuyers = 0;             // количество отказов
        int totalBuyers = 0;                      // всего покупателей (обслуженные и отказанных)
        int num = 0;                              // нужно для отсчёта количества покупателей

        public List<int> timeByers            = new List<int>(); // время прихода покупателей
        public List<int> timeStartProcessing  = new List<int>(); // время начала обслуживания клиента
        public List<int> timeFinishProcessing = new List<int>(); // время конца обслуживания клиента
        public List<int> waitTime             = new List<int>(); // время обслуживания клиента
        public List<int> numByers             = new List<int>(); // количество обслуженных покупателей
        public List<int> timeStayingOfCashbox = new List<int>(); // время пребывания клиента у кассы
        public List<int> downtimeCashbox      = new List<int>(); // время простоя кассы

        public Cashbox(int limitBuyers)
        {
            busy = false;
            currentBuyer = null;
            this.limitBuyers = limitBuyers;
            finBuyers = 0;
        }

        public void Check(int timer)
        {
            if (busy == false && buyers.Count != 0) // если касса не занята и в очереди есть клиент, то обрабатываем клиента
            {
                currentBuyer = buyers.Dequeue(); // достаём клиента из очереди и убавляем количество человек в очереди
                currentBuyer.SetStartProc(timer);
                busy = true;
            }
            if (busy == true) // если касса занята, то обслуживаем клиента
            {
                ServiceBuyer(timer);
            }
        }

        void ServiceBuyer(int timer)
        {
            currentBuyer.SetCurrentTime(currentBuyer.GetCurrentTime() + 1);
            if (currentBuyer.GetCurrentTime() == currentBuyer.GetWaitTime())
            {
                numByers. Add(++num);
                timeByers.Add(currentBuyer.GetEnterTime());
                timeStartProcessing. Add(currentBuyer.GetStartProc());
                timeFinishProcessing.Add(timer + 1);

                if (firstDowntimeCashbox)
                {
                    downtimeCashbox.Add(timeByers.Last());
                    firstDowntimeCashbox = false;
                }
                else
                {
                    for (int i = 0, j = 1; i < timeStartProcessing.Count() && j < timeFinishProcessing.Count(); i++, j++)
                    {
                        if (timeStartProcessing[j] - timeFinishProcessing[i] != 0)
                        {
                            downtimeCashbox.Add(Math.Abs(timeStartProcessing[j] - timeFinishProcessing[i]));
                        }
                        else
                        {
                            downtimeCashbox.Add(0);
                        }
                    }
                }

                waitTime.Add(currentBuyer.GetWaitTime());
                timeStayingOfCashbox.Add((currentBuyer.GetStartProc() - currentBuyer.GetEnterTime()) + currentBuyer.GetWaitTime());
                currentBuyer = null;
                busy = false;
                finBuyers++;
            }
        }

        public void AddBuyer(int time, int timeDistribution)
        {
            totalBuyers++;
            if (buyers.Count < limitBuyers) // если в очереди есть место, то ставим в очередь клиента, иначе отказ в обслуживании
            {
                buyers.Enqueue(new Buyer(time, timeDistribution));
            }
            else
            {
                declineBuyers++;
            }
        }

        public int GetNumberBuyers() => buyers.Count();
        public int GetFinNumberBuyers() => finBuyers;
        public int GetDeclineBuyers() => declineBuyers;
        public List<int> GetDownTimeCashbox() => downtimeCashbox;
        public List<int> GetTimeStartProcessing() => timeStartProcessing;
        public List<int> GetTimeFinishProcessing() => timeFinishProcessing;
        public List<int> GetTimeByers() => timeByers;
        public List<int> GetNumByers() => numByers;
        public List<int> GetWaitTime() => waitTime;
        public List<int> GetTimeStayingOfCashbox() => timeStayingOfCashbox;
        public int GetTotalBuyers() => totalBuyers;
    }
}