using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_3
{
	class Program
	{
		static void Main(string[] args)
		{
			// 다차원 배열
			// 3차원 배열 선언 및 초기화.
			int[,,] arr = new int[4, 3, 2]
			{//					  z, y, x
				{ // z: 0
				 // x 0 1
					{ 1,2},		// y: 0
					{ 3,4},		// y: 1
					{ 5,6}		// y: 2
				},
				{  // z: 1
					{ 7,8},
					{ 9,10},
					{ 11,12}
				},
				{  // z: 2
					{ 13,14},
					{ 15,16} ,
					{ 17,18} 
				},
				{   // z: 3
					{ 19,20},
					{ 21,22},
					{ 23,24} 
				}
			};

			for(int z = 0; z < arr.GetLength(0); z++)
			{
				Console.Write("{ \n");
				for(int y = 0; y < arr.GetLength(1); y++)
				{
					Console.Write("   { ");
					for(int x = 0; x < arr.GetLength(2); x++)
					{
						if (x == 0)
							Console.Write("{0}, ", arr[z, y, x]);
						else
							Console.Write("{0}, ", arr[z, y, x]);
					}
					Console.WriteLine("}");
				}
				Console.WriteLine("}");
			}
		}
	}
}
