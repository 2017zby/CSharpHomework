using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class Order
    {
       public  List<OrderDetails> list = new List<OrderDetails>();
       public int listNumber = 0;
       public Order() { }
        public void AddOrderDetail(string name,int number)
        {
            OrderDetails orderdetail = new OrderDetails(name,number);

            orderdetail.OrderNumber = listNumber;
            list.Add(orderdetail);
            listNumber++;
        }

        public void ChangeGoodName(string name,string changeName)
        {
            bool judge = false;
            foreach (OrderDetails good in list)
            {
                if (good.Name == name)
                {
                    good.Name = changeName;
                    judge = true;
                }
            }
            if(judge==false)
            {
                Console.WriteLine("修改失败！没有找到您所需的商品！");
            }
        }

        public void ChangeGoodNumber(string name, int changeNumber)
        {
            bool judge = false;
            foreach (OrderDetails good in list)
            {             
                if (good.Name == name)
                {
                    good.Number = changeNumber;
                    judge = true;
                }
            }
            if (judge == false)
            {
                Console.WriteLine("修改失败！没有找到您所需的商品！");
            }
        }
        public List<OrderDetails> reList()
        {
            return list;
        }
        public void DeleteOrderDetailsByName(string name)
        {
            bool judge = false;
            for (int i = 0; i < list.Count; i++)
            {
                    if (list[i].Name==name)
                {
                    list.RemoveAt(i);
                    judge = true;
                }
            }
            if (judge == false)
            {
                Console.WriteLine("删除失败！没有找到您所需的商品！");
            }

        }
        public void DeleteOrderDetailsByNumber(int number)
        {
            bool judge = false;
            foreach (OrderDetails good in list)
            {
                if (good.Number == number)
                {
                    list.Remove(good);
                    judge = true;
                }
            }
            if (judge == false)
            {
                Console.WriteLine("删除失败！没有找到您所需的商品！");
            }
        }
        public int ShowCount()
        {
            return list.Count();
        }
        public void ShowOrder()
        {

            foreach (OrderDetails good in list)
            {
                Console.WriteLine($"商品序号：" + good.OrderNumber + "  商品名称：" + good.Name + "  商品数量：" + good.Number);
                
            }
            
        }
        public void ShowOrder(int number)
        {
            bool judge = false;
            foreach (OrderDetails good in list)
            {            
                if (good.ListNumber == number)
                {
                    Console.WriteLine("你查找的商品是——");
                    Console.WriteLine($"商品序号："+good.OrderNumber+"  商品名称："+good.Name+"  商品数量："+good.Number);
                    judge = true;
                }
                
            }
            if (judge == false)
            {
                Console.WriteLine("没有找到您所需的商品！");
            }
        }
        public void ShowOrder(string name)
        {
            bool judge = false;
            foreach (OrderDetails good in list)
            {
                if (good.Name == name)
                {
                    Console.WriteLine("您查找的是——");
                    Console.WriteLine($"商品序号：" + good.OrderNumber + "  商品名称：" + good.Name + "  商品数量：" + good.Number);
                    judge = true;
                }
            }
            if(judge==false)
            { Console.WriteLine("没有找到您需要的商品！"); }
        }
    }
}
