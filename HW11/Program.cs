using System;
using System.Collections.Generic;

namespace HW11
{
	/// <summary>
	/// 
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{

			/*
			 12、标题:敏感字段加密
			【敏感字段加密敏】给定一个由多个命令字组成的命令字符串:
			1、字符串长度小于等于127字节，只包含大小写字母、数字、下划线和偶数个双引号;
			2、命令字之间以一个或多个下划线_进行分割;
			3、可以通过两个双引号来"标识包含下划线_的命令字或空命令字(仅包含两个引双引号的命令字)双引号不会在命令字内部出现;
			仅对指定索引的敏感字段进行加密，替换为*(6个*)，并删除命令字前后多余的下划线_。如果无法找到指定索引的命令字，输出字符串ERROR。
			输入描述:
			输入为两行，第一行为命令字索引K(从0开始)，第二行为命令字符串S。
			输出描述:
			输出处理后的命令字符串，如果无法找到指定索引的命令字，输出字符串ERROR
			示例:
			输入
			1
			pasword_a12345678__timeout_100
			输出
			pasword_*_timeout_100
			 */

			string inputString = "password__a12345678_timeout_100";
			int k = 1;

			List<string> vec = new List<string>();
				 
			int i = 0;
			while (i < inputString.Length)
			{
				if (inputString[i] == '"') //已经确保了一定会有偶数个“”
				{
					if (inputString[i + 1] == '"') //说明遇到的一定是空字符串
					{
						vec.Add("\"\"");
						i = i + 2;
					}
					else //说明遇到的是带_的字符
					{
						int j = FindChar(inputString, i + 1);
						vec.Add(inputString.Substring(i, j - i));
						i = j;
					}
				}
				else if (inputString[i] == '_')
				{
					//跳过接下来连续的_
					i = FindNChar(inputString, i + 1);
					vec.Add("_");
				}
				else //遇到的是密码
				{
					int j = FindNAlarm(inputString, i + 1);
					vec.Add(inputString.Substring(i, j - i));
					i = j;
				}
			}

			string res_str = "";
			int p = 0;
			for (int j = 0; j < vec.Count; j++)
			{
				if (vec[j] == "_")
				{
					if (j == 0 || j == vec.Count - 1)
					{

					}
					else
					{
						res_str += "_";
					}
				}
				else if (p == k)
				{
					res_str += "******";
					p++;
				}
				else
				{
					res_str += vec[j];
					p++;
				}
			}

			if (p >= k)
			{
				Console.WriteLine(res_str);
			}
			else
			{
				Console.WriteLine("ERROR");
			}			
		}


		static int FindChar(string str, int i)
		{
			int j = i;
			while (j < str.Length && str[j] != '"')
			{
				j++;
			}
			return j;
		}

		static int FindNChar(string str, int i)
		{
			int j = i;

			while (j < str.Length && str[j] == '_')
			{
				j++;
			}
			return j;
		}

		/// <summary>
		/// 找打下一个不是字母和字符串的位置
		/// </summary>
		/// <param name="str"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static int FindNAlarm(string str, int i)
		{
			int j = i;
			while (j < str.Length && char.IsLetterOrDigit(str[j]))
			{
				j++;
			}
			return j;

		}
	}
}
