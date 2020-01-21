//-------------------------------------------------------------------------------------
//	C#简单工厂模式
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_2
{
    public enum ProductEnum { A, B }

    public static class SimpleFactory
    {

        public static Product Create(ProductEnum productType)
        {
            Debug.Log("SimpleFactory:Create(), productType = " + productType.ToString());
            switch (productType)
            {
                case ProductEnum.A:
                    return new ConcreateProductA();
                case ProductEnum.B:
                    return new ConcreateProductB();
            }
            return null;
        }
    }
}
