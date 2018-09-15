using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[199];
            for(int i=0;i<199;i++)
            {
                list[i] = i + 2;
            }

            for(int i=2;i<200;i++)
            {
                for(int j=0;j<199;j++)
                {
                    if(list[j]%i==0&&list[j]!=i)
                    {
                        list[j] = 0;
                    }
                }
            }
            for(int i=0;i<199;i++)
            {
                if(list[i]!=0)
                {
                    Console.WriteLine(list[i]);
                }
            }

            Console.ReadLine();
        }
       
    }
}
