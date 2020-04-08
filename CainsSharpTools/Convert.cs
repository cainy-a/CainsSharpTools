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
        }
    }
}