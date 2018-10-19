using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam_70_483_Practice
{
    public static class Threads
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        #region ThreadLocal<T> variables
        //public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        //{
        //    return Thread.CurrentThread.ManagedThreadId;
        //});
        #endregion
        #region variables used in  thread static
        //[ThreadStatic]
        //public static int _field;
        #endregion

        public static void Main(string[] args)
        {
            #region Tasks
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
            #endregion
            #region Thread Pools
            //ThreadPool.QueueUserWorkItem((s) => 
            //{
            //    Console.WriteLine("Working on a thread from threadpool");
            //});
            //Console.ReadLine();
            #endregion

            #region ThreadLocal<T>
            //new Thread(() =>
            //{
            //    for (int i = 0; i < _field.Value; i++)
            //    {
            //        Console.WriteLine($"Thread A: {i}");
            //    }
            //}).Start();

            //new Thread(() =>
            //{
            //    for (int i = 0; i < _field.Value; i++)
            //    {
            //        Console.WriteLine($"Thread B: {i}");
            //    }
            //}).Start();

            //Console.ReadKey();
            #endregion

            #region ThreadStatic
            //Testing Thread Static

            //new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        _field++;
            //        Console.WriteLine($"Thread A: {_field}");
            //    }
            //}).Start();

            //new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        _field++;
            //        Console.WriteLine($"Thread B: {_field}");
            //    }
            //}).Start();
            //Console.ReadKey();
            #endregion

            #region testing stopping threads

            //bool stopped = false;
            //Thread t = new Thread(new ThreadStart(() =>
            //{
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Running...");
            //        Thread.Sleep(1000);
            //    }
            //}));

            // t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //stopped = true;
            //t.Join();
            #endregion

            #region Simple thread test using ThreadMethod
            //   Simple thread test

            //   Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //   t.IsBackground = false;
            //   t.Start(5);

            //   for (int i = 0; i< 4; i++)
            //   {
            //        Console.WriteLine("Main thread: Do some work");
            //        Thread.Sleep(0);
            //   }
            //t.Join();
            #endregion
        }


    }
}

