//-------------------------------------------------------------------------------------
//	C#建造者模式
//-------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Example_4
{
    /// <summary>
    /// ‘Product’具体实现类
    /// </summary>
    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Product Parts:\n");
            for(int i=0;i<parts.Count;i++)
            {
                sb.Append(parts[i]);
                if(i != (parts.Count-1))
                {
                    sb.Append(",");
                }
            }
            Debug.Log(sb.ToString());
        }
    }

    /// <summary>
    /// ‘Builder’抽象基类
    /// </summary>
    public abstract class Builder
    {
        protected abstract void BuildPart1();
        protected abstract void BuildPart2();
        public abstract Product BuildProduct();
    }

    /// <summary>
    /// ‘Builder’具体实现类
    /// </summary>
    public class ConcreateBuilder1:Builder
    {
        private Product product = new Product();
        protected override void BuildPart1()
        {
            product.Add("Part1");
        }

        protected override void BuildPart2()
        {
            product.Add("Part2");
        }

        public override Product BuildProduct()
        {
            this.BuildPart1();
            this.BuildPart2();
            return product;
        }
    }

    /// <summary>
    /// ‘Builder’具体实现类
    /// </summary>
    public class ConcreateBuilder2 : Builder
    {
        private Product product = new Product();
        protected override void BuildPart1()
        {
            product.Add("PartⅠ");
        }

        protected override void BuildPart2()
        {
            product.Add("PartⅡ");
        }

        public override Product BuildProduct()
        {
            this.BuildPart1();
            this.BuildPart2();
            return product;
        }
    }

    /// <summary>
    /// ‘Director’角色，一顿操作
    /// </summary>
    public class Director
    {
        public Product Construct(Builder builder)
        {
            return builder.BuildProduct();
        }
    }
}
