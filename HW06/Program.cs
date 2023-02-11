using System;

namespace HW06
{
	/// <summary>
	/// 火星文输入
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			string input = "7#6$5#12";

			var r = func(input);

			Console.WriteLine(r);			
		}


		static int dollar(int x, int y) {
			return 3 * x + y + 2;
		}

		static int jing(int x, int y) {
			return 2 * x + 3 * y + 4;
		}

		public static int func(String input)
		{
			//优先算最后#
			int index = input.LastIndexOf("#");
			if (index != -1)
			{
				String left = input.Substring(0, index);
				String right = input.Substring(index + 1);
				int res = 2 * func(left) + 3 * func(right) + 4;
				return res;
			}
			//优先算第一$
			index = input.LastIndexOf("$");
			if (index != -1)
			{
				String left = input.Substring(0, index);
				String right = input.Substring(index + 1);
				int res = 3 * func(left) + func(right) + 2;
				return res;
			}

			return int.Parse(input);
		}

	}
}
