using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
	class Program
	{
		static void Main(string[] args)
		{
			// 배열 및 컬렉션
			// 배열 선언: 배열형식[] 배열이름 = new 배열형식 [배열크기];
			//	ex) int[] arr = new int[4];

			string[] names = new string[6];
			names[0] = "A";
			names[1] = "B";
			names[2] = "C";
			names[3] = "D";
			names[4] = "E";
			names[5] = "F";

			// 배열의 선언과 초기화
			// 1) 배열 크기 지정
			// string[] names = new string[6] {"a", "b", "c", "d", "e", "f"};

			// 2) 배열 크기 미지정
			// string[] names = new string[] {"a", "b", "c", "d", ... };
			//					<< 배열 크기를 지정하지 않음: 초기화하는 값의 갯수에 따라 배열의 크기가 정해짐.

			// 3) 간소화.
			// string[] names = {"a", "b", "c", "d", ... };


			// 배열_변수.Length: 배열의 길이 반환.
			for(int i = 0; i<names.Length; i++)			// .Length를 사용해 배열의 길이만큼 원소를 출력할 수 있다.
			{											// 배열의 인덱스가 필요한 경우 사용.
				Console.Write("{0} ", names[i]);
			}
			Console.WriteLine();

			// foreach를 사용하여 배열의 원소 출력
			foreach (string name in names)
			{
				Console.Write("{0} ", name);
			}
			Console.WriteLine();



			int[] scores = { 80, 53, 95, 85, 82 };

			foreach (int score in scores)
				Console.Write("{0} ", score);
			Console.WriteLine();

			int sum = 0;
			foreach (int score in scores)
				sum += score;

			int average = sum / scores.Length;
			Console.WriteLine("평균 점수: {0}", average);


			// 배열의 기능
			//	- 정적
			//		Array.Sort(배열);		// 배열 오름차순 정렬.

			Console.WriteLine("Array.Sort();");
			int[] sorts = { 6, 3, 1, 4, 0 };
			Array.Sort(sorts);
			foreach (int n in sorts)
				Console.Write("{0}", n);
			Console.WriteLine();

			//		void Array.Reverse(배열); : 배열 순서 뒤집기
			Console.WriteLine("Array.Reverse();");
			Array.Reverse(sorts);
			foreach (int n in sorts)
				Console.Write("{0}", n);
			Console.WriteLine();

			//		void Array.Resize<Type>(ref 배열, 크기);		// 배열 크기를 재조정한다.
			Console.WriteLine("Array.Resize<Type>();");
			Array.Resize<int>(ref sorts, 10);					// 배열 크기가 10, 빈 공간은 0으로 초기화됨.
			foreach (int n in sorts)
				Console.Write("{0}", n);
			Console.WriteLine();

			//		void Array.IndexOf(배열, 값);			: 값과 같은 요소를 찾아서 인덱스 반환.
			//												  요소가 없다면 -1을 반환.
			Console.WriteLine("Array.IndexOf();");
			int idx = Array.IndexOf(sorts, 6);
			Console.WriteLine("값 6은 {0}번 인덱스에 있습니다!", idx);
			Console.WriteLine();

			//		bool Array.TrueForAll<Type>(배열, 대리자);	// 배열의 모든 요소가 지정한 조건에
			//													   부합하는지 여부를 참거짓으로 반환.
			Console.WriteLine("Array.TrueForAll<Type>();");
			// bool isEven = Array.TrueForAll(sorts, (v) => v % 2 == 0);		// 람다식.
			bool isEven = Array.TrueForAll(sorts, IsEven);      // 배열의 모든 요소를 IsEven에 전달하고
																// 모든 결과가 true면 true 반환.
			Console.WriteLine("{0}", isEven);
			Console.WriteLine();

			// Clear(배열, 시작_인덱스, 길이);				// 배열의 요소를 초기화 (숫자 0, bool false, 객체 null)
			Console.WriteLine("Clear();");
			Array.Clear(sorts, 1, 3);           // 인덱스 1부터 3개 요소 초기화
			foreach (int n in sorts)
				Console.Write("{0}", n);
			Console.WriteLine();

			// Foreach<Type>(배열, 대리자);					// 대리자에 요소를 순차적으로 전달 foreach 와 유사
			Console.Write("Foreach<T>();");
			Array.ForEach(sorts, PrintNum);
			Console.WriteLine();




			//	- 인스턴스
			//		배열_변수.Length: 배열의 길이 반환
			//		배열_변수.GetLength(치수); : 배열의 길이 반환 (다차원 배열)
			//		배열_변수.Rank;			: 배열의 차원 반환 (몇차원인지)

		}

		static bool IsEven(int num)
		{
			return num % 2 == 0;
		}

		static void PrintNum(int num)
		{
			Console.Write("{0} ", num);
		}
	}
}
