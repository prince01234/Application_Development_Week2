// Declare and initialize variables of the following types: byte, short, int, long, float, double, decimal, char, bool.
byte b = 19;
short s = 3330;
int i = 72;
long l = 332999;
float f = 3.14159f;
double d = 2.7182;
decimal dec = 32.99m;
char c = 'C';
bool itIsTrue = true;

//Convert the integer value 42 to a string and store it in a new variable.
int intValue = 42;
string intToStrValue = intValue.ToString();

//Convert a string "3.14" to a double and store it in a new variable.
string strValue = "3.14";
double strToDoubleValue = Convert.ToDouble(strValue);

//Print all variables to the console with appropriate labels showing their types and values.
Console.WriteLine($"byte: {b}");
Console.WriteLine($"short: {s}");
Console.WriteLine($"int: {i}");
Console.WriteLine($"long: {l}");
Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"decimal: {dec}");
Console.WriteLine($"char: {c}");
Console.WriteLine($"bool: {itIsTrue}");

Console.WriteLine($"intValue: {intValue}");
Console.WriteLine($"Converted integer to string: {intToStrValue}");
Console.WriteLine($"string value: {strValue}");
Console.WriteLine($"Converted string to double: {strToDoubleValue}");



