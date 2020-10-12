using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace GoGoTalk
{
    public class BaseTask : IDisposable
    {
        public static BaseTask Singleton = new BaseTask();
        
        private struct TaskItem
        {
            public Int64 StartTime { get; set; }
            public Int32 Delay { get; set; }
            public Action Action { get; set; }

            public TaskItem(Int64 startTime, Int32 delay, Action action)
            {
                StartTime = startTime;
                Delay = delay;
                Action = action;
            }
        }

        private ConcurrentBag<TaskItem> _TaskList = new ConcurrentBag<TaskItem>();

        private Boolean _Run = false;

        private BaseTask()
        {
            _Run = true;
            ThreadPool.QueueUserWorkItem(TaskThread, null);
        }

        public void AppendTask(Int32 delay, Action action)
        {
            _TaskList.Add(new TaskItem(DateTime.Now.Ticks, 3, action));
        }

        private void TaskThread(Object state)
        {
            while (_Run)
            {
                Thread.Sleep(1000);
                try
                {
                    foreach(var item in _TaskList)
                    {
                        if (DateTime.Now.Ticks - item.StartTime > item.Delay * 10000000)
                        {
                            _TaskList.TryTake(out var temp);
                            Task.Factory.StartNew(item.Action);
                        }
                    }
                }
                catch
                {
                }
            }
        }

        public void Dispose()
        {
            _Run = false;
        }
    }
}