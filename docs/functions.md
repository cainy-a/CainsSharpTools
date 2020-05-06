# Function Index

## class Misc

### Range()
Works like in python: Returns an array for a range of numbers
#### Overload 1
Parameters:

- `int low`: The number to start from; inclusive
- `int high`: The number to end on; exclusive

Returns: `int[]`: an array with the numbers in
#### Overload 2
Parameters:

- `int high`: The number to end on, counting up from 0; exclusive

Returns: `int[]`: an array with the numbers in

### RangeList()
Works like in python: Returns a List for a range of numbers
#### Overload 1
Parameters:

- `int low`: The number to start from; inclusive
- `int high`: The number to end on; exclusive

Returns: `List<int>`: a List with the numbers in
#### Overload 2
Parameters:

- `int high`: The number to end on, counting up from 0; exclusive

Returns: `List<int>`: a List with the numbers in

## class Misc.MorseCode
### PlainText()
Gets Plaintext from Morse Code.

Parameters:

- `MorseCode morseCode`: The MorseCode object to Decode

Returns: `string`

### Parse()
Converts plaintext into Morse Code.

Parameters:

- `string plaintext`: The text to encode

Returns: `MorseCode`: The encoded MorseCode

### TryParse()
Attempts to convert plaintext into Morse Code, but will not throw an exception

Parameters:

- `string plaintext`: The text to encode
- `out MorseCode result`: The encoded MorseCode

Returns: `bool`: Whether or not the operation was successful.

## class MathTools

### IsPrime()
Checks if an integer, or list of integers are prime or not
#### Overload 1
Parameters:

- `int numberToCheck`

Returns: `bool`
#### Overload 2
Parameters:

- `int[] numbersToCheck`

Returns: `bool[]`
#### Overload 3
Parameters:

- `List<int> numbersToCheck`

Returns: `List<bool>`
### CalculateArea()
Calculates the area of a 2D shape

Parameters:

- `AreaShape shape { rectangle, oval, triangle }`: which shape to use
- `float x`: how high the shape is
- `float y`: how wide the shape is

Returns: `float` The area of the given shape
### CalculateVolume()
Calculates the volume of a regular 3D shape (sphere or cube)

Parameters:

- `AreaShape shape { cuboid, ovoid }`: which shape to use
- `float x`: the dimension of the shape

Returns: `float` The volume of the given shape
### CalculateVolume()
Calculates the volume of a 3D shape

Parameters:

- `AreaShape shape { cuboid, ovoid }`: which shape to use
- `float x`: how high the shape is
- `float y`: how wide the shape is
- `float z`: how deep the shape is

Returns: `float` The volume of the given shape
### CompoundInterest()
Calculates Compound Interest

Parameters:

- `decimal startNumber`: The amount of money you have before the compound interest.
- `int numberOfYears`: How many years the compound interest runs for.
- `float annualRateMultiplier`: The multiplier for each Compound. If less than zero, then amound of money will *decrease*.
- `int timesCompoundedPerYear = 1`: OPTIONAL! How many times per year the money compounds.

Returns: `decimal` The amount of money you have afterwards.

## class MathTools.Convert

### FahrenheitToCelsius()
Converts Fahrenheits to Celsius.

Parameters:

- `float fahrenheit`: The temperature in fahrenheits to convert to celsius

Returns: `float` The given temperature in Celsius
### CelsiusToFahrenheit()
Converts Celsius to Fahrenheits.

Parameters:

- `float celsius`: The temperature in celsius to convert to fahrenheits

Returns: `float` The given temperature in Fahrenheits
### MiToKm()
Converts from Miles to Kilometers, or Miles Per Hour to Kilometers per hour.

Parameters:

- `double Miles`: the amount of Miles to convert.

Returns: `double`: The corresponding amount of Kilometers.
### KmToMi()
Converts from Miles to Kilometers, or Miles Per Hour to Kilometers per hour.

Parameters:

- `double Kilometers`: the amount of Kilometers to convert.

Returns: `double`: The corresponding amount of Miles.

## class MathTools.Averages

### Mean()
Gets the mean of 2 numbers, or an array // list of numbers.
#### Overload 1
Parameters:

- `float[] inputNumbers`: The array of input numbers to average.

Returns:

- `float`: the mean of the array
#### Overload 2
Parameters:

- `List<float> inputNumbers`: The list of input numbers to average.

Returns:

- `float`: the mean of the array
#### Overload 3
Parameters:

- `float x`: The first number to average
- `float y`: The second number to average

Returns:

- `float`: the mean of `x` and `y`

## class SciTools
## class SciTools.Electricity

### GetResistance()
Gets Resistance from Current and Voltage

Parameters:

- `float v`: Voltage
- `float i`: Current

Returns: `float`: Resistance
### GetCurrent()
Gets Current from Resistance and Voltage

Parameters:

- `float v`: Voltage
- `float r`: Resistance

Returns: `float`: Current
### GetVoltage()
Gets Voltage from Current and Resistance

Parameters:

- `float r`: Resistance
- `float i`: Current

Returns: `float`: Voltage
