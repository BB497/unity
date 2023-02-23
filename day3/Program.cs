﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
	class Program
	{
		static void Main(string[] args)
		{
			// 비트 연산자

			//	<< 왼쪽 시프트		오른쪽 피연산자 비트를 왼쪽으로 이동
			//	>> 오른쪽 시프트		왼쪽 피연산자 비트를 오른쪽으로 이동
			//	&(AND)				두 개의 피연산자 비트가 모두 1이면 1로. 그렇지 않으면 0
			//	|(OR)				두 개의 피연산자 비트가 모두 0이면 0으로. 그렇지 않으면 1
			//	^(XOR)				두 개의 피연산자 비트가 모두 같으면 0. 그렇지 않으면 1
			//	~(NOT)				피연산자 비트 0을 1로, 1을 1로 연산.


			//	할당 연산자
			//		=		할당 연산자			오른쪽 피연산자를 왼쪽 피연산자에게 할당
			//		+=		덧셈 할당 연산자		오른쪽 피연산자의 값에 왼쪽 피연산자의 값만큼 더해서 할당: a += b 와 a = a + b 는 같다.
			//		-=		뺄셈 할당연산자		아래까지 다 위와 같음
			//		*=		곱셈 할당연산자
			//		/=		나눗셈 할당연산자
			//		%=		나머지 할당연산자
			//		&=		논리할당연산자(AND)
			//		|=		논리할당연산자(OR)
			//		^=		논리할당연산자(XOR)
			//		<<=		왼쪽시프트 할당연산자
			//		>>=		오른쪽시프트 할당연산자

			int a;		// int형 변수 a선언

			a = 100;		//할당
			// a = 100

			Console.WriteLine("a = 100 => {0}", a);	// 100
			a += 90;
			// a += 90 == a = a + 90;
			// a = 190
			Console.WriteLine("a += 90 => {0}", a);
			a -= 80;
			// a -= 80 == a = a - 80;
			// a = 110
			Console.WriteLine("a -= 80 => {0}", a);
			a *= 70;
			// a *= 70 == a = a * 70;
			// a = 110 * 70 = 7700
			Console.WriteLine("a *= 70 => {0}", a);
			a /= 60;
			// a /= 60 == a = a / 60;
			// a = 7700 / 60 = 128
			Console.WriteLine("a /= 60 => {0}", a);
			a %= 50;
			// a = 128 % 50 = 28
			Console.WriteLine("a %= 50 => {0}", a);
			a &= 40;
			// 0 0 0 1 1 1 0 0
			// 0 0 1 0 1 0 0 0
			// ---------------
			// 0 0 0 0 1 0 0 0 = a = 8
			Console.WriteLine("a &= 40 => {0}", a);
			a |= 30;
			// 0 0 0 0 1 0 0 0
			// 0 0 0 1 1 1 1 0
			// ---------------
			// 0 0 0 1 1 1 1 0 = a = 30
			Console.WriteLine("a |= 30 => {0}", a);
			a ^= 20;
			// 0 0 0 1 1 1 1 0
			// 0 0 0 1 0 1 0 0
			// ---------------
			// 0 0 0 0 1 0 1 0 = 10
			Console.WriteLine("a ^= 20 => {0}", a);
			a <<= 10;
			// 0 0 0 0 1 0 1 0
			// 0 0 0 0 1 0 1 0 0 0 0 0 0 0 0 0 0 0 // 2048 + 8192 = 10240
			Console.WriteLine("a <<= 10 => {0}", a);
			a >>= 1;
			// 0 0 0 0 1 0 1 0 0 0 0 0 0 0 0 0 0 = 5120
			Console.WriteLine("a >>= 1 => {0}", a);

			// <<연산자 우선순위>>

			// 0. ()로 묶인 것. 괄호 안에선 우선순위를 따름.
			// 1. 증감 연산자: ++, --
			// 2. 부호 연산자: -, +
			// 3**. 산술 연산자: *, /, &
			// 4**. 산술 연산자: +, -
			// 5. 시프트 연산자: >>, <<
			// 6. 관계 연산자: <, >
			// 7. 비트 논리 연산자
			// 8. 논리 연산자
			// 9. 삼항 논리 연산자
			// 10. 할당 연산자

			// 문제....
			// 1. 다음 중 결과가 다른 것을 고르자.
			// 1) Console.WriteLine(i + 1);
			// 2) Console.WriteLine(i++);
			// 3) Console.WriteLine(++i);
			// 3
			
			// 2. 다음의 결과를 적자.
			// 1) int a = 8 >> 1;
			//		a = ?
			// 10000 = 16
			// 2) int b = 3 << 2;
			//		b = ?
			// 110 = 3

			// 3. 다음 결과를 적어라.
			// 1) int a = 10;
			// string b = a == 0 ? "안녕" : "Hello";
			//		b = ??
			// 
		}
	}
}
