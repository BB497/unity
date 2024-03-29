﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
	class Program
	{
		static void Main(string[] args)
		{
			// 반복문 while
			//		>> 사용 방법
			//		while(조건식)
			//			조건식이 참이면 반복되는 코드

			//		while(조건식)
			//		{
			//			조건식이 참이면 반복되는 코드 블럭
			//			...
			//		}

			int cnt = 10;

			Console.WriteLine("10 to 1 count\n");
			while (cnt > 0)
				Console.WriteLine("cnt = {0}", cnt--);

			Console.WriteLine("0 to 10 count\n");
			while (cnt <= 10)
			{
				Console.WriteLine("cnt= {0}", cnt++);
			}

			// 반복문 do-while
			//		>> 사용 방법
			//			do
			//			{
			//				반복실행할 코드 블럭 (아래 조건문이 거짓이더라도 최초 한번은 반드시 실행됨)
			//			} while(조건식);  <<세미콜론

			int num = 5;
			do
			{
				Console.WriteLine("num = {0}", num);		// do: 일단 1번 실행
			} while (num-- > 0);		// False


			// 반복문 for : 가장 많이 사용됨.
			//			>> 사용 방법
			//				for(초기화식; 조건식; 반복식){
			//					조건식이 참이면 반복되는 코드 블럭
			//				}

			//		1) 초기화식
			//			반복을 실행하기 전에 최초 1회만 실행되는 코드
			//			변수의 선언과 초기화를 진행해야 함.
			//		2) 조건식
			//			반복을 수행할지에 대한 여부
			//		3) 반복식
			//			반복이 끝날 때마다 실행되는 코드

			//		초기화식 - 조건식 - 코드 블럭 - [반복식 - 조건식 - 코드 블럭] 반복

			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine("i = {0}", i);
			}

			// 이중 for
			//		다른 반복문도 가능
			//		반복문 안에 반복문을 작성하는 것

			for(int n = 0; n < 5; n++)
			{
				for (int m = 0; m<=n; m++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			// 반복문 foreach
			//		배열 또는 컬렉션의 개념을 이해해야 할 수 있음

			//	 >> 사용 방법
			//		foreach(데이터_형식 변수명 in 배열_컬렉션)
			//		{
			//			배열이나 컬렉션의 첫 번째 요소부터 끝 요소까지 순차적으로 선언 된
			//			변수에 담김.
			//		}

			int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };

			foreach(int num2 in arr)
			{
				Console.Write(num2);
			}

			// 무한 루프
			// for( ; ; )
			// while(true)

			// break, continue
			//		코드의 흐름을 끊고 프로그램 실행 위치를 도약 시킬 수 있다.

			// break
			//		break 는 반복문이나 switch에서 벗어날 때 사용한다.

			// continue
			//		continue 는 반복문을 다시 수행하게 하는 기능이다.

			int num3 = 0;
			while(true)
			{
				if (num3 > 10)				// num3 == 10 이면
					break;					// break
				Console.WriteLine(num3++);
			}
			Console.WriteLine();

			while(true)
			{
				Console.Write("continue?  Y/N\n");
				string answer = Console.ReadLine();

				// Equals 는 데이터가 같은지 비교하는 메소드
				// 문자열의 경우 == 말고 Equals를 사용해야 한다.
				if (answer.Equals("N"))
					break;
				else if (answer.Equals("Y"))
					continue;
				else
					Console.WriteLine("You've entered {0}, Please enter Y or N\n", answer);
					continue;
			}

			for(int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
					continue;
				Console.WriteLine("{0}은 홀수입니다.", i);
			}

			// 문제
			// 1. 다음을 출력하는 프로그램을 작성하시오. (for)
			//			- 출력 결과.
			//			 *
			//			***
			//		   *****
			//		  *******

			// 2. while로 작성하라
			//		  *******
			//		   *****
			//			***
			//			 *

			// 3,4 다음 프로그램을 작성하시오(for, while 각각 작성.)

			//	 -출력 결과 A
			//		몇 번 반복할까요??   >> 0
			//		0으로는 반복문을 수행 할 수 없습니다.
			//   -출력 결과 B
			//		몇 번 반복할까요??	>> 10
			//			*
			//		   ***
			//		  *****
			//		 *******
			//          ... 




			Console.ReadKey();
		}
	}
}
