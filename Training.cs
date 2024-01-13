Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\source\repos");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

/*
    Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
    Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
    Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
    Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
    Unicode characters may not print correctly depending on the application.
*/

//overloading the operator = reuse of one symbol for multiple purposes
int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold "+widgetsSold+" widgets.");

//everything gets treated as a string
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold "+widgetsSold+7+" widgets.");

//avoid performing both a calculation and concatenation in a single line of code
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold "+(widgetsSold+7)+" widgets.");

/*

    You can perform mathematical-like addition operations on numbers.
    Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
    When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
    Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.

*/

/* + is the addition operator
    - is the subtraction operator
    * is the multiplication operator
    / is the division operator
        */
int sum = 7 + 5;
int difference = 7 -5;
int product =  7 *5;
int quotient = 7/5;

Console.WriteLine("Sum: "+sum);
Console.WriteLine("Difference: "+difference);
Console.WriteLine("Product: "+product);
Console.WriteLine("Quotient: "+quotient);

//Casting - one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type

//The modulus operator % tells you the remainder of int division. 
Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5: {7%5}");



//increment and decrement operators
value = value +1;
Console.WriteLine("First increment: "+value);

value +=1;
Console.WriteLine("Second increment: "+value);

value++;
Console.WriteLine("Third increment: "+value);

value = value - 1;
Console.WriteLine("First decrement: "+value);

value -= 1;
Console.WriteLine("Second decrement: "+value);

value--;
Console.WriteLine("Third decrement: "+value);
