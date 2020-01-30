//-------------------------------------------------------------------------------------
//	C#桥梁模式
//  将抽象和实现解耦，使得两者可以独立地变化。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_20
{
    public abstract class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
    
    public class RefineAbstraction:Abstraction
    {
        public override void Operation()
        {
            Debug.Log("RefineAbstraction:Operation()");
            implementor.OperationImp();
        }
    }

    public abstract class Implementor
    {
        public abstract void OperationImp();
    }

    public class ConcreteImplementorA:Implementor
    {
        public override void OperationImp()
        {
            Debug.Log("ConcreteImplementorA:OperationImp()");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Debug.Log("ConcreteImplementorB:OperationImp()");
        }
    }
}