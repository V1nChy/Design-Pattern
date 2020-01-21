//-------------------------------------------------------------------------------------
//	C#备忘录模式
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
