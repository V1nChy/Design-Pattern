//-------------------------------------------------------------------------------------
//	C#模板方法模式
//  定义一个操作中算法的框架，而将一些步骤延迟到子类中。使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_15
{
    public abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            Debug.Log("AbstractClass:TemplateMethod()");
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
    }

    public class ConcreteClassA:AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteClassA:PrimitiveOperation1()");
        }

        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteClassA:PrimitiveOperation2()");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteClassB:PrimitiveOperation1()");
        }

        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteClassB:PrimitiveOperation2()");
        }
    }
}