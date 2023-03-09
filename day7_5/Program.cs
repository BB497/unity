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


			Console.WriteLine();
			Console.WriteLine("Stack");
			// Stack
			// 후입선출 구조 LCFS
			// 사용 방법
			//		Stack<자료형> 변수명 = new Stack<T>();
			//		void 변수명.Push(데이터);			// 요소 추가
			//		자료형 변수명.Pop();				// 요소 제거 및 반환.

			// 예제 코드
			Stack<int> stack = new Stack<int>();			// 인스턴스 생성.

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Push(5);				// 1,2,3,4,5 순서로 넣음.

			while (stack.Count > 0)
				Console.Write("{0} ", stack.Pop());             // 5,4,3,2,1 순으로 출력

			Console.WriteLine();
			Console.WriteLine("Dictionary");
			// Dictionary
			//		Key 와 Value 가 한 쌍으로 이루어져 있음.
			//		순서가 정해져 있지 않기 때문에, 인덱스로 요소를 가져올 수 없음. (Key로 접근해야 함)
			//		중복 Key를 허용하지 않음.
			//		선언시 제네릭으로 Key와 Value의 자료형을 지정하기 때문에, 박싱과 언박싱이 발생하지 않음.
			//		*주의: 없는 Key에 접근하게 될 시 예외 발생함.


			// Dictionary의 사용 방법
			//		선언
			//		Dictionary<Key의 자료형, Value의 자료형> 변수명 = new Dictionary<Key의 자료형, Value의 자료형>();
			//		var dic = new Dictionary<Key의 자료형, Value의 자료형>();


			//		void dic.Add(Key, Value); : Key와 요소 추가.
			//		int dic.Count; : 요소의 수량 반환
			//		bool dic.Remove(Key); : Key 제거 (Key 제거 성공시 True, 실패시 False 반환)
			//		void dic.Clear(); : 모든 요소 제거
			//		bool dic.ContainsKey(Key); : 동일한 Key가 있는지의 여부
			//		bool dic.ContainsValue(Value); : 동일한 Value가 있는지의 여부
			//		bool dic.TryGetValue(key, out value 변수명); : Key가 있는지의 여부. 있다면, 변수명에 Value 값을 저장


			// 예제 코드
			Dictionary<string, int> nameData = new Dictionary<string, int>();

			nameData.Add("김수한무", 13);
			nameData.Add("마리오", 12);
			nameData.Add("피치", 6);
			nameData.Add("쿠파", 3);

			// 요소는 KeyValuePair임
			foreach (KeyValuePair<string, int> pair in nameData)
				Console.WriteLine("name: {0}, age: {1}", pair.Key, pair.Value);

			// 예제 2
			Dictionary<string, int> idData = new Dictionary<string, int>();

			idData["5"] = 3;      // 요소 추가. 기존 요소가 있다면 value 변경.
			idData["3"] = 1;
			if (!idData.ContainsKey("2"))		// 기존 요소가 있으면 예외 발생하기 때문에 if로 검사
				idData.Add("2", 5);				// .Add: 기존 요소가 있으면 예외가 발생

			if (idData.Remove("5"))				// 요소 제거 후 true 반환
				Console.WriteLine("Key 5 제거 성공!");
			else
				Console.WriteLine("Key 5 제거 실패!");

			if (idData.ContainsKey("3"))			// key 3이 있는지 확인.
				Console.WriteLine("{0} : {1}", "3", idData["3"]);
				
			if (idData.ContainsValue(1))			// idData["3"] = 1; -> True
				Console.WriteLine("Value중엔 1이 있습니다.");
			if (idData.TryGetValue("2", out int num))
				Console.WriteLine("TryGetValue: {0}", num);

			//idData.Clear();						// 모든 요소 제거
			//Console.WriteLine(idData["2"]);			// 예외 발생.

			List<string> keys = nameData.Keys.ToList();
			keys.Sort();			// 오름차순 정렬
			keys.Reverse();			// 뒤집기
			for(int i = 0; i < keys.Count; i++)
			{
				Console.WriteLine("name: {0}, age: {1}", keys[i], nameData[keys[i]]);
			}
		}
	}
}
