//-------------------------------------------------------------------------------------
//	C#解释器模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_8
{
    /// <summary>
    /// 'Context' 信息类
    /// </summary>
    public class Context
    {

    }

    /// <summary>
    /// 'AbstractExpression' 抽象基类
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    public class TerminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Debug.Log("TerminalExpression:Interpret()");
        }
    }

    public class NonterminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Debug.Log("NonterminalExpression:Interpret()");
        }
    }
}
