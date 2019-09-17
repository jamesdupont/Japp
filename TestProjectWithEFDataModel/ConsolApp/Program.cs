using System;
using System.Collections.Generic;
using System.Linq;
using Diamond;
using Models;

namespace ConsolApp
{
    class Program
    {
		static void Main(string[] args)
		{

			DiamondPartTest dpt = new DiamondPartTest();
			var dp = dpt.TestDiamondPart();
			Console.WriteLine("Shape Name: " + " " + dp.DiamondShape.ShapeName);
			Console.WriteLine("Diamond Wieght: " + " " + dp.Weight.ToString());
			Console.Read();
		}   
    }
}
