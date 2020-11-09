using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNum = 1;
            myNum++;

            Person p = new Person
            {
                Name = "张三",
                Age = 30
            };

            //int[] nums = new int[5];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}


            var nums = new int[] { 0, 1, 2, 3, 4 };

            var list = new List<int> { 1, 2, 3, 4, 5, 6 };

            var dict = new Dictionary<int, string> 
            { 
                { 1, "test1" }, { 2, "test2" } 
            };

            var obj1 = new { Name = "张三", Age = 30 };
            var obj2 = new { Name = "李四", Age = 40 };
           
            //输出：true
            Console.WriteLine(obj1.GetType() == obj2.GetType());
            //输出：<>f__AnonymousType0`2[System.String,System.Int32]
            Console.WriteLine(obj1.GetType());
            //输出：Name:张三 Age:30
            Console.WriteLine("Name:{0} Age:{1}", obj1.Name, obj1.Age);
          

            dynamic test = "string";
            //输出：System.String
            Console.WriteLine(test.GetType());
            test = 100;
            //输出：System.Int32
            Console.WriteLine(test.GetType());

            dynamic myBag=new ExpandoObject();
            myBag.intValue = 100;
            myBag.message = "hello";
            Action<string> act= (str) => { Console.WriteLine(str); };
            myBag.say = act;

            //200
            Console.WriteLine("{0}",myBag.intValue*2);
            //HELLO
            Console.WriteLine(myBag.message.ToUpper());
            //Hello
            myBag.say("Hello");

            Console.ReadKey();
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
    namespace version1
    {

        class MyClass
        {
            private int _value;
            public int GetValue()
            {
                return _value;
            }
            public void SetValue(int value)
            {
                _value = value;
            }
        }
    }
    namespace version2
    {
        class MyClass
        {
            private int _value;
            public int Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }
        }
    }

    namespace version3
    {
        class MyClass
        {
            public int Value { get; set; }
        }
    }

}
