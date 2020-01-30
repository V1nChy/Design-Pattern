using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_21
{
    public class Example_21 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            dA.SetComponent(c);
            dB.SetComponent(dA);

            dB.Operation();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}