using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂模式
{
    /// <summary>
    /// 销售人员
    /// </summary>
    public class WebMaker : IHuman
    {
        public WebMaker()
        {
            Console.WriteLine("您好，我是一个web开发人员");
        }
    }
}
