using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Enum;
using DemoApp.Util;
using Newtonsoft.Json;

namespace DemoApp
{
    class Program
    {
        public static string name = string.Empty;
        public static int age = 0;

        static void Main(string[] args)
        {
            name = GetName("kuo", "liu");
            age = GetAge(30);

            Console.WriteLine("姓名：" + name + " 年龄：" + age);

            Console.WriteLine(TestSerializeAnonymousType());

            HttpHelper.Get();

            Console.WriteLine("测试枚举：" + MyEnum.Monday);
            Console.ReadLine();
        }

        private static string GetName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        private static int GetAge(int age)
        {
            return age + 5;
        }

        public static string TestSerializeAnonymousType()
        {
            var test = new
            {
                name = name,
                age = age,
                hobby = "football"
            };
            return "匿名类型序列化结果：" + JsonConvert.SerializeObject(test);
        }
    }
}
