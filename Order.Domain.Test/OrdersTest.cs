using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Order.Domain.Test
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod]
        public void TotalTest_10Threeand30Four_Return150()
        {
            //实例化 customer 对象
            Customer cs = new Customer()
            {
                Name = "Test",
                Tel = "Test",
                Address = "Test"
            };

            //实例化订单对象
            Orders ord = new Orders(cs);

            //实例化订单项    所属订单、商品、单价、数量
            OrderItem orderItem1 = new OrderItem(ord, new Product() { Name = "Test", Price = 10 }, 3);
            OrderItem orderItem2 = new OrderItem(ord, new Product() { Name = "Test", Price = 30 }, 4);

            var expected = 150.0;

            //action
            var actual = ord.Total();

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void TotalTest_130Threeand320Four_Return1670()
        {
            //实例化 customer 对象
            Customer cs = new Customer()
            {
                Name = "Test",
                Tel = "Test",
                Address = "Test"
            };

            //实例化订单对象
            Orders ord = new Orders(cs);

            //实例化订单项    所属订单、商品、单价、数量
            OrderItem orderItem1 = new OrderItem(ord, new Product() { Name = "Test", Price = 130 }, 3);
            OrderItem orderItem2 = new OrderItem(ord, new Product() { Name = "Test", Price = 320 }, 4);

            var expected = 1670.0;

            //action
            var actual = ord.Total();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}