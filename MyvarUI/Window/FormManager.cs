using System;
using System.Collections.Concurrent;
using System.Threading;

namespace MyvarUI.Window
{
    internal static class FormManager
    {
        private static int _formId = 0;
        private static ConcurrentDictionary<int, Form> Forms { get; }
        private static Thread WorkersThread { get; set; }
        private static ManualResetEventSlim ResetEvent { get; }

        static FormManager()
        {
            Forms = new ConcurrentDictionary<int, Form>();
            ResetEvent = new ManualResetEventSlim(false);
            WorkersThread = new Thread(MainLoop);
            WorkersThread.IsBackground = true;
            WorkersThread.Start();
        }

        private static void MainLoop()
        {
            if (Forms.Count == 0) ResetEvent.Reset();

            if (!ResetEvent.IsSet)
            {
                ResetEvent.Wait();
            }

            foreach (var i in Forms)
            {
                i.Value.Update();
                i.Value.Draw();
            }
        }

        public static void Add(Form form)
        {
            int formId = Interlocked.Increment(ref _formId);
            if (!Forms.TryAdd(formId, form))
            {
                throw new Exception();   
            }

            if (!ResetEvent.IsSet)
            {
                ResetEvent.Set();
            }
        }
    }
}
