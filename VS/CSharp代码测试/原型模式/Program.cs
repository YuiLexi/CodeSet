using System;
namespace 原型模式
{
    // 测试原型模式
    public class Program
    {
        public static void Main()
        {
            // 创建一个原型对象
            var prototype = new Prototype(1);

            // 克隆原型对象
            var clone = (Prototype)prototype.Clone();

            // 比较两个对象的Id属性
            Console.WriteLine(prototype.Id == clone.Id); // 输出 true
        }
    }
}
