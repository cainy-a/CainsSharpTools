using System;
namespace CainsSharpTools
{
    public static class SciTools
    {
        public static class Physics 
        {

        }
        public static class Electricity
        {
            /// <summary>
            /// Gets the resistance.
            /// </summary>
            /// <returns>The resistance.</returns>
            /// <param name="v">Voltage</param>
            /// <param name="i">Current</param>
            public static float GetResistance(float v, float i) => v / i;
            /// <summary>
            /// Gets the voltage.
            /// </summary>
            /// <returns>The voltage.</returns>
            /// <param name="r">Resistance</param>
            /// <param name="i">Current</param>
            public static float GetVoltage(float r, float i) => i * r;
            /// <summary>
            /// Gets the current.
            /// </summary>
            /// <returns>The current.</returns>
            /// <param name="v">Voltage.</param>
            /// <param name="r">Resistance..</param>
            public static float GetCurrent(float v, float r) => v / r;
        }
    }
}
