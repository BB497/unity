using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string str_a = "Hello ";				// 문자열: 담을수 있는 데이터의 크기나 범위가 없음.
			string str_b = "World!";

			Console.WriteLine(str_a);
			Console.WriteLine(str_b);
			Console.WriteLine(str_a + str_b);       // python 처럼 a + b 해서 합치는것도 가능.
			Console.WriteLine();
			//Console.ReadKey();



			float f_a = 0.01f;						// 부동 소수점: 근사값
			float f_b = 0.05f;						// 리터럴 상수 접미사 f를 붙여야함 아무것도 쓰지 않으면 double형
			float f_c = 0.06f;						// 오버플로우가 발생할 수 있기 때문에 f를써야함. 컴파일에러가 난다.
			float f_d = f_a + f_b;
			float e = Math.Abs(f_c - f_d);			// Math.Abs: 절댓값
			Console.WriteLine("{0}", f_c);			// 0.06f
			Console.WriteLine("{0}", f_d);          // 0.06
			Console.WriteLine(e);                   // 3.72529E-09 만큼 차이가 남 (부동소수점뭐어쩌고)
			Console.WriteLine(f_d == f_c);          // False
			Console.WriteLine();
			//Console.ReadKey();


			// bool(1byte): True, False
			// 8bit중 맨앞의 1비트만 판별비트로 사용함.

			bool b_a = true;				// true, false 소문자로만 쓰기 컴파일 에러날 수 있음
			bool b_b = false;

			Console.WriteLine(b_a);
			Console.WriteLine(b_b);


			// 자료형 변환

			int var_a = 128;
			Console.WriteLine(var_a);

			sbyte var_b = (sbyte)var_a;     // int -> sbyte로 변환.
			Console.WriteLine(var_b);       // sbyte의 데이터 범위 초과로 오버플로우 발생: var_b의 값은 -128로 출력됨.
			Console.WriteLine();


		}
	}
}
