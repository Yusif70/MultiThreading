using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.task2
{
	public class Class2
	{
		public static void FindFiles(string dirName, string fileName)
		{
			DirectoryInfo dir = new(dirName);
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				if (file.Name.ToLower().Contains(fileName.ToLower()))
				{
					Console.WriteLine($"{dir.Name}\\{file.Name} in thread {Thread.CurrentThread.ManagedThreadId}");
				}
			}
		}
	}
}
