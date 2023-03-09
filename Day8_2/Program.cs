using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// 클래스(객체)
			//		상속성, 다향성, 은식성

			// 얕은 복사, 깊은 복사
			//	>> 얕은 복사
			Dog navi = new Dog("Navi", 3);
			Console.WriteLine("{0}", navi.Name);
			//Dog rabbit = navi;	// 얕은 복사
			Dog rabbit = navi.DeepCopy();		// 깊은 복사.
			rabbit.Name = "Rabbit";
			Console.WriteLine("{0} {1}", navi.Name, rabbit.Name);

			//	>> 깊은 복사
			//		C#에서 자동이나 기능적으로 제공하지 않음: 구현해야 함.
		}
		class Dog
		{
			public Dog()
			{
				Name = string.Empty;
				Age = 0;
			}
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

			public string Name;
			public int Age;

			public Dog DeepCopy()
			{
				Dog newCopy = new Dog(Name, Age);		// 인스턴스 생성
														// 필드를 나와 동일하게 변경하고 반환
				return newCopy;
			}
		}
	}
}
