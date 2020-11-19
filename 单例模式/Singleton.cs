using System;

namespace 单例模式
{
    /// <summary>
    /// 
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 实例
        /// </summary>
        private static Singleton Instance { get; set; }

        /// <summary>
        /// 对象锁
        /// </summary>
        private static Object objLock=new object();

        /// <summary>
        /// 测试用
        /// </summary>
        public string Msg { get; set; } = "我还没有被赋值";

        /// <summary>
        /// 防止被实例化
        /// </summary>
        private Singleton() {
            Console.WriteLine("我被实例化了。");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (Instance is null)
            {
                lock (objLock)
                {
                    if (Instance is null)
                        Instance = new Singleton();
                }
            }
            return Instance;
        }
    }
}
