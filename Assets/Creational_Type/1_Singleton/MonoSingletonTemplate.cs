//-------------------------------------------------------------------------------------
//	Unity MonoBehaviour的单例模板
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_1
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T ms_instance;
        public static T Instance
        {
            get
            {
                if (ms_instance == null)
                {
                    ms_instance = Instantiate();
                }

                return ms_instance;
            }
        }

        protected static T Instantiate()
        {
            if (ms_instance == null)
            {
                ms_instance = GameObject.FindObjectOfType<T>();
                if (ms_instance != null)
                    return ms_instance;

                if (ms_instance == null)
                {
                    GameObject singleton = new GameObject("[Singleton]" + typeof(T).Name);
                    if (singleton != null)
                    {
                        ms_instance = singleton.AddComponent<T>();
                        ms_instance.InitSingleton();
                    }
                }
            }

            return ms_instance;
        }

        protected virtual void InitSingleton()
        {

        }

        private void Awake()
        {
            if (ms_instance == null)
            {
                ms_instance = this as T;
            }
        }

        public void OnApplicationQuit()
        {
            ms_instance = null;
        }
    }
}
