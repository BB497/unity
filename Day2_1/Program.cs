﻿using System;
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

			// float 과 int 사이의 자료형 변환
			float fl_a = 0.09f;
			int in_b = (int)fl_a;			// float -> int 변환의 경우 소수점 아래로 다 날림.
			Console.WriteLine(in_b);

			float fl_x = 1.1f;
			int in_y = (int)fl_x;
			Console.WriteLine(in_y);


			// string format: 문자열에 데이터를 표시하기 위해. ex) printf("어쩌고: %d", a);
			// string.Format(문자열, 인자1, 인자2, ....);
			//		string: 클래스
			//		Format: 

			string str_x = "으악";
			string str_y = "ㅁㄴㅇㄻㄴㅇㄹ";
			int sth = 123;
			string str1 = string.Format("{0} {1} {2}", str_x, str_y, sth);
			string str2 = string.Format("{1} {2} {0}", str_x, str_y, sth);		// 순서가 바뀜.
			Console.WriteLine(str1);
			Console.WriteLine(str2);
			Console.WriteLine();


			// 문자열을 숫자로 변환 -> "변환" 하는 것이기 때문에 문자열 변환시 알맞은 자료형을 선택해야 함.
			string s1 = "12345";
			string s2 = "3.14125";

			int i1 = int.Parse(s1);
			string str = string.Format("i1: {0}", i1);
			Console.WriteLine(str);
			Console.WriteLine(string.Format("i1: {0}", i1));

			float f1 = float.Parse(s2);
			bool b1 = bool.Parse("true");				// string을 bool로 변환
			Console.WriteLine(string.Format("f1: {0}", f1));
			Console.WriteLine(string.Format("b1: {0}", b1));
			Console.WriteLine();

			// 숫자를 문자열로(반대로)
			string s1_1 = i1.ToString();        // i1을 문자열로 변환.
			string s2_1 = f1.ToString();        // f1을 문자열로 변환.
			string b1_1 = b1.ToString();		// b1을 문자열로 변환.

			Console.WriteLine(string.Format("s1_1: {0}", s1_1));
			Console.WriteLine(string.Format("s2_1: {0}", s2_1));
			Console.WriteLine(string.Format("b1_1: {0}", b1_1));
			Console.WriteLine();


			// object
			//			모든 객체의 조상
			//			모든 객체를 담을 수 있음.
			//			모든 데이터 형식은 object에 상속되어 있기 때문.

			// 값 형식
			//		함수의 인자로 전달했을 때, 데이터에 접근이 불가능
			//		직렬화 안됨.
			//		주소의 전달이 불가능.

			// 참조 형식
			//		함수의 인자로 전달하면 데이터에 접근이 가능하다.
			//		직렬화 가능.
			//		주소의 전달이 가능.

			object a = 123;		// 박싱: 값 형식 -> 참조 형식
			object b = 3.14;
			object c = true;
			object d = "hi";

			int i_a = (int)a;   // 언박싱: 참조 형식 -> 값 형식
			b = i_a;            // 123
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);

			// 상수(const) 와 열거 형식(enum)
			//		선언 이후 데이터를 절대로 수정할 수 없음.
			//		절대 바뀌면 안되는 값을 개발자의 실수로 변경되지 않도록 해줌.
			//		코드 영역에서 빠져나가면 소멸함 -> 전체 코드에서 사용해야 하면 전역변수로 써야함.

			// 상수의 선언 방법.
			//		const 자료형 변수이름 = 데이터;
			//		반드시 선언과 초기화를 같이 해야함. -> 나중에 수정이 안돼서.

			const int A = 1;
			const float B = 2.14f;
			const string C = "abc";

			Console.WriteLine(A);
			// A = 123;  << 불가능!!

			// 열거 형식(enum)
			//		다수의 상수를 그룹화하여 구현할 때에 사용.
			// const int BUTTON_SELECT_CONFIRM = 0;
			// const int BUTTON_SELECT_Y = 1;
			// const int BUTTON_SELECT_N = 2;

			// 위의 것을 enum으로 나열 -> 코드 영역 바깥에 선언

			// enum BUTTON_SELECT
			// {
			//		CONFIRM,
			//		YES,
			//		NO,
			// }

			// enum 열거형 이름
			// {
			//		열거 상수
			// }
		}
	}
}
