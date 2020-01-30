//-------------------------------------------------------------------------------------
//	C#迭代器模式
//  提供一种方法访问一个容器对象中各个元素，而又不需暴露该对象的内部细节。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_6
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public class ConcreateIterator : Iterator
    {
        private ConcreateAggregate aggregate;
        private int current;

        public ConcreateIterator(ConcreateAggregate aggregate)
        {
            this.aggregate = aggregate;
            this.current = 0;
        }

        public override object CurrentItem()
        {
            return aggregate.GetElement(current);
        }

        public override object First()
        {
            return aggregate.GetElement(0);
        }

        public override bool IsDone()
        {
            if (current < aggregate.Count)
                return true;
            return false;
        }

        public override void Next()
        {   
            if (current < aggregate.Count)
            {
                current++;
            }
        }
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreateAggregate : Aggregate
    {
        private string[] items;

        public ConcreateAggregate()
        {
            items = new string[] {"Item A","Item B","Item C","Item D" };
        }

        public override Iterator CreateIterator()
        {
            return new ConcreateIterator(this);
        }

        public int Count
        {
            get { return items.Length; }
        }

        public string GetElement(int index)
        {
            return items[index];
        }
    }
}
