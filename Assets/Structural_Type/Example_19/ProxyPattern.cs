//-------------------------------------------------------------------------------------
//	C#代理模式
//  为其他对象提供一种代理以控制对这个对象的访问。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Exampe_19
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject:Subject
    {
        public override void Request()
        {
            Debug.Log("RealSubject:Request()");
        }
    }

    public class Proxy:Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
            Debug.Log("Proxy:Request()");
        }
    }
}