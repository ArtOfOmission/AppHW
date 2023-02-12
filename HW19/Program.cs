using System;
using System.Collections.Generic;

namespace HW19
{
	class Program
	{
		static void Main(string[] args)
		{
			//用户调度问题

			//https://blog.csdn.net/qq_40623672/article/details/128382656

			int N = 2;

			int[] jobs = new int[] { 2, 2, 2, 3 };

			Dictionary<int, long> jobMap = new Dictionary<int, long>();

			long dMax = 0;//数量最多的一种
			long d_max_n = 0;
			foreach (var job in jobs)
			{
				if (jobMap.ContainsKey(job))
				{
					jobMap[job]++;
				}
				else
				{
					jobMap.Add(job, 1);
				}

				if (jobMap[job] > dMax)
				{
					dMax = jobMap[job];
				}
			}


			foreach (var item in jobMap.Keys)
			{
				if (jobMap[item] == dMax)
				{
					d_max_n += 1;
				}
			}

			long result = Math.Max((dMax - 1) * (N + 1) + d_max_n, jobs.Length);

			Console.WriteLine(result);
		}
	}
}
