# Function Index

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

- `float startNumber`: The amount of money you have before the compound interest.
- `int numberOfYears`: How many years the compound interest runs for.
- `float annualRateMultiplier`: The multiplier for each Compound. If less than zero, then amound of money will *decrease*.
- `int timesCompoundedPerYear = 1`: OPTIONAL! How many times per year the money compounds.

Returns: `float` The amount of money you have afterwards.
## class Converters
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