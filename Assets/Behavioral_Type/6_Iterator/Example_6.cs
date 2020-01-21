using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_6
{
    public class Example_6 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            ConcreateAggregate a = new ConcreateAggregate();

            Iterator itor = a.CreateIterator();
            object item;
            while(itor.IsDone())
            {
                item = itor.CurrentItem();
                Debug.Log(item);
                itor.Next();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}