using UnityEngine;

namespace Example_1
{
    public class MonoSingletonEx : MonoSingleton<MonoSingletonEx>
    {
        protected override void InitSingleton()
        {
            Debug.Log("MonoSingletonEx:InitSingleton()");
        }

        public void DoSomething()
        {
            Debug.Log("MonoSingletonEx:DoSomething()");
        }
    }
}
