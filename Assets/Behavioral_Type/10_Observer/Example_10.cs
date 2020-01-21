using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_10
{
    public class Example_10 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "小红"));
            subject.Attach(new ConcreteObserver(subject, "小蓝"));
            subject.Attach(new ConcreteObserver(subject, "小绿"));

            subject.SubjectState = "上课";
            subject.Notify();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}