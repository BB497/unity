using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
	class Program
	{
		static void Main(string[] args)		// Main함수
		{
			// 메소드(함수): 메소드 아래 코드를 호출함으로써 활용가능하게 해주는 기능.
			// 메소드의 선언
			//		C#에선 메소드의 앞글자는 대문자로 작성(카멜 표기) : MethodName(){}


			// class 클래스_이름
			// {
			//		메소드는 클래스 안에 작성해야함.
			//		접근+한정자	반환+형식	메소드+이름(매개변수 목록)
			//		{
			//			메소드 호출 시 실행되는 코드
			//			return 반환 형식에 맞는 반환값;
			//		}
			// }


			// return
			//		메소드 중간에 언제든지 호출되어 메소드를 종료시키고, 코드의 흐름을 호출자에게 돌려준다.


			// 재귀 호출.
			//		자기 자신의 메소드를 호출하는 것을 말한다.


			int result1 = Plus(2, 7);
			int result2 = Minus(10, 5);
			Begin();
			Console.WriteLine("Hello World!");
			Console.WriteLine("Plus Method Called: {0}\nMinus Method Called: {1}\n", Plus(1, 5), Minus(5, 2));

			// 메소드 오버로딩
			//		동일한 기능을 가진 메소드의 작명에 대한 고민을 해결해주고 코드가 일관성 있게 유지되도록 돕는다.
			//		특징: 동일한 메소드명을 선언할 수 있다. (매개변수의 갯수 또는 함수의 형식이 달라야 한다).
			Console.WriteLine("Plus overloaded Method2 : {0}", Plus(3, 2, 5));			// 메소드 오버로딩
			Console.WriteLine("Plus overloaded Method3: {0}\n", Plus(2.54, 2.43));       // 메소드 오버로딩

			// 가변길이 매개 변수
			//		params 키워드
			//		매개변수의 수만 다른 경우에 유용하게 사용 가능.
			Console.WriteLine("가변길이 매개변수: 3 + 2 + 5 + ... + = {0}\n", Plus(3, 2, 1, 2, 4, 2, 5, 1, 3, 5, 2, 3, 5, 1, 2, 5, 32, 4, 2, 0));


			Console.WriteLine("int result1: {0}\nint result2: {1}\n", result1, result2);
			PrintCount(5);



			// 참조 형식으로 매개변수 전달하기
			//		string: 참조 형식이지만 값 형식처럼 생성이 됨.
			//		object: 전달하는 값에 따라; 값 형식, 참조 형식 나뉨

			//		ref, out
			//		인자를 참조 형식으로 전달(Call by reference)
			//		인자에 ref나 out키워드를 붙여서 전달.
			//		매개 변수에 ref나 out 키워드가 붙어 있어야함.
			//		ref과 out 모두 참조 형식.
			//		out의 경우 반드시 메소드 내에서 초기화를 진행해야한다.
			//		out 키워드
			//			어떤 값이 있어도 상관이 없다.
			//			어떠한 값을 저장한다.
			//		ref 키워드
			//			어떠한 값이 반드시 있어야 한다 or 초기화가 되어 있어야 한다.
			//			어떠한 값을 저장한다.


			int a = 5, b = 3, c, d;
			Console.WriteLine("a: {0}, b: {1}", a, b);
			Swap_ref(ref a, ref b);         // ref로 호출하는 경우: a, b에 있는 값을 활용하여 메소드가 동작함.
											// a, b에 어떠한 값을 저장한다.
			Console.WriteLine("a: {0}, b:{1}\n", a, b);

			Swap_out(out c, out d);			// out으로 호출하는 경우: a, b에 어떠한 값이 있어도 상관 없다.
											// a와 b에 어떠한 값을 저장한다.

			//		0. Swap함수 진입.
			//		1. ref, out: Stack 영역에 a와 b의 주소를 생성.
			//		2. Heap영역에 a와 b의 값을 생성.
			//		3. tmp를 만나 Stack에 5를 저장
			//		4. Swap의 코드 진행 후 Stack의 a, b가 가리키는 Heap의 값이 변경됨.
			//		5. Swap함수 종료
			//		6. Stack에 남아있던 a, b의 값이 변경됨.
			//		7. Swap함수 종료 후 Swap에서 쓰인 모든 변수 파괴. Heap파괴.

			End();
		}




		// private: 현재 클래스만 접근 가능
		// public: 외부에서 접근 가능
		// static: 정적 선언


		// void 형 메소드
		private static void Begin()			// void형 함수: 반환타입이 없음
		{
			Console.WriteLine("Program Begin..");
			// void: return하지 않음
		}

		private static void End()
		{
			Console.WriteLine("Program End..");
		}

		private static int Plus(int a, int b)		// int형 반환타입, 매개변수 a, b
		{
			return a + b;       // return: 값을 반환 후 종료.
			End();		// << return 후 종료되었기 때문에 실행되지 않음.
		}

	
		// 메소드 오버로딩
		// 매개변수의 갯수가 다른 경우.
		private static int Plus(int a, int b, int c) { return a + b + c; }
		// 매개변수의 타입이 다른 경우.
		private static double Plus(double a, double b) { return a + b; }



		// 가변길이 매개 변수
		static int Plus(params int[] nums)
		{
			int sum = 0;
			for(int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}
			return sum;
		}
		

		// int형 메소드
		private static int Minus(int a, int b)
		{
			return a - b;
		}


		// 재귀 호출
		private static void PrintCount(int num)
		{
			if (num <= 0)   // num이 0이하이면
				return;		// 종료
			Console.WriteLine("{0}번 호출하였습니다.", 6 - num);		// 콘솔에 num 출력
			PrintCount(num - 1);                                // 자기 자신을 호출
		}


		// ref
		private static void Swap_ref(ref int a, ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}

		// out
		private static void Swap_out(out int a, out int b)
		{
			a = 1; b = 3;       // out은 반드시 메소드 내에 초기화 코드가 있어야 한다.
			Console.WriteLine("c: {0},d: {1}", a, b);
			int tmp = a;
			a = b;
			b = tmp;
			Console.WriteLine("c: {0}, d:{1}", a, b);
		}
	}
}
