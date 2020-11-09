using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HowToWriteAsyncMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHelloAsync("张三");

            //GetTaskOfTResult();

            //FireAndForget();

            //UseTaskDelay();

            //TestAsyncLambda();

            Console.ReadKey();
        }

        #region "返回Task的异步方法"
        static Task SayHello(string name)
        {
            return Task.Run(
                () =>
                {
                    Console.WriteLine("你好：{0}", name);
                });
        }


        static async void SayHelloAsync(string name)
        {
            await SayHello(name);
        }
        #endregion

        #region "返回Task<T>的异步方法"
        static Task<int> SumArray(int[] arr)
        {
            return Task.Run(() => arr.Sum());
        }

        static async Task<int> GetSumAsync(int[] arr)
        {
            int result = await SumArray(arr);
            return result;

        }

        static async void GetTaskOfTResult()
        {
            int[] arr = Enumerable.Range(1, 100).ToArray();
            //可以通过Task<T>.Result属性阻塞等待提取结果
            Console.WriteLine("result={0}", GetSumAsync(arr).Result);
            //也可使用await使用“异步回调”方式取出返回值
            int result = await GetSumAsync(arr);
            Console.WriteLine("result={0}",result);
        }

        #endregion

        #region "返回void的异步方法"
        public static async void FireAndForget()
        {
            var myTask = Task.Run(
            () =>
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Do work : {0}", i);
                    Thread.Sleep(500);

                }
            });
            await myTask;
        }

        #endregion

        #region "Task.Delay"
        public static async void UseTaskDelay()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do work : {0}", i);
                await Task.Delay(500);
            }

        }

        #endregion

        #region "异步Lambda表达式"

        static void TestAsyncLambda()
        {
            Action act = async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(500);
                    Console.WriteLine(i);
                }

            };
            act();
        }
        #endregion
    }
}
