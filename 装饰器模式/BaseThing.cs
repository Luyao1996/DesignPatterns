using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    /// <summary>
    /// 东西基类
    /// </summary>
    public class BaseThing:Me
    {
        public Me MyThing { get; set; }

        public void Something(Me myThing)
        {
            this.MyThing = myThing;
        }

        public override void ShowOff()
        {
            if (MyThing != null)
            {
                MyThing.ShowOff();
            }
        }
    }
}
