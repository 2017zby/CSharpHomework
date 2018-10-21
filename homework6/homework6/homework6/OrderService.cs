using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    [Serializable]
   public  class OrderService
    {

      public  List<Order> OrderList = new List<Order>();
       public int ListNum = 0;

        public void AddOrder()
        {
            OrderList.Add(new Order());
            ListNum++;
        }
        public void DeleteOrder(int listNum)
        {
            try
            {
                if(ListNum>=0)
                {
                    Console.WriteLine("—————该订单已删除—————");
                    OrderList.RemoveAt(listNum);
                }

            }
            catch
            {
                Console.WriteLine("请输入正确的订单序号！");
            }
          
        }

        public void ShowOrderService()
        {
            Console.WriteLine( "------------------------------------------");
          
            foreach(Order order in OrderList)
            {
                order.ShowOrder();
                
            }
        }
        public void AddGood(string name,int num,int listNum)
        {
            try
            {
                OrderList[listNum].AddOrderDetail(name, num);
            }
            catch
            {
                Console.WriteLine("请输入正确的商品和数量！");
            }
        }

        public void  DeleteGoodByGoodName(string name,int listNum)
        {
            try
            {
                OrderList[listNum].DeleteOrderDetailsByName(name);
            }
            catch
            {
                Console.WriteLine("没有在该订单中找到您需要的商品！");
            }
        }

        public void DeleteGoodByGoodNumber(int number, int listNum)
        {
            try { OrderList[listNum].DeleteOrderDetailsByNumber(number); }
            catch
            {
                Console.WriteLine("没有在该订单中找到您所需要序号的商品！");
            }

        }
        public void ChangeGoodDetailsName(string name,string changeName, int orderNum)
        {
            try { OrderList[orderNum].ChangeGoodName(name, changeName); }
            catch { Console.WriteLine("请确认您输入的数据是否正确！"); }
        }
        public void ChangeGoodDetailsNumber(string name, int changeNumber, int orderNum)
        {
            try { OrderList[orderNum].ChangeGoodNumber(name, changeNumber); }
            catch { Console.WriteLine("请确认您输入的数据是否正确！"); }
        }
        public void SortGood(string name)
        {
            try
            {
                foreach (Order order in OrderList)
                {
                    order.ShowOrder(name);
                }
            }
            catch { Console.WriteLine("没有找到该商品！"); }
        }

        public void SortGood(int number,int orderNum)
        {
            try { OrderList[orderNum].ShowOrder(number); }
            catch
            {
                Console.WriteLine("没有找到该商品！");
            }
        }

        XmlSerializer xmlser = new XmlSerializer(typeof(OrderService));
        string xmlFilename = "orderservice.xml";

        public void Export()
        {
            FileStream fs = new FileStream(xmlFilename, FileMode.Create);
            xmlser.Serialize(fs, this);
            fs.Close();
        }
        public OrderService Import()
        {
            FileStream fs = new FileStream(xmlFilename, FileMode.Open, FileAccess.Read);
            OrderService newOS = (OrderService)xmlser.Deserialize(fs);
            fs.Close();
            return newOS;
        }
    }
}
