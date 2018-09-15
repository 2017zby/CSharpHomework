using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a positive integer :");
          
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)//找出所有的因子
                {

                    if (num % i == 0)//i是因子
                    {
                        //判断i是不是素数，如果是素数就打印i
                        bool s=true;
                        
                        for(int j=2;j<i;j++)
                        {

                            if (i % j == 0)
                                s = false;
                        }
                        if(s)
                        {
                            Console.WriteLine(i);
                        }
                       
                     


                      
                    }
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("请输入一个正整数！");
                Console.ReadLine();
            }

        }
      
        
    }
   
}
