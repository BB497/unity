using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_3
{
	class Program
	{
		static void Main(string[] args)
		{
			// 얕은 복사와 깊은 복사
			Console.WriteLine("얕은 복사");
			{
				Rabbit rabbit = new Rabbit();
				rabbit.Name = "WHITE";
				rabbit.FavoriteFood = "Carrot";

				Rabbit rabbit2 = rabbit;    // 얕은 복사
				rabbit2.FavoriteFood = "Pepper";		// 스택에 있는 rabbit값에 접근해서 값을 변경

				Console.WriteLine("{0}:{1}", rabbit.Name, rabbit.FavoriteFood);
				Console.WriteLine("{0}:{1}", rabbit2.Name, rabbit2.FavoriteFood);
			}

			Console.WriteLine("깊은 복사");
			{
				Rabbit rabbit = new Rabbit();
				rabbit.Name = "WHITE";
				rabbit.FavoriteFood = "Carrot";

				Rabbit rabbit2 = rabbit.DeepCopy();     // 깊은 복사: 인스턴스를 생성하여 변경.
				rabbit2.FavoriteFood = "Pepper";

				Console.WriteLine("{0}:{1}", rabbit.Name, rabbit.FavoriteFood);
				Console.WriteLine("{0}:{1}", rabbit2.Name, rabbit2.FavoriteFood);
			}
		}

		class Rabbit
		{
			public string Name;
			public string FavoriteFood;

			public Rabbit DeepCopy()
			{
				Rabbit newCopy = new Rabbit();
				newCopy.Name = Name;
				newCopy.FavoriteFood = FavoriteFood;
				return newCopy;
			}
		}
	}
}
