using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_8
{
    public class Example_8 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Context context = new Context();

            ArrayList list = new ArrayList();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach(AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
