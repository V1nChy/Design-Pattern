//-------------------------------------------------------------------------------------
//	C#中介者模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_11
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague clg);
    }

    public class ConcreteMediator:Mediator
    {
        private ConcreteColleague1 clg1;
        private ConcreteColleague2 clg2;

        public ConcreteColleague1 Colleague1
        {
            set { clg1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { clg2 = value; }
        }

        public override void Send(string msg, Colleague clg)
        {
            if(clg == clg1)
            {
                clg2.Receive(msg);
            }
            else
            {
                clg1.Receive(msg);
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator me)
        {
            this.mediator = me;
        }
    }

    public class ConcreteColleague1:Colleague
    {
        public ConcreteColleague1(Mediator mediator): base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Debug.Log("ConcreteColleague1: Receive() " + message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator): base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Debug.Log("ConcreteColleague2:Receive() " + message);
        }
    }
}