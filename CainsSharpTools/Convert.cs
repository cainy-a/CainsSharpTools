namespace CainsSharpTools
{
    public static partial class MathTools
    {
        public static class Convert
        {
            /// <summary>
            /// Converts from fahrenheit to celsius
            /// </summary>
            /// <param name="fahrenheit"></param>
            /// <returns>celsius</returns>
            public static float FahrenheitToCelsius(float fahrenheit) => (fahrenheit - 32) / 1.8f;

            /// <summary>
            /// Converts from celsius to fahrenheit
            /// </summary>
            /// <param name="celsius"></param>
            /// <returns>fahrenheit</returns>
            public static float CelsiusToFahrenheit(float celsius) => (celsius * 1.8f) + 32;

            /// <summary>
            /// Converts Miles to Kilometers. Also works with the respective speeds.
            /// </summary>
            /// <returns>Kilometers</returns>
            /// <param name="Miles">Miles</param>
            public static double MiToKm(double Miles) => 1.609344f * Miles;

            /// <summary>
            /// Converts Kilometers to Miles. Also works with the respective speeds
            /// </summary>
            /// <returns>Miles</returns>
            /// <param name="Kilometers">Kilometers</param>
            public static double KmToMi(double Kilometers) => 0.62137119f * Kilometers;
        }
    }
}