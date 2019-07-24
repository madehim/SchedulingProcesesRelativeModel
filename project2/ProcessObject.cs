
namespace project2
{
    class ProcessObject
    {
        public ProcessObject(int _StageCount)//для новых объектов
        {
            StageCount = _StageCount;
        }
        public ProcessObject()//для темп объектов
        {
        }
        public int[] StageQuue = new int[11];//массив для времени выполнения каждого стейджа
        public int StageCount = 0;//всего стейджей
        public int StageNow = 0;//текущее состояние
        public int WaitingTime = 0;//переменная для очереди ожидания
        public string ProcessName;//имя процесса
        public int ProcessID;//ид процесса
        public int ProcessPriority; //приоритет процесса
    }
}
