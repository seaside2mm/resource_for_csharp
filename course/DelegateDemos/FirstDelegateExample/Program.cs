using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDelegateExample
{
    /// <summary>
    /// 这是一个普通的类，它定义了一个将被委托变量接收的方法
    /// </summary>
    public class MathOpt
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    /// <summary>
    /// 定义一个委托类型，它有两个int类型的参数，返回一个int类型的数值
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns></returns>
    public delegate int MathOptDelegate(int value1, int value2);

    class Program
    {
        static void Main(string[] args)
        {
            //委托是一种用户自定义的数据类型，可以用于定义变量
            MathOptDelegate oppDel;
            MathOpt obj = new MathOpt();
            //委托变量可以接收一个方法引用
            oppDel = obj.Add;
            //委托变量可以当成函数那样调用
            Console.WriteLine(oppDel(1, 2)); //输出 3
            Console.ReadKey();
        }
    }
}
