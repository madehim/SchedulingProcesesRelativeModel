using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace project2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int ID = 0; //ид
        List<ProcessObject> QueueProcess = new List<ProcessObject>();  //создание листа объектов очереди готовности
        List<ProcessObject> WaitingProcess = new List<ProcessObject>(); // создание листа объектов очереди ожидания
        List<ProcessObject> ExecutedProcess = new List<ProcessObject>(); // лист для выполеных задач
        ProcessObject SavedExucutedProcess = new ProcessObject();  // объект для записи испольняемого процесса
        StreamWriter swel = new StreamWriter("Log.txt");  // лог работы программы 
        Random rnd = new Random(100); //рандомная генерация для всего
        bool StartExTimerFromWaitingQu = false;//запуск таймера выполнения из очереди ожидания
        decimal k = 1;//тик процессорного времени


        private void AutoGenerateButton_Click(object sender, EventArgs e)//кнопка запуска таймера автогенерации
        {
            AutoGenerateTimer.Start();//запуск таймера
            AutoGenerateButton.Enabled = false;//закрытие кнопки запуска генерации
            StopGenerateButton.Enabled = true;//открытие кнопки остановки генерации
        }

        private void StopGenerateButton_Click(object sender, EventArgs e)//кнопка остановки таймера автогенерации
        {
            AutoGenerateTimer.Stop();//остановка таймера автогенерации
            AutoGenerateButton.Enabled = true;//откритие кнопки запуска генерации
            StopGenerateButton.Enabled = false;//закрытие кнопки остановки генерации
        }

        private void AutoGenerateTimer_Tick(object sender, EventArgs e)//тик таймера автогенерации
        {
            int sttmp = rnd.Next((int)((GenerateStageRangeMax.Value - GenerateStageRangeMin.Value) + GenerateStageRangeMin.Value)); // получаем диапазон количества стейджей и задаем их рандомное значение
            if (sttmp % 2 == 0) { sttmp = sttmp + 1; }//делаем количество стейджей нечетным
            ProcessObject temp = new ProcessObject(sttmp);//создаем темп объект процесса с указаным выше количеством стейджей
            for (int i = 0; i < temp.StageCount; i++)//рандомно заполняем их. (для четного и нечетного правила разные)
            {
                if (i % 2 == 0) { temp.StageQuue[i] = rnd.Next((int)((GenerateStageTimeRangeMax.Value - GenerateStageTimeRangeMin.Value) + GenerateStageTimeRangeMin.Value) * 1000); }
                else { temp.StageQuue[i] = rnd.Next((int)((GenerateStageTimeRangeMax.Value - GenerateStageTimeRangeMin.Value) + GenerateStageTimeRangeMin.Value)); }
            }
            temp.ProcessID = ID;//записываем ид
            temp.ProcessName = "test" + ID.ToString();//записываем имя
            ID++;//инкримируем ид
            temp.ProcessPriority = rnd.Next(1000);//задаем приоритет
            QueueProcess.Add(temp);//добавляем в очередь готовых
            WriteToLog(temp, "Сгенерирована задача");//записываем в лог

            if (ExecutedProcessName.Text == "")//проверяем наличие выполняемого процесса
            {
                ToExecutedTask();
                ExecutedTimer.Start(); // старт таймера выполнения процесса
            }
            RefreshReadyQuueViewFunc();//перерисовка очереди готовых задач
        }

        private void ExecutedTimer_Tick(object sender, EventArgs e)//тик таймера выполнения
        {
            if (StartExTimerFromWaitingQu == false) //проверка на запуск таймера из очереди ожидания
            {
                if (SavedExucutedProcess.StageNow != SavedExucutedProcess.StageCount)//проверка на полное выполнение процесса
                {
                    WaitingProcess.Add(SavedExucutedProcess);//отравление в очередь ожидания
                    if (WaitingProcess.Count == 1 && WaitingQuueTimer.Enabled == false) { WaitingQuueTimer.Start(); }//проверка на необходимость запуска таймера очереди ожидания
                    RefreshWaitingQuueViewFunc();//перерисовка очереди ожидания
                    WriteToLog(SavedExucutedProcess, "Выполнена часть задачи");//запись в лог
                }
                else { WriteToLog(SavedExucutedProcess, "Задача выполнена"); ExecutedProcess.Add(SavedExucutedProcess); }//полное выполнение процесса
                if (QueueProcess.Count != 0)//проверка очереди готовых
                {
                    ToExecutedTask();//передаем процесс на выполнение
                }
                else { ExecutedTimer.Stop(); ExecutedProcessId.Text = ""; ExecutedProcessName.Text = ""; ExecutedProcessTime.Text = ""; }//нечего не выполняется
            }
            else
            {
                ToExecutedTask();//передаем процесс на выполнение
                StartExTimerFromWaitingQu = false;//
            }
        }

        private ProcessObject GetProcessFromQueue() //функция поиска процесса по приоретету
        {
            int MaxPrior = -1;
            ProcessObject TempProcessObject;
            for (int i = 0; i < QueueProcess.Count; i++)  // поиск максимального приоретета в листе
            {
                if (MaxPrior < QueueProcess[i].ProcessPriority)
                { MaxPrior = QueueProcess[i].ProcessPriority; }
            }
            TempProcessObject = QueueProcess.Find(x => x.ProcessPriority == MaxPrior);  //нахождение объекта процесса в листе по значению приоретета
            QueueProcess.Remove(TempProcessObject); //удаление его из учереди
            SavedExucutedProcess = TempProcessObject; // запись в объект исполняемого процесса
            RefreshReadyQuueViewFunc();//перерисовка очереди готовых
            return TempProcessObject;//возвращаем найденный процесс
        }

        private void WriteToLog(ProcessObject ProcToLog, string action) // запись в лог
        {
            swel.WriteLine(ProcToLog.ProcessID.ToString() + " " + ProcToLog.ProcessName + " " + action + " " + DateTime.Now.ToString());//запись в файл
            ListViewItem tmp = new ListViewItem();//создаем строку для добавления
            tmp.Text = ProcToLog.ProcessID.ToString();
            tmp.SubItems.Add(ProcToLog.ProcessName);
            tmp.SubItems.Add(action);
            tmp.SubItems.Add(DateTime.Now.ToString());
            LogView.Items.Insert(0, tmp);//вставляем эту строку в list view лога
        }

        private void RefreshReadyQuueViewFunc() //переррисовка очереди готовности
        {
            ReadyQuue.BeginUpdate();//начало апдейта
            ReadyQuue.Items.Clear();//очищение List view очереди готовности
            List<ProcessObject> TempQueueProcess = QueueProcess.OrderByDescending(o => o.ProcessPriority).ToList();//сортировка по приоритету
            for (int i = 0; i < TempQueueProcess.Count; i++)
            {
                ReadyQuue.Items.Add(Convert.ToString(TempQueueProcess[i].ProcessID));
                ReadyQuue.Items[i].SubItems.Add(TempQueueProcess[i].ProcessName);
                ReadyQuue.Items[i].SubItems.Add(TempQueueProcess[i].ProcessPriority.ToString());
                ReadyQuue.Items[i].SubItems.Add(TempQueueProcess[i].StageNow.ToString() + "/" + TempQueueProcess[i].StageCount.ToString());
            }
            ReadyQuue.EndUpdate();//завершение апдейта
        }

        private void RefreshWaitingQuueViewFunc() //переррисовка очереди ожидания
        {
            WaitingQuue.BeginUpdate();//старт апдейта
            WaitingQuue.Items.Clear();//очищение list view очреди готовности
            List<ProcessObject> TempWaitingProcess = WaitingProcess.OrderByDescending(o => o.ProcessPriority).ToList();//сортировка по приоритету
            for (int i = 0; i < TempWaitingProcess.Count; i++)
            {
                WaitingQuue.Items.Add(Convert.ToString(TempWaitingProcess[i].ProcessID));
                WaitingQuue.Items[i].SubItems.Add(TempWaitingProcess[i].ProcessName);
                WaitingQuue.Items[i].SubItems.Add(TempWaitingProcess[i].ProcessPriority.ToString());
                WaitingQuue.Items[i].SubItems.Add(TempWaitingProcess[i].StageNow.ToString() + "/" + TempWaitingProcess[i].StageCount.ToString());
            }
            WaitingQuue.EndUpdate();//завершение апдейта
        }

        private void WaitingQuueTimer_Tick(object sender, EventArgs e) // таймер очереди ожидания
        {
            if (WaitingProcess.Count != 0)//процерка на наличие процессов в очереди ожидания
            {
                bool refr = false;//переменная указывающая на необходимость перирисовки
                for (int i = 0; i < WaitingProcess.Count; i++)
                {
                    if (WaitingProcess[i].WaitingTime++ >= WaitingProcess[i].StageQuue[WaitingProcess[i].StageNow])//проверка на время нахождения в очереди готовых
                    {
                        WaitingProcess[i].StageNow++; //меняем стейдж
                        WaitingProcess[i].WaitingTime = 0;//обнуляем время ожидания
                        QueueProcess.Add(WaitingProcess[i]);//отравление в очередь готовых
                        WriteToLog(WaitingProcess[i], "Отправлен в очередь готовых из ожидания");//запись в лог
                        WaitingProcess.Remove(WaitingProcess[i]);//удаление из очереди ожидания
                        if ((QueueProcess.Count == 1) && (ExecutedTimer.Enabled == false)) { StartExTimerFromWaitingQu = true; ExecutedTimer.Interval = 1; ExecutedTimer.Start(); }// проверка на наличие процессов в очереди готовности и запущен ли таймер выполнения
                        refr = true;//включаем флаг на перерисовку
                    }
                    else
                    {
                        WaitingProcess[i].WaitingTime++;//инкримируем время ожидания процесса
                    }
                }
                if (refr == true)//проверка на необходимость перерисовки
                {
                    RefreshWaitingQuueViewFunc();//перерисовка очереди ожидания
                    RefreshReadyQuueViewFunc();//перерисовка очереди исполнения
                }
            }
            else { WaitingQuueTimer.Stop(); }//остановка таймера ожидание, если очередь пуста
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//закрытие программы
        {
            swel.Close();//закрываем запись в файл
        }

        private void GenerateStageRangeMin_ValueChanged(object sender, EventArgs e)//для настройки генерации процессов(4 шт).
        {
            GenerateStageRangeMax.Minimum = GenerateStageRangeMin.Value;
        }

        private void GenerateStageRangeMax_ValueChanged(object sender, EventArgs e)
        {
            GenerateStageRangeMin.Maximum = GenerateStageRangeMax.Value;
        }

        private void GenerateStageTimeRangeMin_ValueChanged(object sender, EventArgs e)
        {
            GenerateStageTimeRangeMax.Minimum = GenerateStageTimeRangeMin.Value;
        }

        private void GenerateStageTimeRangeMax_ValueChanged(object sender, EventArgs e)
        {
            GenerateStageTimeRangeMin.Maximum = GenerateStageTimeRangeMax.Value;
        }

        private void ToExecutedTask() // работа с выполняемым процессом
        {
            ProcessObject TempProcessObject = new ProcessObject();
            TempProcessObject = GetProcessFromQueue();//берем процесс с наибольшим приорететом
            ExecutedTimer.Interval = (int)(TempProcessObject.StageQuue[TempProcessObject.StageNow] * k); // назначение времени, необходимого для выполнения процесса
            ExecutedProcessName.Text = TempProcessObject.ProcessName; // запись информации о процессе в текстбоксы выполнения
            ExecutedProcessId.Text = Convert.ToString(TempProcessObject.ProcessID);
            ExecutedProcessTime.Text = TempProcessObject.StageQuue[TempProcessObject.StageNow].ToString();
            TempProcessObject.StageNow++;//увеличиваем стейдж
            WriteToLog(SavedExucutedProcess, "Задача отправлена на выполнение");//запись в лог
        }

        private void GenerateStageRangeMin_KeyPress(object sender, KeyPressEventArgs e)//для настройки автогенерации(кол-во стейджей должно быть нечетным)
        {
            string checkstring = "13579";
            if (checkstring.Contains(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void GenerateStageRangeMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            string checkstring = "13579";
            if (checkstring.Contains(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//тик процессерного времени
        {
            k = ProcessorTickK.Value;
        }


        private void RefreshIDInfo_Tick_1(object sender, EventArgs e)//таймер вывод информации о процессе
        {
            if (ID > 0) { IdInfo.Maximum = ID - 1; }//установление выборки ид
            else { IdInfo.Maximum = ID; }
            if (IdInfo.Text.Length > 0 && ID > 0 && IdInfo.Value < ID)//условия проверки ид
            {
                ProcessObject tmp = new ProcessObject();//темп объект
                bool find = false;//булевая переменная для оптимизации
                string wherefind = "";//строка для передачи функции
                int GetIDInfo = Convert.ToInt32(IdInfo.Text);//ид
                for (int i = 0; i < QueueProcess.Count; i++)//проверка очереди готовых
                {
                    if (QueueProcess[i].ProcessID == GetIDInfo)
                    {
                        tmp = QueueProcess[i];
                        wherefind = "prepared";
                        find = true;
                        break;
                    }
                }
                if (find != true)//проверка в выполнении
                {
                    if (SavedExucutedProcess.ProcessID == GetIDInfo) { tmp = SavedExucutedProcess; find = true; wherefind = "executed"; }
                }
                if (find != true)//проверка в ожидании
                {
                    for (int i = 0; i < WaitingProcess.Count; i++)
                    {
                        tmp = WaitingProcess[i];
                        find = true;
                        wherefind = "waiting";
                        break;
                    }
                }
                if (find != true)//поиск в выполненых процессах
                {
                    for (int i = 0; i < ExecutedProcess.Count; i++)
                    {
                        tmp = ExecutedProcess[i];
                        find = true;
                        wherefind = "ready";
                        break;
                    }
                }
                if (find != true)//ошибка ?
                {
                    MessageBox.Show("Какая-то ошибка");
                }
                else
                {
                    ProgressView.Rows.Clear();//очишаем текущий бар
                    ProgressView.RowCount = 1;
                    switch (wherefind) //выбираем в какой очереди найдено, и передаем соот-е параметры на функцию отрисовки
                    {
                        case "waiting":
                            PaintIDInfo(tmp.StageNow, tmp.StageCount);
                            break;
                        case "prepared":
                            PaintIDInfo(tmp.StageNow, tmp.StageCount);
                            break;
                        case "ready":
                            ProgressView.ColumnCount = 1;
                            ProgressView[0, 0].Value = "Задача выполнена";
                            break;
                        case "executed":
                            PaintIDInfo(tmp.StageNow - 1, tmp.StageCount);
                            break;
                    }
                    ProgressView.AutoResizeColumns();
                }
            }
            else
            {
                if (ID == 0)
                {
                    ProgressView.Rows.Clear();
                    ProgressView.ColumnCount = 1;
                    ProgressView.RowCount = 1;
                    ProgressView[0, 0].Value = "Запустите генирацию процессов";
                    ProgressView.AutoResizeColumns();
                }
                else
                {
                    ProgressView.Rows.Clear();
                    ProgressView.ColumnCount = 1;
                    ProgressView.RowCount = 1;
                    ProgressView[0, 0].Value = "Введите ID";
                    ProgressView.AutoResizeColumns();
                }
            }
        }

        private void PaintIDInfo(int now, int max) //функция отрисовки
        {
            ProgressView.RowCount = 1;
            ProgressView.ColumnCount = max;
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)//p w проверка
                {
                    ProgressView[i, 0].Value = "p";
                    if (now > i) //проверка на выполненость шага
                    {
                        ProgressView[i, 0].Style.BackColor = Color.Green;
                    }
                    else { ProgressView[i, 0].Style.BackColor = Color.Red; }
                }
                else
                {
                    ProgressView[i, 0].Value = "w"; //ниже проверка на выполненость шага
                    if (now > i) { ProgressView[i, 0].Style.BackColor = Color.Green; } else { ProgressView[i, 0].Style.BackColor = Color.Red; }
                }
            }
        }

        private void IdInfo_KeyPress(object sender, KeyPressEventArgs e)//информация о процессе
        {
            if (char.IsDigit(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void GenerateTaskTimeRange_ValueChanged(object sender, EventArgs e)//изменение скорости генерации процессов
        {
            AutoGenerateTimer.Interval = 1000 * (int)GenerateTaskTimeRange.Value;
        }
    }
}
