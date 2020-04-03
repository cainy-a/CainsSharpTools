using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace CainsSharpTools
{
    // Enumerators for CalculateArea() and CalculateVolume()
    public enum AreaShape
    {
        Rectangle,
        Oval,
        Triangle
    }
    public enum VolumeShape
    {
        Cuboid,
        Ovoid
    }
    public static class Functions
    {
        public static class MathTools
        {
            // These check primes
            /// <summary>
            /// Checks if a number is prime
            /// </summary>
            /// <param name="numberToCheck">The number that you want to check for being prime</param>
            /// <returns>Whether or not the number is prime</returns>
            public static bool IsPrime(int numberToCheck)
            {
                switch (numberToCheck)
                {
                    case 1:
                        return false;
                    case 2:
                    case 3:
                    case 5:
                        return true;
                }

                if (numberToCheck % 2 == 0 || numberToCheck % 3 == 0 || numberToCheck % 5 == 0) return false;

                var boundary = (long)Floor(Sqrt(numberToCheck));

                // You can do less work by observing that at this point, all primes 
                // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
                // The other possible remainders have been taken care of.
                long i = 6; // start from 6, since others below have been handled.
                while (i <= boundary)
                {
                    if (numberToCheck % (i + 1) == 0 || numberToCheck % (i + 5) == 0)
                        return false;

                    i += 6;
                }

                return true;
            }
            /// <summary>
            /// Checks if lots of numbers are prime
            /// </summary>
            /// <param name="numbersToCheck">The array of numbers that you want to check</param>
            /// <returns>An array of booleans.</returns>
            public static bool[] IsPrime(int[] numbersToCheck) => IsPrime(numbersToCheck.ToList()).ToArray();
            /// <summary>
            /// Checks if lots of numbers are prime
            /// </summary>
            /// <param name="numbersToCheck">The list of numbers that you want to check</param>
            /// <returns>A list of booleans.</returns>
            public static List<bool> IsPrime(List<int> numbersToCheck) => numbersToCheck.Select(IsPrime).ToList();
            // These calculate area
            /// <summary>
            /// Calculate the area of a rectangle, triangle or oval
            /// </summary>
            /// <param name="shape">Choose whether to calculate rectangle, triangle or oval.</param>
            /// <param name="x">height of shape.</param>
            /// <param name="y">width of shape. leave blank to be same as height.</param>
            /// <returns></returns>
            public static float CalculateArea(AreaShape shape, float x, float y = 0f)
            {
                if (Math.Abs(y) < 0.000001) y = x; // Make using squares and circles easy
                
                switch (shape)
                {
                    case AreaShape.Oval:
                        return (float)PI * ((x/2) * (y / 2));
                    case AreaShape.Rectangle:
                        return x * y;
                    case AreaShape.Triangle:
                        return x * y * 0.5f;
                    default:
                        return 0;
                }
            }
            /// <summary>
            /// Calculate the Volume of a Sphere or Cube
            /// </summary>
            /// <param name="shape">Cube or Sphere</param>
            /// <param name="x">Side Length / Radius</param>
            public static float CalculateVolume(VolumeShape shape, float x)
            {
                switch (shape)
                {
                    case VolumeShape.Cuboid:
                        return x * x * x;
                    case VolumeShape.Ovoid:
                        return ((float)PI / 6) * (x * x * x);
                    default:
                        return 0;
                }
            }
            /// <summary>
            /// Calculate the Volume of a Ovoid or Cuboid
            /// </summary>
            /// <param name="shape">Ovoid or Cuboid</param>
            /// <param name="x">width</param>
            /// <param name="y">height</param>
            /// <param name="z">depth</param>
            public static float CalculateVolume(VolumeShape shape, float x, float y, float z)
            {
                switch (shape)
                {
                    case VolumeShape.Cuboid:
                        return x * y * z;
                    case VolumeShape.Ovoid:
                        return ((float)PI / 6) * (x * y * z);
                    default:
                        return 0;
                }
            }
            /// <summary>
            /// Calculates Compound Interest
            /// </summary>
            /// <param name="startNumber">The number you have before the compound interest</param>
            /// <param name="numberOfYears">How many years the interest is applied over</param>
            /// <param name="annualRateMultiplier">The multiplier for each compound Note: if less than 1, amount will DECREASE.</param>
            /// <param name="timesCompoundedPerYear">How many times the interest compounds each year</param>
            /// <returns>The value after compound interest</returns>
            public static float CompoundInterest(float startNumber, int numberOfYears, float annualRateMultiplier, int timesCompoundedPerYear = 1)
            {
                var afterAmount = startNumber;
                for (var i = 0; i < numberOfYears; i++)
                {
                    startNumber += (annualRateMultiplier / timesCompoundedPerYear);
                }
                return afterAmount;
            }
        }
    }
}