using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_5
{
    public class Example_5 : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            ConcreatePrototype1 cp1 = new ConcreatePrototype1(1, "name");
            ConcreatePrototype1 clone1 = (ConcreatePrototype1)cp1.Cloen();
            Debug.Log(clone1.ToString());

            ConcreatePrototype2 cp2 = new ConcreatePrototype2(2, "type");
            ConcreatePrototype2 clone2 = (ConcreatePrototype2)cp2.Cloen();
            Debug.Log(clone2.ToString());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}