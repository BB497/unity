using System;               // namespace System을 사용한다.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Study             // namespace 이름 선언.
{                           // namespace 의 블럭
	class Program           // class는 객체, class (이름)으로 선언
	{
		// Main 함수 시작
		static void Main(string[] args)		 // 메소드(Method): 한정자(static), 반환타입(void), method의 이름(Main)
		{
			// Write, WriteLine: 전달받은 인자를 출력. WriteLine은 줄바꿈도 해줌
			Console.Write("Hello World!\n");
			Console.WriteLine("Hello World!\n");
			//Console.ReadKey();              // ReadKey: 키 입력을 기다리는 메소드

			// 문제
			// "여러분, ", "안녕하세요?", "반갑습니다!"  -> Write, WriteLine 3번쓰기

			// 콘솔창에 출력 결과
			// 여러분, 안녕하세요?
			// 반갑습니다!
			Console.Write("여러분, ");
			Console.WriteLine("안녕하세요?");
			Console.Write("반갑습니다!\n");
			Console.ReadKey(); 
		}
	}
}
