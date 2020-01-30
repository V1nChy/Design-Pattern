//-------------------------------------------------------------------------------------
//	C#组合模式
//  将对象组合成树形结构以表示“部分-整体”的层次结构，使得用户对单个对象和组合对象的使用具有一致性。
//-------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Exampe_18
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    public class Composite:Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name):base(name)
        {

        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Debug.Log(new String('-', depth) + name);
            foreach (Component component in children)
            {
                component.Display(depth + 1);
            }
        }
    }

    public class Leaf:Component
    {
        public Leaf(string name):base(name)
        {

        }

        public override void Add(Component c)
        {
            Debug.Log("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Debug.Log("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Debug.Log(new String('-', depth) + name);
        }
    }
}