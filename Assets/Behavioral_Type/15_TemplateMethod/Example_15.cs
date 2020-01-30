using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_15
{
    public class Example_15 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();

            AbstractClass b = new ConcreteClassB();
            b.TemplateMethod();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}