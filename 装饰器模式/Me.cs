using System;

namespace 装饰器模式
{
    public class Me
    {
        private string Name { get; set; }

        public Me() { }
        public Me(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 炫耀
        /// </summary>
        public virtual void ShowOff()
        {
            Console.WriteLine($"上面的东西{this.Name}全都有");
        }
    }
}
