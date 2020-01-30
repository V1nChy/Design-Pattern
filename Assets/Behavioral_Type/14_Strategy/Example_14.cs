using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_14
{
    public class Example_14 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
