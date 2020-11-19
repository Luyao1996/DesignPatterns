using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    public class House:BaseThing
    {
        public override void ShowOff()
        {
            Console.WriteLine("房子");
            base.ShowOff();
        }
    }
}
