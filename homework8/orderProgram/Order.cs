using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
//订单的组成部分,以及订单的生成
namespace Orders
{
    [Serializable]
    public class Order
    {
        public int numOfDetails { set; get; }
        public double orderTotalPrice { set; get; }
        public string orderNumber{set;get; }
        public string customerName { set; get; }
        public string phoneNum { set; get; }
        public List<OrderDetails> orderDetails { set; get; }
        public Order()
        {
            orderDetails = new List<OrderDetails>();
            numOfDetails = 0;
            orderTotalPrice = 0;
            
            foreach (OrderDetails ordertag in orderDetails)
            {
                orderTotalPrice += ordertag.totalPrice;
            }
        }
        public Order(string  num, string name,string phone)
        {
            orderDetails = new List<OrderDetails>();
            numOfDetails = 0;
            orderTotalPrice = 0;
         
            if(IsMatchA(phone))
            {
                phoneNum = phone;
            }        
            if(IsMatchB(num))
            {
                orderNumber = num;
            }
            
            customerName = name;
            foreach (OrderDetails ordertag in orderDetails)
            {
                orderTotalPrice += ordertag.totalPrice;
            }
        }
        public void CreateNewEntry(string kind, int number, double price)
        {
            orderDetails.Add(new OrderDetails(kind, number, price));
            numOfDetails++;
            orderTotalPrice = 0;
            foreach (OrderDetails ordertag in orderDetails)
            {
                orderTotalPrice += ordertag.totalPrice;
            }
        }

        public bool IsMatchA(string num)
        {
            string pattern = "^[1-9]{1}[0-9]{10}";
            Regex rx = new Regex(pattern);
            Match m = rx.Match(num);
            if (m.Success)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsMatchB(string num)
        {
            string pattern = "(?!0000)[0-9]{4}((0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-8])|(0[13-9]|1[0-2])(29|30)|(0[13578]|1[02])-31)[0-9]{3}";
            Regex rx = new Regex(pattern);
            Match m = rx.Match(num);
            if (m.Success)
            {
                return true;
            }
            else
                return false;
        }
        public string Export()
        {
            DateTime time = System.DateTime.Now;
            string fileName = "orders_" + time.Year + "_" + time.Month
                + "_" + time.Day + "_" + time.Hour + "_" + time.Minute
                + "_" + time.Second + ".xml";
            Export(fileName);
            return fileName;
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
               
            }
        }

    }
}
//"(?!0000)[0-9]{4}-((0[1-9]|1[0-2])-(0[1-9]|1[0-9]|2[0-8])|(0[13-9]|1[0-2])-(29|30)|(0[13578]|1[02])-31)"