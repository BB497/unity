using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day8
{
	class Program
	{
		static void Main(string[] args)
		{
			// 클래스(객체)
			// Object Oriented Programming: OOP 객체지향 프로그래밍


			// 클래스의 속성과 기능
			// 사람이라는 객체
			//		속성: 눈 코 입 손 발 그 외 폐 심장 등
			//		기능: 보기 냄새밭기 먹기 컵잡기 등
			// '본다' 명령: '눈'이라는 속성으로 보이는 모든 사물의 정보를 받아온다.



			// 객체의 속성과 기능
			//		속성 = 변수
			//		기능 = 메소드
			//		클래스는 속성과 기능을 담는 객체이다.



			// 클래스 선언
			//		접근 한정자 class 클래스명
			//		{
			//		 필드
			//		 메소드
			//		}


			// 생성자와 소멸자
			//		객체는 생성자에 의해서 만들어지고 소멸자에 의해서 파괴된다.

			Dog coco = new Dog();           // Dog 인스턴스 생성: coco
			Dog choco = new Dog("Choco", 5);            // Dog 인스턴스 생성: choco
														//choco.Name = "Choco";
														//choco.Age = 5;

			coco.Name = "Coco";
			coco.Age = 3;

			coco.Bark();
			choco.Bark();
			Test();
			//Thread.Sleep(10000);			// 10초 대기
		}

		static void Test()
		{
			for (int i = 0; i < 500000; i++)
				new Dog(i.ToString(), 5);		// 생성자 호출/스택 영역에 없음
		}

		// >> 생성자
		//		접근한정자 class 클래스명
		//		{
		//			접근한정자 클래스명(매개변수목록) : 생성자의 이름은 클래스명과 같아야 한다.
		//			{
		//				코드
		//			}
		//			필드
		//			메소드
		//		}
		class Dog
		{
			public Dog()
			{
				Name = string.Empty;            // 빈 문자열을 생성하는 올바른 방법
				Age = 0;
			}
			// 생성자: 인스턴스를 생성할 때 필드의 값을 초기화
			public Dog(string name, int age)
			{
				Name = name;
				Age = age;
				Console.WriteLine("{0} 생성", Name);
			}
			~Dog()
			{
				Console.WriteLine("{0} 제거", Name);
			}
			// 필드
			public string Name;
			public int Age;

			// 메소드
			public void Bark()		// '짖다' 라는 기능
			{
				Console.WriteLine("{0}({1}세): 멍!!", Name, Age);
			}
		}


		// >> 소멸자
		//		생성자와 마찬가지로 클래스 이름과 동일해야 한다. ~표시만 들어간다.

		//		접근한정자 class ~클래스명()
		//		{
		//		코드
		//		}

		//		소멸자에 대해
		//			소멸자는 가급적 사용하지 않는 것을 권장함.
		//			Heap의 메모리는 GC가 수거함 -> 언제 동작할 지 예측이 불가함


	}
}
