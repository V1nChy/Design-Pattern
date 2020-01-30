//-------------------------------------------------------------------------------------
//	C#备忘录模式
//  在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到原先保存的状态。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_12
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }

    }

    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }
    }

    public class Caretaker
    {
        private Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
