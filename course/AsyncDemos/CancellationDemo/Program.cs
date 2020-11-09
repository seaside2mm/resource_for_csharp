using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationDemo
{
    class Program
    {
        //一个支持取消的异步方法
        static async Task DoAsync(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                //当有取消请求时，抛出OperationCanceledException 
                token.ThrowIfCancellationRequested();
                Console.WriteLine(i);
                //用于“拖慢”程序运行速度
                await Task.Delay(500);
            }
        }
        static void Main(string[] args)
        {
            //TestTaskCancel();
            TestTimeOutCancel();
            Console.ReadKey();

        }

        static async void TestTaskCancel()
        {
            var cts = new CancellationTokenSource();
            //设置延迟0.5秒之后，发出取消请求
            Task.Delay(500).ContinueWith(t => cts.Cancel());

            Task task = DoAsync(cts.Token);
            try
            {
                await task;
                Console.WriteLine("异步方法结束,状态为：{0}", task.Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine("异步方法被取消,任务状态为：{0}，异常类型为：{1}，消息为：{2}", 
                    task.Status,ex.GetType(),ex.Message);
            }

        }

      
        static async void TestTimeOutCancel()
        {
            //设置等待0.5秒，超时后，自动Cancel
            var cts = new CancellationTokenSource(1500);
            Task task = DoAsync(cts.Token);
            try
            {
                await task;
                Console.WriteLine("异步方法结束,状态为：{0}", task.Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine("异步方法因超时而被取消,任务状态为：{0}，异常类型为：{1}，消息为：{2}",
                    task.Status, ex.GetType(), ex.Message);

            }
        }

       
    }
}
