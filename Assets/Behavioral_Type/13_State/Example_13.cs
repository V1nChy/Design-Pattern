using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_13
{
    public class Example_13 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}