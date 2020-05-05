# Type Index

### Misc.MorseCode
A class representing Morse Code.

Constructor:

- `string value` (the value to init with)
- `bool encode = true` (whether to decode the value as if it is plaintext)

Members:

- `static readonly List<char> AllowedMorseCharacters` - The characters that can be turned into morse code
- `string value;` - The encoded value.

Methods:

- `string ToString()` - It's literally just `value` again
- `int Length()` - Gets the length of the *decoded* value
- `string PlainText()` - Decodes the parent `MorseCode` object
- `string PlainText(MorseCode)` - Click [here](https://cainssharptools.readthedocs.io/en/latest/functions#plaintext) to view in Function Index.
- `MorseCode Parse(string)` - Click [here](https://cainssharptools.readthedocs.io/en/latest/functions#parse) to view in Function Index.
- `MorseCode TryParse(string, out MorseCode)` - Click [here](https://cainssharptools.readthedocs.io/en/latest/functions#tryparse) to view in Function Index.