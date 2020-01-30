using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_17
{
    public class Example_17 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Target target = new Adapter();
            target.Request();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}