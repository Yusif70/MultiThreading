using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.task3
{
	public class Class3
	{
		public static string[] ReadFile(string path)
		{
			string[] lines = File.ReadAllLines(path);
			return lines;
		}

		public static int WordCount(string[] lines)
		{
			char[] seperators = [' ', '.', '!', ',', '?', '"', '\''];
			int count = 0;
			foreach (string line in lines)
			{
				string[] arr = line.Split(seperators,StringSplitOptions.RemoveEmptyEntries);
				count += arr.Length;
			}
			return count;
		}
	}
}
