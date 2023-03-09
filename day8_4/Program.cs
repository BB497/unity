using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// this 키워드
			//		this: 자기 자신(객체)를 지칭하는 단어 -> Python의 self. 와 비슷한 기능

			Rabbit rabbit = new Rabbit();

		}

		class Employee
		{
			public string Name;
			public string Position;

			public void SetName(string Name)
			{
				this.Name = Name;
			}
			public string GetName()
			{
				return Name;
			}
			public void SetPosition(string Position)
			{
				this.Position = Position;
			}
			public string GetPosition()
			{
				return Position;
			}
		}
		class Rabbit
		{
			public string Name;
			public string FavoriteFood;

			public Rabbit()
			{
				Name = string.Empty;
				FavoriteFood = string.Empty;
			}

			public Rabbit(string Name, string FavoriteFood)
			{
				this.Name = Name;				// this.Name : 객체 Rabbit의 Name  // Name: 생성자의 Name
				this.FavoriteFood = FavoriteFood;		
			}

			public Rabbit DeepCopy()
			{
				Rabbit newCopy = new Rabbit(Name, FavoriteFood);
				newCopy.Name = Name;
				newCopy.FavoriteFood = FavoriteFood;
				return newCopy;
			}
		}
	}
}
