using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ProductRepository
    {
        List<Product> productList = new List<Product>();
        public ProductRepository(List<Product> productList)
        {
            this.productList = productList;
        }
        public int Method1(List<Product> productList)
        {
            return productList.Count;
        }
        public List<Product> Method2(Product p)
        {
            productList.Add(new Product("potato", 10.2, 25, "ferous"));
            return productList;
        }
        public List<Product> Method3(String type)
        {
            var typecheck = productList.Where(c => c.type == type).ToList();
            return typecheck;
        }
        public List<Product> Method4(String name)
        {
            int counter = productList.Count;
            for(int i=0;i<counter;i++)
            {
                if(productList[i].name==name)
                {
                    productList.RemoveAt(i);
                    break;
                }
            }
            return productList;
        }
        public double Method5(String name,int quantity)
        {
            double tp = 0;
            foreach (var item in productList)
            {
               
                if (item.name == name)
                    tp += (item.price * quantity);
            }
            return tp;
        }
    }
}
