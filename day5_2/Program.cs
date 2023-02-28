using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("숫자를 입력하세요: ");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}은 {1}수 입니다.", num, Sniffling(num));


			Console.ReadKey();
		}


		private static string Sniffling(int num)			// 문자열 string을 반환하는 메소드(함수).
		{
			if (num % 2 == 0)
				return "짝";

			else return "홀";
		}
	}
}
