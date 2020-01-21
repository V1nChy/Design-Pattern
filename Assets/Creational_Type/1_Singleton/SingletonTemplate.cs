//-------------------------------------------------------------------------------------
//	C#单例模板
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_1
{
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        private static T ms_instance = default(T);

        public static T Instance
        {
            get
            {
                if (ms_instance == null)
                {
                    ms_instance = new T();
                }
                return ms_instance;
            }
        }

        protected Singleton() { }
    }

    public class SingletonEx : Singleton<SingletonEx>
    {
        public SingletonEx()
        {
            Debug.Log("SingletonEx()");
        }

        public void DoSomething()
        {
            Debug.Log("SingletonEx:DoSomething()");
        }
    }
}