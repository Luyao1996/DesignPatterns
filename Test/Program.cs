using 单例模式;
using 工厂模式;

//System.Console.WriteLine("Hello C#9");
System.Console.WriteLine("------------------------------------------------------------------------------------------------------");

//超级工厂模式
SuperFactory.GetInstance("工厂模式.WebMaker");
SuperFactory.GetInstance("工厂模式.Apple");

System.Console.WriteLine("------------------------------------------------------------------------------------------------------");

//单例
var single1 = Singleton.GetInstance();
single1.Msg = "我是被single1赋值的";
var single2 = Singleton.GetInstance();
System.Console.WriteLine(single2.Msg);

System.Console.WriteLine("------------------------------------------------------------------------------------------------------");






