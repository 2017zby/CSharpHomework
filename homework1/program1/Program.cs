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
            string s_1, s_2;
            double num_1, num_2;
            Console.Write("Please input two number :");
            s_1 = Console.ReadLine();
            s_2 = Console.ReadLine();
            num_1 = Double.Parse(s_1);
            num_2 = Double.Parse(s_2);
            double n;
            n = num_1 * num_2;
            Console.WriteLine("他们的乘积是：" + n);
        }
    }
}
