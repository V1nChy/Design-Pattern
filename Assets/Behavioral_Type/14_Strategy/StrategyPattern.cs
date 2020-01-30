//-------------------------------------------------------------------------------------
//	C#策略模式
//  定义一组算法，将每个算法都封装起来，并且使它们之间可以互换。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_14
{
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    public class ConcreteStrategyA:Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyA:AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyB:Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyB:AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyC:AlgorithmInterface()");
        }
    }

    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }
}