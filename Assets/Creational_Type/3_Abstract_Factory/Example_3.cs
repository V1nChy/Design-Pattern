using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_3
{
    public class Example_3 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Factory factory;

            factory = new ConcreateFactory1();
            Client client1 = new Client(factory);
            client1.Run();

            factory = new ConcreateFactory2();
            Client client2 = new Client(factory);
            client2.Run();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
