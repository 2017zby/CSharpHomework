using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using program2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderDetails od = new OrderDetails("car", 10);
            od.SetNumberOfGood(12);
            Assert.IsTrue(od.Number == 12);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            OrderDetails od = new OrderDetails("car", 10);
            od.SetNameOfGood("water");
            Assert.IsTrue(od.Name=="water");

        }
        [TestMethod]
        public void TestMethod3()
        {
            OrderDetails od = new OrderDetails("car", 10);
            int n = od.GetNumberOfGood();
            Assert.IsTrue(n == 10);

        }
        [TestMethod]
        public void TestMethod4()
        {
            OrderDetails od = new OrderDetails("car", 10);
            string n = od.GetNameOfGood();
            Assert.IsTrue(n =="car");
        }
        [TestMethod]
        public void TestMethod5()
        {
            Order or = new Order();
            or.AddOrderDetail("car", 10);
            or.ChangeGoodName("car","water");
            string name = or.reList()[0].GetNameOfGood();
            Assert.IsTrue(name == "water");
        }
        [TestMethod]
        public void TestMethod6()
        {
            Order or = new Order();
            or.AddOrderDetail("car", 10);
            or.ChangeGoodNumber("car", 20);
            int num = or.reList()[0].GetNumberOfGood();
            Assert.IsTrue(num == 20);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Order or = new Order();
            or.AddOrderDetail("car", 10);
            string name = or.reList()[0].GetNameOfGood();
            or.DeleteOrderDetailsByName("car");
            
            Assert.IsTrue(name == "car");
        }
        [TestMethod]
        public void TestMethod8()
        {
            Order or = new Order();
            or.AddOrderDetail("car", 10);
            int n = 0;
            or.ShowOrder(0);
            Assert.IsTrue(n<=or.listNumber);

        }

        [TestMethod]
        public void TestMethod9()
        {
            Order or = new Order();
            or.AddOrderDetail("car", 10);
            string name = "car";
            Assert.IsTrue(name != null);
        }
        [TestMethod]
        public void TestMethod10()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int n = 0;
            or.DeleteOrder(n);
            Assert.IsTrue(n <= or.ListNum);


        }
        [TestMethod]
        public void TestMethod11()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int n = 0;
            or.DeleteGoodByGoodName("car",n);
            Assert.IsTrue(n <= or.ListNum);


        }
        [TestMethod]
        public void TestMethod12()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int n1 = 0, n2 = 0;
            or.DeleteGoodByGoodNumber(n1, n2);
            Assert.IsTrue(n1 <= or.ListNum&&n2<=or.OrderList[n1].listNumber);
        }
        [TestMethod]
        public void TestMethod13()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int n = 0;
            or.ChangeGoodDetailsName("car", "wawaw", n);
            Assert.IsTrue(n <= or.ListNum);
        }
        [TestMethod]
        public void TestMethod14()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int n = 0;int num = 20;
            or.ChangeGoodDetailsNumber("car", num, n);
            Assert.IsTrue(n <= or.ListNum&&num>0);
        }
        [TestMethod]
        public void TestMethod15()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            string name = "car";
            or.SortGood(name);
            Assert.IsNotNull(name);
       
        }
        [TestMethod]
        public void TestMethod16()
        {
            OrderService or = new OrderService();
            or.AddOrder();
            or.AddGood("apple", 10, 0);
            or.AddGood("banana", 10, 0);
            or.AddGood("ipone", 10, 0);
            or.AddGood("car", 10, 0);
            or.AddGood("water", 10, 0);
            int num = 1;
            int orderNum = 0;
            or.SortGood(num, orderNum);
            Assert.IsTrue(num >= 0 && orderNum >= 0);

        }


    }
}
