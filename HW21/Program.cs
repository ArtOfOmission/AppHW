using System;

namespace HW21
{
	/// <summary>
	/// 矩形相交的面积
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			//https://blog.nowcoder.net/n/8d06725b779746298813e0189c8eaf72

			//http://149.129.56.38/2022/04/08/2022-%e5%8d%8e%e4%b8%ba%e6%9c%ba%e8%80%83-%e7%9f%a9%e5%bd%a2%e7%9b%b8%e4%ba%a4%e7%9a%84%e9%9d%a2%e7%a7%af/

			//http://149.129.56.38/2022/04/08/2022-%e5%8d%8e%e4%b8%ba%e6%9c%ba%e8%80%83-%e7%9f%a9%e5%bd%a2%e7%9b%b8%e4%ba%a4%e7%9a%84%e9%9d%a2%e7%a7%af/

			var t1 = new int[] { 1, 6, 4, 4 };
			var t2 = new int[] { 3, 5, 3, 4 };
			var t3 = new int[] { 0, 3, 7, 3 };


			int x1 = t1[0];
			int y1 = t1[1];
			int x11 = t1[0] + t1[2];
			int y11 = t1[1] - t1[3];

			int x2 = t2[0];
			int y2 = t2[1];
			int x22 = t2[0] + t2[2];
			int y22 = t2[1] - t2[3];

			int x3 = t3[0];
			int y3 = t3[1];
			int x33 = t3[0] + t3[2];
			int y33 = t3[1] - t3[3];
		
			if (x1 >= x22 || x11 < x2) {
				Console.WriteLine(0);
				return;
			}

			int left_x = Math.Max(Math.Max(x1, x2), x3);
			int left_y = Math.Min(Math.Min(y1, y2), y3);

			int right_x = Math.Min(Math.Min(x11, x22), x33);
			int right_y = Math.Max(Math.Max(y11, y22), y33);
			int ans = (right_x - left_x) * (left_y - right_y);


			Console.WriteLine(ans);
		}

	}
}
