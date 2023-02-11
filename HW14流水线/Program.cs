using System;
using System.Collections.Generic;
using System.Linq;

namespace HW14
{
	/// <summary>
	/// 流水线
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int m = 3;//流水线
			int n = 5;//作业数量

			List<int> nTime = new List<int>() { 8, 4, 3, 2, 10 };

			nTime.Sort();

			List<int> lines = new List<int>();

			if (m >= n)
			{
				Console.WriteLine(nTime.Max());
				return;
			}

			int flag = 0;
			for (int i = flag; i < m; i++)
			{
				lines.Add(nTime[0]);
				nTime.RemoveAt(0);
			}


			int CountHour = 0;
			for (int j = 0; j < nTime.Count; j++)
			{			
				int min = lines.Min();
				CountHour += min;
				for (int k = 0; k < lines.Count; k++)
				{
					lines[k] -= min;
				}

				lines.Sort();
				lines[0] += nTime[j];
			}

			CountHour += lines.Max();

			Console.WriteLine(CountHour);
		}
	}
}
