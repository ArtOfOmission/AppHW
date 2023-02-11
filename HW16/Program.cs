using System;

namespace HW16
{
	/// <summary>
	/// 猴子爬山
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 题目描述：
一天一只顽猴想要从山脚爬到山顶
途中经过一个有n个台阶的阶梯，但是这个猴子有个习惯，每一次只跳1步或3步
试问？猴子通过这个阶梯有多少种不同的跳跃方式

输入描述
输入只有一个这个数n 0 < n < 50
此阶梯有多个台阶

输出描述
有多少种跳跃方式
			 */

			int n = 50;
			var r = fun(n);
			Console.WriteLine(r);

		}

		static int fun(int n)
		{
			if (n <= 0)
			{
				return 0;
			}

			if (n == 1 || n == 2)
			{
				return 1;
			}

			if (n == 3)
			{
				return 2;
			}

			int sum = 0;
			sum = fun(n - 1) + fun(n - 3);

			return sum;
		}
	}
}
