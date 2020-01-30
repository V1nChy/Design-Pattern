//-------------------------------------------------------------------------------------
//	C#装饰者模式
//  动态地给一个对象添加一些额外的职责。就增加功能来说，装饰模式相比生成子类更为灵活。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_21
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Debug.Log("ConcreteComponent:Operation()");
        }
    }

    public abstract class Decorator:Component
    {
        protected Component component;

        public void SetComponent(Component comp)
        {
            this.component = comp;
        }

        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }

    public class ConcreteDecoratorA:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Debug.Log("ConcreteDecoratorA:Operation()");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Debug.Log("ConcreteDecoratorB:Operation()");
        }

        private void AddedBehavior()
        {
            Debug.Log("ConcreteDecoratorB:AddedBehavior()");
        }
    }
}