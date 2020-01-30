//-------------------------------------------------------------------------------------
//	C#原型模式
//  用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_5
{
    /// <summary>
    /// 'Prototype'原型抽象类
    /// </summary>
    public abstract class Prototype
    {
        protected int id;

        public Prototype(int id)
        {
            this.id = id;
        }

        public abstract object Cloen();
    }

    /// <summary>
    /// 'Prototype'具体实现类
    /// </summary>
    public class ConcreatePrototype1:Prototype
    {
        private string name;
        public ConcreatePrototype1(int id, string name):base(id)
        {
            this.name = name;
        }

        public override object Cloen()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("id = {0}, name = {1}", id, name);
        }
    }

    /// <summary>
    /// 'Prototype'具体实现类
    /// </summary>
    public class ConcreatePrototype2 : Prototype
    {
        private string type;
        public ConcreatePrototype2(int id, string type) : base(id)
        {
            this.type = type;
        }

        public override object Cloen()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("id = {0}, type = {1}", id, type);
        }
    }
}