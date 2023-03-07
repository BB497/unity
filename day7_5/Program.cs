using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_5
{
	class Program
	{
		static void Main(string[] args)
		{
			// 컬렉션
			//			같은 형식의 데이터의 모음을 담는 자료구조.
			//			배열과 비슷하게 여러 데이터를 담을 수 있지만, 크기가 고정되어 있지 않다.

			// List, Queue, Stack, Dictionary

			// <T> 제네릭(Generic)
			// 자료형을 직접 지정할수 있도록 도와줌.


			Console.WriteLine("List");
			// List
			//		List는 가장 배열과 유사한 컬렉션
			//		배열과 동일하게 인덱스로 요소에 접근.
			// List의 사용 방법.
			//		List<자료형> 변수명 = new List<자료형>();
			//		int list.Count: 리스트의 전체 크기를 반환.
			//	인스턴스 메서드 종류
			//		void list.Add(요소); : 요소 추가 (요소는 자료형과 일치하는 자료형이어야 한다.)
			//		void list.Remove(요소); : 동일 요소 제거
			//		void list.RemoveAt(인덱스); : 인덱스에 해당하는 요소 제거(배열과 유사)
			//		void list.Insert(인덱스, 요소); : 인덱스에 요소 추가.

			// 예시 코드(List)
			List<int> list = new List<int>();

			for(int i = 0; i < 5; i++)
				list.Add(i);        // 0 ~ 4번 인덱스에 순차적으로 "0 ~ 4" 요소 추가

			foreach (int n in list)
				Console.Write("{0} ", n);
			Console.WriteLine();

			list.RemoveAt(3);       // 3번 인덱스의 요소 제거.

			for (int i = 0; i < list.Count; i++)
				Console.Write("{0} ", list[i]);
			Console.WriteLine();

			list.Insert(0, 5);      // 0번 인덱스에 요소 "5" 추가.

			foreach (int n in list)
				Console.Write("{0} ", n);
			Console.WriteLine("\n");


			Console.WriteLine("Queue");
			// Queue
			//		대기열: 기다리는 줄.
			//		큐의 특징 : FIFO
			// Queue의 사용 방법.
			//		선언: Queue<자료형> queue = new Queue<자료형>();
			//		void queue.Enqueue(값); : 요소 추가
			//		자료형 queue.Dequeue();	: 요소 제거 및 반환.
			//		자료형 queue.Peek();		: 요소 반환(만).
			Queue<int> q = new Queue<int>();
			q.Enqueue(1);
			q.Enqueue(2);
			q.Enqueue(3);
			q.Enqueue(4);
			q.Enqueue(5);

			while (q.Count > 0)
				Console.Write("{0} ", q.Dequeue());
		}
	}
}
