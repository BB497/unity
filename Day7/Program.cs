using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
	class Program
	{
		static void Main(string[] args)
		{
			//	- 인스턴스
			//		배열_변수.Length: 배열의 길이 반환
			//		배열_변수.GetLength(치수); : 배열의 길이 반환 (다차원 배열)
			//		배열_변수.Rank;			: 배열의 차원 반환 (몇차원인지)

			int[] scores = { 40, 30, 60, 73, 80, 50 };      // 크기 6의 int형 배열

			Console.WriteLine("====배열의 모든 요소 출력====");
			foreach (int score in scores)
				Console.Write("{0} ", score);
			Console.WriteLine();

			Console.WriteLine("====오름차순 정렬 후 출력====");
			Array.Sort(scores);		// 오름차순으로 정렬.
			Array.ForEach(scores, PrintNum);
			Console.WriteLine();

			Console.WriteLine("{0}차원 배열입니다.", scores.Rank);
			Console.WriteLine();

			int idx = Array.IndexOf(scores, 80);
			Console.WriteLine("80점인 요소의 인덱스: {0}", idx);

			Console.WriteLine("모든 인원이 통과했는지 여부: {0}", Array.TrueForAll(scores, CheckPassed));

			// 60점보다 낮은 요소 모두 81점으로 올리기.
			for(int i = 0; i < scores.Length; i++)
			{
				if (!CheckPassed(scores[i]))
					scores[i] = 81;
			}
			Console.WriteLine("모든 인원이 통과했는지 여부: {0}", Array.TrueForAll(scores, CheckPassed));

			int oldLength = scores.Length;
			Array.Resize(ref scores, 10);			// 배열의 크기를 10으로 변경.
			Console.WriteLine("배열의 길이가 {0}에서 {1}로 변경됨.", oldLength, scores.Length);

			Console.WriteLine("====배열의 모든 요소 출력====");
			foreach (int score in scores)
				Console.Write("{0} ", score);
			Console.WriteLine();

			Console.WriteLine("====2번부터 5개의 인덱스를 클리어 후 출력====");
			Array.Clear(scores, 2, 5);
			foreach(int score in scores)
			{
				Console.Write("{0} ", score);
			}
			Console.WriteLine();
		}

		static void PrintNum(int num)
		{
			Console.Write("{0} ", num);
		}

		static bool CheckPassed(int score)
		{
			return score >= 60;				// score가 60이상이면 true, 아니면 false반환
		}
	}
}
