//-------------------------------------------------------------------------------------
//	C#命令模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_7
{
    /// <summary>
    /// 'Receiver'角色类
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Debug.Log("Receiver:Action()");
        }
    }

    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver rec)
        {
            this.receiver = rec;
        }

        public abstract void Execute();
    }

    public class ConcreateCommand:Command
    {
        public ConcreateCommand(Receiver rev):base(rev)
        {
        }

        public override void Execute()
        {
            this.receiver.Action();
        }
    }

    public class Invoker
    {
        private Command command;

        public void SetCommand(Command cmd)
        {
            this.command = cmd;
        }

        public void ExecuteCmd()
        {
            this.command.Execute();
        }
    }
}
