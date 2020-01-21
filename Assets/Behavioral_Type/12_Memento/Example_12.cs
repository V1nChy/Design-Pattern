using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example_12
{
    public class Example_12 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Originator o = new Originator();
            o.State = "On";

            // 保存一份备份数据
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // 原数据被改变
            o.State = "off";

            // 使用备份还原
            o.SetMemento(c.Memento);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}