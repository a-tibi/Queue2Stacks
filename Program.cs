using System;
using System.Collections.Generic;

namespace Queue2Stacks
{
	class Program
	{
		public static Stack<int> input = new Stack<int>();
		public static Stack<int> output = new Stack<int>();

		static void Enqueue(int item)
		{
			input.Push(item); 
		}

		static int Dequeue()
		{
			InputToOutput();

			return output.Pop();
		}

		static int Print()
		{
			InputToOutput();

			return output.Peek();
		}

		static void InputToOutput()
		{
			while (input.Count != 0)
			{
				output.Push(input.Pop());
			}
		}

		static void Main(string[] args)
		{
			int queries = int.Parse(Console.ReadLine());

			while (queries > 0)
			{
				string[] lines = Console.ReadLine().Split(' ');

				int command = int.Parse(lines[0]);

				switch (command)
				{
					case 1:
						Enqueue(int.Parse(lines[1]));
						break;
					case 2:
						Dequeue();
						break;
					case 3:
						Console.WriteLine(Print());
						break;
					default:
						break;
				}

				queries--;
			}

			Console.ReadKey();
		}
	}
}
