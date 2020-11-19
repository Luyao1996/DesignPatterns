using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    public class Grilfriend:BaseThing
    {
        public override void ShowOff()
        {
            Console.WriteLine("女朋友");
            base.ShowOff();
        }
    }
}
