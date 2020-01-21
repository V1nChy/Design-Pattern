using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_1
{
    public class Example_1 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            SingletonSimple s1 = SingletonSimple.Instance();
            SingletonSimple s2 = SingletonSimple.Instance();
            if (s1 == s2)
            {
                Debug.Log("Objects are the same instance");
            }
            SingletonEx.Instance.DoSomething();

            MonoSingletonEx.Instance.DoSomething();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
