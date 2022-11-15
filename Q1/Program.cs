using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var number = Enumerable.Range(1, 10);
			foreach (var item in number)
			{
				Console.WriteLine(item);
			}

			number = Enumerable.Range(10, 6);
			foreach (var item in number)
			{
				Console.Write(item+" ");
			}
		}
	}
}
 