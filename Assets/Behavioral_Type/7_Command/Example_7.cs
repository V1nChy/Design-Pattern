using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_7
{
    public class Example_7 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Receiver rev = new Receiver();
            Command cmd = new ConcreateCommand(rev);
            Invoker inv = new Invoker();

            inv.SetCommand(cmd);
            inv.ExecuteCmd();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}