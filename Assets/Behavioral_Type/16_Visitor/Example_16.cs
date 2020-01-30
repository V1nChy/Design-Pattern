using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_16
{
    public class Example_16 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            ObjectStructure os = new ObjectStructure();
            os.Attach(new ConcreteElementA());
            os.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 V2 = new ConcreteVisitor2();

            os.Accept(v1);
            os.Accept(V2);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}