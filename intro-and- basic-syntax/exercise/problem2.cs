﻿//CONFIRMED from <asavova>
using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// We have to read WIDTH from Console.
            float width = float.Parse(Console.ReadLine());
			// We have to read HEIGHT from Console.
            float height = float.Parse(Console.ReadLine());
			
			// We create new VAR with name SUM. Now we have to multiply WIDTH and HEIGHT.
            float sum = width * height;
			
			// Print the result of SUM.
            Console.WriteLine($"{sum:F2}");
        }
    }
}