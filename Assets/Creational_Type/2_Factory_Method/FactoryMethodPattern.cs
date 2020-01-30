//-------------------------------------------------------------------------------------
//	C#工厂方法模式
//  定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_2
{
    /// <summary>
    /// 'Product'抽象基类
    /// </summary>
    public abstract class Product
    {
        protected string name;

        public virtual void DoSomething()
        {
            Debug.Log("Product:DoSomething(), i`m " + name);
        }
    }

    /// <summary>
    /// 'Product'具体实现类
    /// </summary>
    public class ConcreateProductA : Product
    {
        public ConcreateProductA()
        {
            Debug.Log("ConcreateProductA()");
            name = "ConcreateProductA";
        }
    }

    /// <summary>
    /// 'Product'具体实现类
    /// </summary>
    public class ConcreateProductB : Product
    {
        public ConcreateProductB()
        {
            Debug.Log("ConcreateProductB()");
            name = "ConcreateProductB";
        }
    }

    /// <summary>
    /// 'Creator'工厂抽象基类
    /// </summary>
    public abstract class Factor
    {
        public abstract Product Create();
    }

    public class ConcreateFactorA : Factor
    {
        public override Product Create()
        {
            Debug.Log("ConcreateFactorA:Create()");
            return new ConcreateProductA();
        }
    }

    public class ConcreateFactorB : Factor
    {
        public override Product Create()
        {
            Debug.Log("ConcreateFactorB:Create()");
            return new ConcreateProductB();
        }
    }
}