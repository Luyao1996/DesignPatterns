using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    public class Apple: IFruit
    {
        public Apple()
        {
            Console.WriteLine("我是一个苹果");
        }
    }
}
