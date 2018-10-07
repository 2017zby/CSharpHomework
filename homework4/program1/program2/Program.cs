using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Text
    {
        static void Main(string[] args)
        {
            OrderService store = new OrderService();
            store.AddOrder();
            //添加商品
            store.AddGood("apple", 10, 0);
            store.AddGood("banana", 10, 0);
            store.AddGood("ipone", 10, 0);
            store.AddGood("car", 10, 0);
            store.AddGood("water", 10, 0);
            //打印出所有商品
            store.ShowOrderService();
            Console.WriteLine("");
            //删除一种商品
            store.DeleteGoodByGoodName("car", 0);
            store.ShowOrderService();
            //修改商品的名字
            store.ChangeGoodDetailsName("apple", "changeApple", 0);
            store.ShowOrderService();
            //修改商品的数量
            store.ChangeGoodDetailsNumber("changeApple", 10000, 0);
            store.ShowOrderService();
            //搜索某种商品——通过商品的名字
            store.SortGood("water");
            //搜索某种商品——通过商品的序号
            store.SortGood(1, 0);
            //错误检测——改变商品数据
            store.ChangeGoodDetailsName("aaa", "bbb", 1);
            //错误检测——寻找商品
            store.SortGood("aaa");
            store.SortGood(6, 0);
            //错误检测——删除商品
            store.DeleteGoodByGoodName("aaaa", 0);
            store.DeleteGoodByGoodNumber(6, 0);
            //删除订单
            store.DeleteOrder(0);
            store.ShowOrderService();
        }

    }
}
