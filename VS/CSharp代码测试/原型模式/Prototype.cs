using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    internal class Prototype : ICloneable
    {
        public int Id { get; set; }
        public Prototype(int id)
        {
            Id = id;
        }
        // 实现ICloneable接口的Clone方法
        public object Clone()
        {
            return new Prototype(Id);
        }
    }
}
