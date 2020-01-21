//-------------------------------------------------------------------------------------
//	C#观察者模式
//-------------------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace Example_10
{
    /// <summary>
    /// ‘Observer’角色抽象基类
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver:Observer
    {
        private string name;
        private string state;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
            this.state = "";
        }
        public override void Update()
        {
            this.state = this.subject.SubjectState;
            Debug.Log("Observer = " + this.name + ", state = " + state);
        }
    }

    /// <summary>
    /// ‘Subject’角色抽象基类
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer ob)
        {
            observers.Add(ob);
        }

        public void Detach(Observer ob)
        {
            observers.Remove(ob);
        }

        public void Notify()
        {
            foreach(Observer ob in observers)
            {
                ob.Update();
            }
        }
    }

    public class ConcreteSubject:Subject
    {
        private string state;

        public string SubjectState
        {
            get { return state; }
            set { state = value; }
        }
    }
}