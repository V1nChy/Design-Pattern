using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_2
{
    public class Example_2 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            //简单工厂调用
            Product product;
            product = SimpleFactory.Create(ProductEnum.A);
            product.DoSomething();
            product = SimpleFactory.Create(ProductEnum.B);
            product.DoSomething();

            //工厂方法调用
            Factor[] factors = new Factor[2];
            factors[0] = new ConcreateFactorA();
            factors[1] = new ConcreateFactorB();
            for (int i = 0; i < factors.Length; i++)
            {
                product = factors[i].Create();
                product.DoSomething();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}