namespace CourseProject
{
    class Buyer
    {
        int enterTime;   // время прихода покупателя
        int waitTime;    // время обслуживания покупателя
        int currentTime; // текущее время
        int startProc;   // начало обслуживания

        public Buyer(int enterTime, int waitTime)
        {
            this.enterTime = enterTime;
            this.waitTime = waitTime;
            currentTime = 0;
            startProc = 0;
        }

        public int GetEnterTime() => enterTime;
        public int GetWaitTime() => waitTime;
        public int GetCurrentTime() => currentTime;
        public int GetStartProc() => startProc;
        public void SetStartProc(int newTime) => startProc = newTime;
        public void SetCurrentTime(int newTime) => currentTime = newTime;
    }
}