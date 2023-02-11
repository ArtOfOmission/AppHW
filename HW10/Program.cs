using System;
using System.Collections.Generic;

namespace HW10
{
	/// <summary>
	/// 消消乐游戏
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			//string inputString = "ggA";
			string inputString = "abccbe";

			Stack<Char> stack = new Stack<char>();

			foreach (var item in inputString)
			{
				if (stack.Count == 0 || item != stack.Peek())
				{
					stack.Push(item);
					continue;
				}

				stack.Pop();		

			}

			Array arr = stack.ToArray();
			Array.Reverse(arr);

			string str = "";
			foreach (var item in arr)
			{
				str += item;
			}


			Console.WriteLine(str);
		}
	}
}
