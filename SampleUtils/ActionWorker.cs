using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUtils
{
    public class ActionWorker
    {
        private BlockingCollection<Action> _actionQueue;
        private Thread _thread;
        public ActionWorker()
        {
            _actionQueue = new BlockingCollection<Action>(1000);
            _thread = new Thread(Process);
            _thread.IsBackground = true;
            _thread.Start();
        }
        public void Process()
        {
            while (!_actionQueue.IsCompleted)
            {
                var action = _actionQueue.Take();
                try
                {
                    action?.Invoke();
                }
                catch
                {

                }
                Thread.Sleep(300);
            }
        }
        public void Add(Action action)
        {
            _actionQueue.Add(action);
        }
    }
}
