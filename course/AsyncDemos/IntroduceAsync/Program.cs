using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("进入Main()方法，执行线程ID:{0},来自线程池?{1},是背景线程?{2}",
                Thread.CurrentThread.ManagedThreadId, 
                Thread.CurrentThread.IsThreadPoolThread, 
                Thread.CurrentThread.IsBackground);
            TestDoWorkAsync();
            Console.WriteLine("\n返回Main()方法，等待用户敲任意键退出。执行线程ID:{0},来自线程池?{1},是背景线程?{2}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.IsBackground);
            Console.ReadKey();
        }
      
        private async static Task TestDoWorkAsync()
        {
            Console.WriteLine("\n进入TestDoWorkAsync()方法，await语句之前的代码执行线程ID:{0}，来自线程池?{1},是背景线程?{2}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.IsBackground);
            await DoWork();
            Console.WriteLine("\n退出TestDoWorkAsync()方法，await语句之后的代码执行线程ID:{0}，来自线程池?{1},是背景线程?{2}", 
                Thread.CurrentThread.ManagedThreadId, 
                Thread.CurrentThread.IsThreadPoolThread, 
                Thread.CurrentThread.IsBackground);
        }

        static Task DoWork()
        {
            return Task.Run( () =>
            {
                Console.WriteLine("\n使用TPL运行DoWork方法，负责执行的线程ID:{0}，来自线程池？{1},是背景线程？{2}",
                    Thread.CurrentThread.ManagedThreadId, 
                    Thread.CurrentThread.IsThreadPoolThread, 
                    Thread.CurrentThread.IsBackground);
            });
        }
    }

   

}
