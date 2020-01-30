using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_22
{
    public class Example_22 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}