using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			while (a < 100)
			{

				if ((a % 15) == 0)
					Console.WriteLine("FizzBuzz");
				else if ((a % 3) == 0)
					Console.WriteLine("Fizz");
				else if ((a % 5) == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(a);
				a++;
				
			}


		}
	}
}
