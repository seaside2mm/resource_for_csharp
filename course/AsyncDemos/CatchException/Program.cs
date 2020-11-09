using System;
using System.Threading.Tasks;

namespace CatchException
{
    class Program
    {
        static void Main(string[] args)
        {

            TestExceptionThrowViaTaskResult();
            //TestExceptionThrowViaAwait();
            Console.ReadKey();
        }

        private static async void TestExceptionThrowViaAwait()
        {
            Console.WriteLine("使用await等待异步方法执行结束");
            Task<string> task = null;
            try
            {
                //当传入空串时，myAsyncMethod将抛出ArgumentNullException
                task = myAsyncMethod("");
                string result = await task;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n捕获到的异常，类型:{0}，信息：{1}",
                    ex.GetType(), ex.Message);
                Console.WriteLine("\nTask.Status:{0}, \nTask.Exception:{1}", 
                    task.Status, task.Exception.GetType());
            }
        }

        private static void TestExceptionThrowViaTaskResult()
        {
            Console.WriteLine("使用Task<T>.Result等待异步方法执行结束");
            Task<String> task = null;
            try
            {
               
                //当传入空串时，myAsyncMethod将抛出ArgumentNullException
                task = myAsyncMethod("");
            }
            catch (Exception ex)
            {
                //这里的异常捕获代码是不会被执行的，myAsyncMethod抛出的异常，
                //将会延迟到访问Task.Result时
                Console.WriteLine("立即捕获的异常:{0}", ex.Message);
            }

            try
            {
                //因为访问了Task.Result,所以在这里才抛出ArgumentNullException异常
                Console.WriteLine(task.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n捕获到的异常，类型:{0}，信息：{1}",
                    ex.GetType(), ex.Message);
                Console.WriteLine("\nTask.Status:{0}, \nTask.Exception:{1}", 
                    task.Status, task.Exception.GetType());
            }
        }

        static async Task<string> myAsyncMethod(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                throw new ArgumentNullException();
            }
            return await Task.Run<string>(() => info.ToUpper());
        }
    }
}
