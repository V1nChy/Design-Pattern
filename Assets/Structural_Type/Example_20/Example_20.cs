using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_20
{
    public class Example_20 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Abstraction ab = new RefineAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}