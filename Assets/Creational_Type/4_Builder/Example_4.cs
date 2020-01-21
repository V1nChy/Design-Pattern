using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_4
{
    public class Example_4 : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            Director director = new Director();
            Builder builder;

            builder = new ConcreateBuilder1();
            Product product1 = director.Construct(builder);
            product1.Show();

            builder = new ConcreateBuilder2();
            Product product2 = director.Construct(builder);
            product2.Show();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
