using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroduceAsyncMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSyncInvoke(); 
            //TestAsyncInvokeUseAwait();
            TestAsyncInvokeUseTPL();
            Console.WriteLine("Main方法：敲任意键退出。");
            Console.ReadKey(true);
        }
        /// <summary>
        /// 方法的同步调用，被调用方法不执行完毕，后续代码无法运行
        /// </summary>
        static void TestSyncInvoke()
        {
            DoLongJob();
            Console.WriteLine("DoLongJob方法执行完毕");
          
        }
        /// <summary>
        /// 一个将要执行比较长时间的同步方法
        /// </summary>
        static void DoLongJob()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("正在工作：" + i);
            }
        }

        /// <summary>
        /// 测试方法的异步执行(使用C#5的await关键字）
        /// </summary>
        static async void TestAsyncInvokeUseAwait()
        {
            Console.WriteLine( "DoLongJob方法正在后台执行……");
            await DoLongJobUseTask();
            Console.WriteLine("DoLongJob方法执行完毕");
        }
        /// <summary>
        /// 使用TPL在另一个线程中运行代码
        /// </summary>
        /// <returns></returns>
        static Task DoLongJobUseTask()
        {
            return Task.Run(() => DoLongJob());
            
        }

        /// <summary>
        /// 使用TPL版本实现的方法异步调用
        /// </summary>
        static void TestAsyncInvokeUseTPL()
        {
            Console.WriteLine("DoLongJob方法正在后台执行……");
            
            Task.Run(() => DoLongJob())
                .ContinueWith(
                    (task) => {
                        Console.WriteLine("DoLongJob方法执行完毕");
                    }
            );
        }
    }
}
