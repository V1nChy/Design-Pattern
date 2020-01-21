//-------------------------------------------------------------------------------------
//	C#状态模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_13
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public void ChangeState(State s)
        {
            this.state = s;
            Debug.Log("Context:ChangeState() -> " + state.GetType().Name);
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.ChangeState(new ConcreteStateB());
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.ChangeState(new ConcreteStateA());
        }
    }
}
