using System;
using System.Threading;
using System.Threading.Tasks;
using 观察者模式;

Console.WriteLine("注册事件");


//Task.Run(()=>{
//    while (true)
//    {
//        Console.WriteLine($"当前客户端数量：{Publisher.GetClientCount()}");
//        Thread.Sleep(5000);
//    }
//});

while (true)
{
    var cr = Console.ReadLine();
    if (cr is "notice")
    {
        Console.WriteLine("开始通知客户端");
        Publisher.GoNotice();
    }

    Thread.Sleep(500);
}