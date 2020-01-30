//-------------------------------------------------------------------------------------
//	C#访问者模式
//  封装一些作用于某种数据结构中的各元素的操作，它可以在不改变数据结构的前提下定义作用于这些元素的新的操作。
//-------------------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace Exampe_16
{
    public abstract class Visitor
    {
        public abstract void VisitorConcrateElementA(ConcreteElementA concreteElementA);
        public abstract void VisitorConcrateElementB(ConcreteElementB concreteElementB);
    }

    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitorConcrateElementA(ConcreteElementA concreteElementA)
        {
            Debug.Log("ConcreteVisitor1:VisitorConcrateElementA() visit" + concreteElementA.GetType().Name);
        }

        public override void VisitorConcrateElementB(ConcreteElementB concreteElementB)
        {
            Debug.Log("ConcreteVisitor1:VisitorConcrateElementA() visit" + concreteElementB.GetType().Name);
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitorConcrateElementA(ConcreteElementA concreteElementA)
        {
            Debug.Log("ConcreteVisitor2:VisitorConcrateElementA() visit" + concreteElementA.GetType().Name);
        }

        public override void VisitorConcrateElementB(ConcreteElementB concreteElementB)
        {
            Debug.Log("ConcreteVisitor2:VisitorConcrateElementA() visit" + concreteElementB.GetType().Name);
        }
    }


    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    public class ConcreteElementA:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcrateElementA(this);
        }
    }

    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcrateElementB(this);
        }
    }

    public class ObjectStructure
    {
        private List<Element> elements = new List<Element>();

        public void Attach(Element ele)
        {
            elements.Add(ele);
        }

        public void Detach(Element ele)
        {
            elements.Remove(ele);
        }

        public void Accept(Visitor visitor)
        {
            foreach(Element ele in elements)
            {
                ele.Accept(visitor);
            }
        }
    }
}