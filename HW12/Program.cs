using System;

namespace HW12
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 特定大小的停车场，数组cars[ ]表示，其中1代表有车，0代表无车，车辆大小不一，统计停车场最少可以停多少辆车，返回具体的数字。长度小于1000
				输入：小车占一个车位（长度1），中车占两个车位（长度2），大车占三个车位（长度3）
				输出：整形数字字符串，表示最少停车数目
				eg:
				输入：1，1，0，0，1，1，1，0，1
				输出：3
				输入：1,0,1
				输出：2
				————————————————
				版权声明：本文为CSDN博主「月光如春风拂面」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
				原文链接：https://blog.csdn.net/qq_41821422/article/details/123766268

			https://blog.csdn.net/qq_41821422/article/details/123766268
			 */

			string inputString = "1，1，0，0，1，1，1，0，1";
			var a = inputString.Replace(",", "").Replace("，", "").Replace("0+","0").Split("0");

			int num = 0;
			for (int i = 0; i < a.Length; i++)
			{
				int n = a[i].Length;
				while (n != 0)
				{
					if (n / 3 != 0)
					{
						num += n / 3;
						n %= 3;
					}
					else if (n / 2 != 0)
					{
						num += n / 2;
						n %= 2;
					}
					else
					{
						num += n;
						n = 0;
					}
				}
			}

			Console.WriteLine(num);

		}
	}
}
