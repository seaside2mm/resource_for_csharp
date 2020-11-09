using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadOverheadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadOverhead();
            Console.ReadKey();
        }
        private static void ThreadOverhead()
        {
            
            const int OneMB = 1024 * 1024;
            using (ManualResetEvent mre = new ManualResetEvent(false))
            {
                int threadNum = 0;
                long MemorySize = 0;
                try
                {
                    ParameterizedThreadStart ts = (mreWake) => (mreWake as ManualResetEvent).WaitOne();

                    while (true)
                    {

                        Thread t = new Thread(ts);
                        t.Start(mre);
                        MemorySize=Process.GetCurrentProcess().VirtualMemorySize64;
                        Console.WriteLine("线程编号{0}:占用本进程的虚拟内存{1}字节,{2}MB",++threadNum,
                            MemorySize,MemorySize/OneMB
                            );
                    }

                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("\n内存不足。己创建线程：{0}个", threadNum);
                    mre.Set();
                }
            }
        }
    }
}
