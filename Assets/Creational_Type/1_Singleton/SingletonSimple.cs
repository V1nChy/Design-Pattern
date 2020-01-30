//-------------------------------------------------------------------------------------
//	C#最简单的单例例子
//  确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_1
{
    public class SingletonSimple
    {
        private static SingletonSimple ms_instance;

        public static SingletonSimple Instance()
        {
            if (ms_instance == null)
            {
                ms_instance = new SingletonSimple();
            }

            return ms_instance;
        }

        protected SingletonSimple()
        {
            Debug.Log("SingletonSimple()");
        }
    }
}