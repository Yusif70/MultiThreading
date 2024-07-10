using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.task1
{
	public class Class1
	{
		public static void PrintEvenNums()
		{
            for (int i = 0; i < 10; i++)
			{
				if(i % 2 == 0)
				{
					Thread.Sleep(1000);
					Console.WriteLine(i);
				}
			}
        }
		public static void PrintOddNums()
		{
			for(int i = 0;i < 10;i++)
			{
				if(i % 2 == 1)
				{
					Thread.Sleep(1000);
					Console.WriteLine(i);
				}
			}
		}
	}
}
