//-------------------------------------------------------------------------------------
//	C#享元模式
//  使用共享对象可有效地支持大量的细粒度的对象。
//-------------------------------------------------------------------------------------

using System.Collections;
using UnityEngine;

namespace Exampe_23
{
    public abstract class Flyweight
    {
        public abstract void Operation(ref string str);
    }

    public class ConcreteFlyweight:Flyweight
    {
        private string symbol;
        public ConcreteFlyweight(string symbol)
        {
            this.symbol = symbol;
        }

        public override void Operation(ref string str)
        {
            str += symbol;
            Debug.Log("ConcreteFlyweight:Operation() " + str);
        }
    }

    public class UnSharedConcreteFlyweight:Flyweight
    {
        private string symbol;
        public UnSharedConcreteFlyweight(string symbol)
        {
            this.symbol = symbol;
        }
        public override void Operation(ref string str)
        {
            str += symbol;
            Debug.Log("UnSharedConcreteFlyweight:Operation() " + str);
        }
    }

    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("+", new ConcreteFlyweight("+"));
            flyweights.Add("-", new ConcreteFlyweight("-"));
            flyweights.Add("*", new ConcreteFlyweight("*"));
        }

        public Flyweight GetFlyweight(string key)
        {
            if(flyweights.ContainsKey(key))
                return (Flyweight)flyweights[key];
            return null;
        }
    }
}