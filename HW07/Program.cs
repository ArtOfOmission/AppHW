using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{

    /// <summary>
    /// 字符串统计
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            string str = "1qazxsw23 edcvfr45tgbn hy67uj m,ki89ol.\\/;p0-=\\][";

            int a = 0, b = 0, c = 0, d = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    a++;
                }
                else if (str[i] == ' ')
                {
                    b++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    c++;
                }
                else
                {
                    d++;
                }
            }

            Console.WriteLine("a:{0},b:{1},c:{2},d:{3}", a, b, c, d);
        }

    }
}
