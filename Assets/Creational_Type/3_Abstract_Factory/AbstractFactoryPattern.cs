//-------------------------------------------------------------------------------------
//	C#抽象工厂模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_3
{
    /// <summary>
    /// 'ProductA'抽象基类
    /// </summary>
    public abstract class ProductA
    {
        public string name;
    }

    /// <summary>
    /// 'ProductB'抽象基类，并且它是与'ProductA'相关联的
    /// </summary>
    public abstract class ProductB
    {
        public string name;
        public abstract void Interact(ProductA a);
    }

    /// <summary>
    /// 'ProductA'具体实现类
    /// </summary>
    public class ConcreateProductA1 : ProductA
    {
        public ConcreateProductA1()
        {
            name = "ConcreateProductA1";
        }
    }
    /// <summary>
    /// 'ProductA'具体实现类
    /// </summary>
    public class ConcreateProductA2 : ProductA
    {
        public ConcreateProductA2()
        {
            name = "ConcreateProductA2";
        }
    }

    /// <summary>
    /// 'ProductB'具体实现类, 实现与'ProductA'关联逻辑
    /// </summary>
    public class ConcreateProductB1:ProductB
    {
        public ConcreateProductB1()
        {
            name = "ConcreateProductB1";
        }

        public override void Interact(ProductA a)
        {
            Debug.Log(name + " interacts with " + a.name);
        }
    }
    /// <summary>
    /// 'ProductB'具体实现类, 实现与'ProductA'关联逻辑
    /// </summary>
    public class ConcreateProductB2 : ProductB
    {
        public ConcreateProductB2()
        {
            name = "ConcreateProductB2";
        }

        public override void Interact(ProductA a)
        {
            Debug.Log(name + " interacts with " + a.name);
        }
    }

    /// <summary>
    /// 'Factory'抽象基类
    /// </summary>
    public abstract class Factory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();
    }

    /// <summary>
    /// 'Factory'具体实现类，创造的'ProductA'与'ProductB'是相互关联的
    /// </summary>
    public class ConcreateFactory1:Factory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreateProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreateProductB1();
        }
    }
    /// <summary>
    /// 'Factory'具体实现类，创造的'ProductA'与'ProductB'是相互关联的
    /// </summary>
    public class ConcreateFactory2 : Factory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreateProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreateProductB2();
        }
    }

    /// <summary>
    /// 模拟上下文调用
    /// </summary>
    public class Client
    {
        private ProductA productA;
        private ProductB productB;

        public Client(Factory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void Run()
        {
            productB.Interact(productA);
        }
    }
}
