using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread thread1 = new Thread(CountTo100);
			thread1.Start("Thread1");
			Thread thread2 = new Thread(CountTo100);
			thread2.Start("Thread2");
			thread1.Join();
			thread2.Join();
			Console.ReadKey();
		}

		public static void CountTo100(object data)
		{
			string threadName = (string)data;
			for (int index = 0; index < 100; index++)
				Console.WriteLine(threadName + ": " + (index + 1));
		}
	}
}
