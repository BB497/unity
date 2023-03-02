using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_Q
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. Square() 함수를 구현하여 프로그램을 완성하시오
			//		Square()함수는 매개 변수를 제곱하여 반환합니다.
			Console.WriteLine("수를 입력하세요: ");
			float num = float.Parse(Console.ReadLine());
			Console.WriteLine("결과: {0}", Square(num));
			Console.ReadKey();

			// 2
			Console.WriteLine("Q2\n");
			Q2();
			Console.ReadKey();

			//3
			Console.WriteLine("Q3\n");
			Q3();

		}

		private static float Square(float num)
		{
			return num * num;
		}

		private static void Q2()
		{
			double mean;
			Mean(1, 2, 3, 4, 3, out mean);
			Console.WriteLine("평균: {0}", mean);
		}
		private static void Mean(double a, double b, double c, double d, double e, out double mean)
		{
			mean = (a + b + c + d + e) / 5;
		}

		private static void Q3()
		{
			int a = 3, b = 4;
			int resultA = Plus(a, b);

			Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

			double x = 2.14, y = 3.25;
			double resultB = Plus(x, y);

			Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
		}
		private static int Plus(int a, int b)
		{
			int result = a + b;
			return result;
		}
		private static double Plus(double a, double b)
		{
			double result = a + b;
			return result;
		}
	}
}
