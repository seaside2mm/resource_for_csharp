using System;

namespace UseEventExample
{
    //定义事件委托
    public delegate void MyEventDelegate(int value);

    //事件发布者类
    public class Publisher
    {
        //使用C#的event关键字定义一个事件
        public event MyEventDelegate MyEvent;
        //激发事件
        public void FireEvent(int EventArgu)
        {
            if (MyEvent != null)
            {
                MyEvent(EventArgu);
            }
        }
    }


    //事件响应者类
    public class Subscriber
    {
        //事件处理函数
        public void MyMethod(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            //挂接事件响应代码
            p.MyEvent += s1.MyMethod;
            p.MyEvent += s2.MyMethod;


            //委托变量MyEvent前有一个event关键字，
            //所以无法直接调用Publisher类的MyEvent方法
            //以下代码无法通过编译
            //p.MyEvent(100);

            //只能通过Publisher类的公有方法间接地触发事件
            p.FireEvent(10);

            Console.ReadKey();

        }
    }
}
