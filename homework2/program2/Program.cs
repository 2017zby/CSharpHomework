using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.Write("输入数组元素的数量：");
                try
                {
                    int n = int.Parse(Console.ReadLine());

                    // 定义数组，并输入
                    int[] numberList = new int[n];
                    int sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("输入第{0}个元素:", i + 1);
                        numberList[i] = int.Parse(Console.ReadLine());
                        // 求和，为计算平均值做准备
                        sum += numberList[i];
                    }

                    Console.WriteLine("数组的平均值为：" + sum / n);
                    Console.WriteLine("数组的和为：" + sum);
                    Console.Write("数组的最大值是：");
                    FindMax(numberList, n);
                    Console.Write("数组的最小值是：");
                    FindMin(numberList, n);
                }
                catch
                {
                    Console.WriteLine("请输入正整数！");
                }

            }

        }

        static void  FindMax(int[] numList, int length)
        {
            int numMax = numList[0];

            for (int i = 0; i < length; i++)
            {
                if (numMax < numList[i])
                {
                    numMax = numList[i];

                }
            }
            Console.WriteLine(numMax);

        }



        static void FindMin(int[] numList, int length)
        {
            int numMin = numList[0];

            for (int i = 0; i < length; i++)
            {
                if (numMin > numList[i])
                {
                    numMin = numList[i];

                }
            }
            Console.WriteLine(numMin);

        }






    }
}
