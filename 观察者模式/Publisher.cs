using System;

namespace 观察者模式
{
    /// <summary>
    /// 发布者
    /// </summary>
    public static class Publisher
    {
        private static Action Client { get; set; }

        static Publisher()
        {
            Client += () => Console.WriteLine("我是主线程通知");
        }

        public static void Subscribe(Action act)
        {
            Client += act;
        }

        public static void DisSubscribe(Action act)
        {
            Client -= act;
        }

        public static void GoNotice()
        {
            Client();
        }

        public static int GetClientCount()
        {
            return Client.GetInvocationList().Length;
        }
    }
}
