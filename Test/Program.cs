using 单例模式;
using 工厂模式;
using 装饰器模式;

//System.Console.WriteLine("Hello C#9");
System.Console.WriteLine("-------------------------------------------------超级工厂模式-----------------------------------------------------");

//超级工厂模式
SuperFactory.GetInstance("工厂模式.WebMaker");
SuperFactory.GetInstance("工厂模式.Apple");

System.Console.WriteLine("-----------------------------------------------------单例-------------------------------------------------");

//单例
var single1 = Singleton.GetInstance();
single1.Msg = "我是被single1赋值的";
var single2 = Singleton.GetInstance();
System.Console.WriteLine(single2.Msg);

System.Console.WriteLine("---------------------------------------------------装饰器模式---------------------------------------------------");

//装饰器模式
Me me = new Me("老子");
IPhone ip = new IPhone();
Grilfriend gf = new Grilfriend();
House hs = new House();

//开始装饰
ip.Something(me);
gf.Something(ip);
hs.Something(gf);
//展示
hs.ShowOff();


System.Console.WriteLine("------------------------------------------------------------------------------------------------------");





//单例模式：保证当前类只有一个实例
//工厂模式：下游代码无需手动创建实例，所有类的实例都由工厂来创建
//观察者模式：类似触发器，类A发生某个动作时，所有订阅类A的类都会做出自己的动作
//装饰器模式：在不改变原始类的前提下，为原始类添加新得职责




