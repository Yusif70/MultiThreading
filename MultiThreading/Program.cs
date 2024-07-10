using MultiThreading.task1;
using MultiThreading.task2;
using MultiThreading.task3;
#region task1

Thread t1 = new(Class1.PrintEvenNums);
Thread t2 = new(Class1.PrintOddNums);
Console.WriteLine("Main thread start");

Console.WriteLine("thread1 start");
t1.Start();
Console.WriteLine("thread2 end");

Console.WriteLine("thread1 start");
t2.Start();
Console.WriteLine("thread2 end");

Console.WriteLine("Main thread end");

#endregion

#region task2

string dir1 = "C:\\Users\\Lenovo\\source\\repos\\MultiThreading\\MultiThreading\\task1\\";
string dir2 = "C:\\Users\\Lenovo\\source\\repos\\MultiThreading\\MultiThreading\\task2\\";
string dir3 = "C:\\Users\\Lenovo\\source\\repos\\MultiThreading\\MultiThreading\\task3\\";

Console.Write("faylin adini daxil edin: ");
string fileName = Console.ReadLine();

Thread t1 = new Thread(() =>
{
	Class2.FindFiles(dir1, fileName);
});
Thread t2 = new Thread(() =>
{
	Class2.FindFiles(dir2, fileName);
});
Thread t3 = new Thread(() =>
{
	Class2.FindFiles(dir3, fileName);
});

t1.Start();
t2.Start();
t3.Start();

#endregion

#region task3

string path = "C:\\Users\\Lenovo\\source\\repos\\MultiThreading\\MultiThreading\\task3\\TextFile1.txt";
string[] lines = [];
int wordCount = 0;

Task task1 = Task.Run(() =>
{
	lines = Class3.ReadFile(path);
});

task1.Wait();

foreach (string line in lines)
{
	Console.WriteLine(line);
}

Task task2 = Task.Run(() =>
{
	wordCount = Class3.WordCount(lines);
});

task2.Wait();

Console.WriteLine(wordCount);

#endregion