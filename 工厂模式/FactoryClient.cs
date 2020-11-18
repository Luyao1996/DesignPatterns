using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace 工厂模式
{
    /// <summary>
    /// 工厂客户端
    /// </summary>
    public static class SuperFactory
    {
        /// <summary>
        /// 定义一个容器来储存所有的类型
        /// string：类型命名空间
        /// Type:具体的类型
        /// </summary>
        private static Dictionary<string,Type> DicInstance;

        /// <summary>
        /// 初始化容器
        /// </summary>
        static SuperFactory()
        {
            IOCBuilder();//初始化类容器DicInstance
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <param name="classNamespace"></param>
        /// <returns></returns>
        public static object GetInstance(string classNamespace)
        {
            //如果字典里不存在则直接返回null
            if (!DicInstance.ContainsKey(classNamespace))
                return null;

            //获取到具体的类型
            var res = DicInstance[classNamespace];
            //创建并返回类型的实例
            return res.Assembly.CreateInstance(res.FullName);
        }

        /// <summary>
        /// 找到所有子类
        /// </summary>
        /// <returns></returns>
        private static void IOCBuilder()
        {
            DicInstance ??= new Dictionary<string, Type>();

            //获取顶层接口类型
            var parentType = typeof(IBase);
            //反射获取parentType所在程序集的所有类
            var assemTypes = Assembly.GetAssembly(parentType).GetTypes();
            foreach (Type tChild in assemTypes)
            {
                //如果当前类没有继承IBase接口 则跳过
                if (!tChild.GetInterfaces().Contains(parentType))
                    continue;
                //如果当前类已经被注入到容器中 则跳过
                if (DicInstance.ContainsKey(tChild.FullName))
                    continue;

                //注入容器
                DicInstance.Add(tChild.FullName, tChild);
            }
        }
    }
}
