using System;
using System.Collections.Generic;

namespace CainsSharpTools
{
	public static class Misc
	{
		/// <summary>
		///  Works Like range() in python, returns an int[] array
		/// </summary>
		public static int[] Range(int low, int high) => RangeList(low, high).ToArray();
		/// <summary>
		///  Works Like range() in python, returns an int[] array
		/// </summary>
		public static int[] Range(int high) => Range(0, high);

		/// <summary>
		/// Works Like range() in python, returns a List of ints
		/// </summary>
		public static List<int> RangeList(int low, int high)
		{
			List<int> toReturn = new List<int>();
			for (int i = low; i < high; i++)
			{
				toReturn.Add(i);
			}
			return toReturn;
		}
		/// <summary>
		/// Works Like range() in python, returns a List of ints
		/// </summary>
		public static List<int> RangeList(int high) => RangeList(0, high);
	}
}
