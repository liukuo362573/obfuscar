using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DemoApp;
using DemoApp.Model;

namespace DemoApp.Util
{
    public class HttpHelper
    {
        public static void Get()
        {
            Console.Write("HttpHelper.Get 测试结果:");
            MyModel model = new MyModel
            {
                Name = "Obfuscar",
                Age = 1
            };
            var result = JsonConvert.SerializeObject(model);
            Console.WriteLine(result);
        }
    }
}

