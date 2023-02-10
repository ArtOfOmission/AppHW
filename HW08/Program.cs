using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08
{
    /// <summary>
    /// 太阳能板最大面积
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> heightList = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int len = heightList.Count;
            long res = 0;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    long a = heightList[i];
                    long b = heightList[j];

                    long c = j - i;
                    if (a > b)
                    {
                        if (res < b * c)
                        {
                            res = b * c;
                        }
                    }
                    else
                    {
                        if (res < a * c)
                        {
                            res = a * c;
                        }
                    }
                }
            }

            Console.WriteLine("最大面积为：{0}", res);
            Console.ReadKey();
        }
    }
}
