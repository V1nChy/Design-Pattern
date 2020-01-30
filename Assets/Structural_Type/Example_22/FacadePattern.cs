//-------------------------------------------------------------------------------------
//	C#外观模式
//  要求一个子系统的外部与其内部的通信必须通过一个统一的对象进行。门面模式提供一个高层次的接口，使得子系统更易于使用。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_22
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Debug.Log("SubSystemOne:MethodOne()");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Debug.Log("SubSystemTwo:MethodTwo()");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Debug.Log("SubSystemThree:MethodThree()");
        }
    }

    public class SubSystemFour
    {
        public void MethodFour()
        {
            Debug.Log("SubSystemFour:MethodFour()");
        }
    }

    public class Facade
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;
        private SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Debug.Log("Facade:MethodA()");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Debug.Log("Facade:MethodB()");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}