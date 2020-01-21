using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_11
{
    public class Example_11 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 clg1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 clg2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = clg1;
            mediator.Colleague2 = clg2;

            clg1.Send("Are you ok?");
            clg2.Send("OK!");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}