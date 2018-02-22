using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Method1()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            int result = obj1.Method1(productList);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void Method2()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method2(new Product("potato", 10.2, 40, "ferous"));
            int count = obj1.Method1(productList);
            Assert.AreEqual(11, count);
        }
        [TestMethod]
        public void Method3()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method4("zucchini");
            obj1.Method4("brocolli");
            int count = obj1.Method1(productList);
            Assert.AreEqual(8, count);
        }
        [TestMethod]
        public void Method4()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method2(new Product("tomato", 50.2, 90, "feroussss"));
            int count = obj1.Method1(productList);
            Assert.AreEqual(11, count);

        }
        [TestMethod]
        public void Method5()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method2(new Product("potato", 10.2, 40, "ferous"));
            int counter = productList.Count;
            int find = productList.FindIndex(x => x.name == "potato");

            Assert.AreEqual(find, 10);
        }
        [TestMethod]
        public void Method6()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            var result = obj1.Method3("Cruciferous");
            int count = result.Count;
            Assert.AreEqual(count, 3);
        }
        [TestMethod]
        public void Method7()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            int marker = 0;
            var ant = obj1.Method3("marrow");
            foreach (var i in ant)
            {
                if (i.type == "marrow")
                {
                    marker = 1;
                }
                else
                {
                    marker = 0;
                }
            }
            Assert.AreEqual(marker, 1);
        }
        [TestMethod]
        public void Method8()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method4("pumpkin");
            int count = obj1.Method1(productList);
            Assert.AreEqual(9, count);
        }
        [TestMethod]
        public void Method9()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            obj1.Method4("cabbage");
            int marker = 0;
            foreach (var i in productList)
            {
                if (i.name != "cabbage")
                {
                    marker = 1;
                }
                else
                {
                    marker = 0;
                }
            }
            Assert.AreEqual(marker, 1);
        }
        [TestMethod]
        public void Method10()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            ProductRepository obj1 = new ProductRepository(productList);
            double price = obj1.Method5("pumpkin",40);
            double x = 30 * 40;
            Assert.AreEqual(x, price);
        }
    }
}

