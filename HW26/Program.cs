using System;
using System.Linq;

namespace HW26
{
	/// <summary>
	/// 两数之和绝对值最小
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{


			//https://www.nowcoder.com/discuss/353150253526360064


			//-3 -1 5 7 11 15
			string inputStr = Console.ReadLine();


			var arr = inputStr
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(Int32.Parse)
				.ToList();

			int a = arr[0];
			int b = arr[1];

			int min = Math.Abs(a + b);

			for (int i = 0; i < arr.Count-1; i++)
			{
				for (int j = 0; j < arr.Count; j++)
				{
					if (Math.Abs(arr[i] + arr[j]) < min)
					{
						a = arr[i];
						b = arr[j];
						min = Math.Abs(a + b);
					}
				}
			}

			Console.WriteLine(min);
		}
	}
}
