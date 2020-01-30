using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_18
{
    public class Example_18 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}