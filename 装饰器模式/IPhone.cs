using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    public class IPhone: BaseThing
    {
        public override void ShowOff()
        {
            Console.WriteLine("苹果手机");
            base.ShowOff();
        }
    }
}