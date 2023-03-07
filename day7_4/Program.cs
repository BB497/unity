using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// 가변 배열
			//		들쭉날쭉한 배열이라는 의미
			//		크기가 정해져 있지 않다.

			// 선언
			int[][] jArr = new int[2][];

			jArr[0] = new int[10];      // y=0인 곳에 길이가 10인 배열
			jArr[1] = new int[5];       // y=1인 곳에 길이가 5인 배열.

			// 가변 배열의 사용 예제(선언 및 초기화, 사용)
			int[][] jArr2 = new int[3][];

			jArr2[0] = new int[5] { 1, 2, 3, 4, 5 };        // 배열 크기 지정
			jArr2[1] = new int[] { 10, 20, 30 };            // 배열 크기 자동
			jArr2[2] = new int[] { 100, 200 };

			for (int i = 0; i < jArr2.Length; i++)		// jArr2의 배열 길이
			{
				for (int j = 0; j < jArr2[i].Length; j++)
					Console.Write("{0} ", jArr2[i][j]);
				Console.WriteLine();
			}
			Console.WriteLine();

			foreach (int[] array in jArr2)
			{
				foreach (int n in array)
					Console.Write("{0} ", n);
				Console.WriteLine();
			}
		}
	}
}
