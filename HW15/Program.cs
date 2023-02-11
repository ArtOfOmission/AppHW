using System;
using System.Collections.Generic;

namespace HW15
{
	/// <summary>
	/// 最大花费金额
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{

			/*
			 
			 题目描述：

双十一众多商品进行打折销售，小明想购买自己心仪的一些物品， 但由于购买资金限制，所以他决定从众多心仪商品中购买三件，而且想尽可能得花完资金。
现在请你设计一个程序，计算小明尽可能花费的最大资金数。
输入描述：

输入第一行为一维整型数组m，数组长度小于100，数组元素记录单个商品的价格。单个商品加个小于1000。
输入第二行为购买资金的额度r，r<100000。
输入格式正确无需考虑输入错误情况
输出描述：

输出为满足上述条件的最大花费额度
注意：

如果不存在满足上述条件的商品请返回-1
————————————————
版权声明：本文为CSDN博主「JOEL-T99」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/weixin_47243236/article/details/122554322

			https://blog.csdn.net/weixin_47243236/article/details/122554322#:~:text=HUAWEI%20%E6%9C%BA%E8%AF%95%E9%A2%98%EF%BC%9A%E6%9C%80%E5%A4%A7%E6%B6%88%E8%B4%B9%E9%87%91%E9%A2%9D%201%20%E8%BE%93%E5%85%A5%E7%AC%AC%E4%B8%80%E8%A1%8C%E4%B8%BA%E4%B8%80%E7%BB%B4%E6%95%B4%E5%9E%8B%E6%95%B0%E7%BB%84m%EF%BC%8C%E6%95%B0%E7%BB%84%E9%95%BF%E5%BA%A6%E5%B0%8F%E4%BA%8E100%EF%BC%8C%E6%95%B0%E7%BB%84%E5%85%83%E7%B4%A0%E8%AE%B0%E5%BD%95%E5%8D%95%E4%B8%AA%E5%95%86%E5%93%81%E7%9A%84%E4%BB%B7%E6%A0%BC%E3%80%82,%E5%8D%95%E4%B8%AA%E5%95%86%E5%93%81%E5%8A%A0%E4%B8%AA%E5%B0%8F%E4%BA%8E1000%E3%80%82%202%20%E8%BE%93%E5%85%A5%E7%AC%AC%E4%BA%8C%E8%A1%8C%E4%B8%BA%E8%B4%AD%E4%B9%B0%E8%B5%84%E9%87%91%E7%9A%84%E9%A2%9D%E5%BA%A6r%EF%BC%8Cr%3C100000%E3%80%82%203%20%E8%BE%93%E5%85%A5%E6%A0%BC%E5%BC%8F%E6%AD%A3%E7%A1%AE%E6%97%A0%E9%9C%80%E8%80%83%E8%99%91%E8%BE%93%E5%85%A5%E9%94%99%E8%AF%AF%E6%83%85%E5%86%B5
			 */


			//var commodities = new List<int> { 23, 26, 36, 27 };
			//int money = 78;

			var commodities = new List<int> { 23,30, 40 };
			int money = 26;

			int max = -1;
			for (int x = 0; x < commodities.Count - 2; x++)
			{
				for (int y = 0; y < commodities.Count - 1; y++)
				{
					for (int z = 0; z < commodities.Count; z++)
					{
						var sum = commodities[x] + commodities[y] + commodities[z];
						if (sum <= money && sum > max)
						{
							max = sum;
						}
					}
				}
			}

			Console.WriteLine(max);
		}
	}
}
