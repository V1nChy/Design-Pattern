using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_19
{
    public class Example_19 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}