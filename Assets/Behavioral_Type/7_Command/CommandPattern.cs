//-------------------------------------------------------------------------------------
//	C#命令模式
//  把一个请求或者操作封装在命令对象中。命令模式允许系统使用不同的请求把客户端参数化，对请求排队或者记录请求日志，可以提供命令的撤销和恢复功能。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_7
{
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
