using System;

namespace HW18
{
	/// <summary>
	/// 按单词下标区间翻转文章内容
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 题目描述：

输入一个英文文章片段，翻转指定区间的单词顺序，标点符号和普通字母一样处理。
例如输入字符串 “I am a developer.”，区间[0,3]则输出 “developer. a am I”。


输入描述：

使用换行隔开三个参数
第一个参数为英文文章内容即英文字符串
第二个参数为反转起始单词下标，下标从0开始
第三个参数为结束单词下标，


输出描述：

反转后的英文文章片段，所有单词之间以一个半角空格分割进行输出
————————————————
版权声明：本文为CSDN博主「CoCo_2022」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/cxh21627/article/details/125182142
			 
			 */

			string s = "I am a developer.";
			int m = 1;
			int n = 2;

			var l  = s.Split(" ");
			var yuan = s.Split(" ");

			if (m > n || m > l.Length || n > l.Length)
			{
				Console.WriteLine("EMPTY");
				return;
			}

			Array.Reverse(l);

			for (int i = m; i <= n; i++)
			{
				yuan[i] = l[i];
			}


			Console.WriteLine(string.Join(' ',yuan));
		}
	}
}
