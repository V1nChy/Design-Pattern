//-------------------------------------------------------------------------------------
//	C#责任链模式
//  使多个对象都有机会处理请求，从而避免了请求的发送者和接受者之间的耦合关系。将这些对象连成一条链，并沿着这条链传递该请求，直到有对象处理它为止。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_9
{
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler suc)
        {
            this.successor = suc;
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1:Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Debug.Log("ConcreateHandler1:HandleRequest() 处理请求:" + request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2:Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 10 && request < 20)
            {
                Debug.Log("ConcreateHandler2:HandleRequest() 处理请求:" + request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Debug.Log("ConcreateHandler2:HandleRequest() 处理请求:" + request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}