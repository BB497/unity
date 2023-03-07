using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// - 인스턴스
			//		배열_변수.GetLength(치수);	: 배열의 길이 반환(다차원 배열)


			// 2차원 배열
			int[,] arr = new int[3, 4];
			arr[0, 0] = 1;
			arr[0, 1] = 2;
			arr[0, 2] = 3;
			arr[0, 3] = 4;
			arr[1, 0] = 5;
			arr[1, 1] = 6;
			arr[1, 2] = 7;
			arr[1, 3] = 8;
			arr[2, 0] = 9;
			arr[2, 1] = 10;
			arr[2, 2] = 11;
			arr[2, 3] = 12;


			// 크기가 4인 1차원 배열 요소를 3개 가지는 2차원 배열.
			int[,] arr1 = new int[3, 4] { { 1, 2, 3, 4 }, 
										  { 5, 6, 7, 8 },
										  { 9, 10, 11, 12 } };
			
			foreach (int n in arr1)				// 2차원 배열의 요소 순차적으로 변수 n에 저장.
				Console.Write("{0} ", n);
			Console.WriteLine();

			for(int y = 0; y<arr1.GetLength(0); y++)	// 가장 앞의 차원 수를 반환
			{
				for(int x = 0; x < arr1.GetLength(1); x++)		// 두번째 차원 수를 반환.
				{
					Console.Write("[y: {0}, x:{1}]: {2}\t", y, x, arr1[y, x]);
				}
				Console.WriteLine();
			}

			Console.WriteLine("Length: {0}", arr1.Length);
			Console.WriteLine("Rank: {0}", arr1.Rank);
			Console.WriteLine("GetLength(0): {0}", arr1.GetLength(0));		// 3
			Console.WriteLine("GetLength(1): {0}", arr1.GetLength(1));		// 4
		}
	}
}
