//-------------------------------------------------------------------------------------
//	C#解释器模式
//  给定一种语言，定义它的文法的一种表示，并定义一个解释器，该解释器使用该表示来解释语言中的句子。
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
