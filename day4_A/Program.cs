using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_A
{
	class Program
	{
		static void Main(string[] args)
		{
			//1

			for(int i = 0; i < 4; i++)
			{
				for (int j = 1; j < 4 - i; j++)
					Console.Write(" ");

				for (int j = 0; j < i * 2 + 1; j++)
					Console.Write("*");

				Console.WriteLine();
			}


			//2
			int repeatCount = 4;		// 반복할 카운트
			while(repeatCount-- > 0)		// 4 3 2 1
			{
				// repeatCount == 3,2,1,0
				int i = 4;
				while(--i > repeatCount)		
				{
					Console.Write(" ");
				}

				i = 0;
				while(i++ < repeatCount * 2 + 1)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}


			//3
			Console.Write("몇 번 반복할까요? >>");
			int repeatCnt = int.Parse(Console.ReadLine());

			if(repeatCnt <= 0)
			{
				Console.WriteLine("{0}으로는 반복문을 수행할 수 없어요.", repeatCnt);
			}
			else
			{
				var spaceCnt = repeatCnt - 1;
				var starCnt = 1;
				for(int i = 0; i < repeatCnt; i++)
				{
					for (int j = 0; j < spaceCnt; j++)
						Console.Write(" ");

					for (int j = 0; j < starCnt; j++)
						Console.Write("*");

					starCnt += 2;
					spaceCnt--;
					Console.WriteLine();
				}
				starCnt = (repeatCnt - 1) * 2 + 1;
				spaceCnt = 0;
				while (repeatCnt-- > 0)
				{
					int i = 0;
					while(i++ < spaceCnt)
					{
						Console.Write("*");
					}
				}
			}

		}
	}
}
