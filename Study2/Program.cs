using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2
{
	class Program
	{
		static void Main(string[] args)
		{
			// 명명 규칙
			//		class ClassName 카멜 표기법
			//		void MethodName 카멜 표기법
			//		int variableName; 카멜 표기법 (소문자)
			//		namespace NameSpaceName 카멜 표기법

			int a;               // 변수 a 선언
			a = 5;               // 변수 a에 5를 저장.

			int b = 3;           // 한번에 변수의 선언과 초기화

			int c, d, e;        // c,d,e를 한번에 선언할 수 있음
			c = 1; d = 2; e = 5;

			int f = 1, g = 2, h = 3;        // f,g,h 선언과 초기화



			// 값 형식, 참조 형식 (코드, 데이터, 스택, 힙 영역)
			// 값 형식: 스택에 저장. 코드 영역에서 벗어나면 메모리가 해제됨

			// 참조 형식 (객체)
			// od_d,e,f 변수를 스택으로 생성, 3,4,5 라는 값은 힙 영역에 할당됨.
			// 코드 영역에서 벗어나면 변수에 대한 메모리 해제
			// 힙 영역에 저장된 값들은 GC(Garbage Collection)에서 검사 후, 참조되지 않으면 해제
			object ob_d = 3;
			object ob_e = 4;
			object ob_f = 5;

			float fnum = 312.34567890f;
			double dnum = 3.1234567890;

			Console.WriteLine(fnum);
			Console.WriteLine(dnum);
			Console.ReadKey();
		}
	}
}
