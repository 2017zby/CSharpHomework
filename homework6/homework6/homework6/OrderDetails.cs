using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class OrderDetails
    {
        public OrderDetails() { }
       public OrderDetails(string name,int number)
        {
            numberOfGood =number;
            goodName = name;
            
        }
 

        public int OrderNumber;

        public int ListNumber
        {
            get
            {
                return OrderNumber;
            }
            set
            {
                OrderNumber = value;
            }
        }

        private string goodName;

        public string Name
        {
            get
            {
                return goodName;
            }
            set
            {
                goodName = value;
            }
        }

        private int numberOfGood;

        public int Number
        {
            get
            {
                return numberOfGood;
            }
            set
            {
                numberOfGood = value;
            }
        }
       public  void SetNumberOfGood(int num)
        {
            numberOfGood = num;
        }
       public int GetNumberOfGood()
        {
            return numberOfGood;
        }
        public  void SetNameOfGood(string name)
        {
            goodName = name;
        }
        public string GetNameOfGood()
        {
            return goodName;
        }
    }
}
