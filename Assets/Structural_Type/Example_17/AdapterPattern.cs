//-------------------------------------------------------------------------------------
//	C#适配器模式
//  将一个类的接口变换成客户端所期待的另一种接口，从而使原本因接口不匹配而无法在一起工作的两个类能够在一起工作。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_17
{
    public class Target
    {
        public virtual void Request()
        {
            Debug.Log("Target:Request()");
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Debug.Log("Adaptee:SpecificRequest()");
        }
    }

    public class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
            Debug.Log("Adapter:Request()");
        }
    }
}