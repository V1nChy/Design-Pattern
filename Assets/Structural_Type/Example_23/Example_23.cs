using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_23
{
    public class Example_23 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            string str = "";

            FlyweightFactory factory = new FlyweightFactory();
            Flyweight fw;

            fw = factory.GetFlyweight("+");
            fw.Operation(ref str);

            fw = factory.GetFlyweight("-");
            fw.Operation(ref str);

            fw = factory.GetFlyweight("*");
            fw.Operation(ref str);

            UnSharedConcreteFlyweight fu = new UnSharedConcreteFlyweight("/");
            fu.Operation(ref str);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}