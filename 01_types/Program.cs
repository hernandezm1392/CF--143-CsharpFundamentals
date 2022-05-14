// ! Solution File (SLN)
// when we create a solution file, the basic implementation of the command will grab the name of the parent directory and assign it to th esolution that it is generating.
    // - IN our case: dotnet new sln = cSharpFundamentals.sln
    // - two ways to start it:
        // - dotnet new sln -n[name.sln]
        // - dotnet new sln (while inside the folder)
    
    // the solution will go on to grup together the bulk of our notes
    
    // * what's in the package?
        // - cproj: CSharp project file - holds the SDK (software development kit) for us to runour projects.
        // - obj (folder): various packages that help  our code run (not a high concern right now)
        // - cs: where we write our code.


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ! Vaiables

// datatypes variableName - value;
//  -must start with datatype and be given a name.
// * doesn't need to be assigned a value right away.

// ! Booleans
//  - bool: 1byte
        //  - stores true/false value



bool isDeclared = true;
bool isNotDeclared;
// Console.WriteLine (isNotDeclared); Breaks our build because a default value is not provided.

isNotDeclared = false;
// CW
System.Console.WriteLine(isNotDeclared);

/*
! Characters
- Char: 2bytes
- stores single character/letter, surrounded by a single quote ' '
*/

char character = 'a';
char symbol = '?';
char number = '7';
char whitespace = ' ';
var specialCharacter = '\n';

/*
! String
    -string: 2 bytes per character
        -stores a sequence of characters, surrounded by double quotes
*/
string stringSample = "Sample Text";
System.Console.WriteLine(stringsample);


/*
 ! Numbers
    - int: 4 bytes
    - long: 8 bytes
*/

byte byteExample = 255; // anything between 0-255 due to binary code
sbyte sByteMin = -128; // between -128 through 127 (128 x 2 while accounting for zero)
short shortExample = -32767; // Max
int intMin = -2147483648;
Int32 intMax = 2147483647; //fits a 32 bit
long longExample = 9223372036854775808;
Int64 longMin = -93372036854775808; // same as a long

byte numByte = 25;
System.Console.WriteLine(numbyte);

//* casting:
System.Console.WriteLine((char) numByte); //we are translating the byte into a character. This changes the value into the list of characters.
System.Console.WriteLine((long) numByte); 

// !Decimals
    // -float: 4 bytes
        // -stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
        // double: 8 bytes
        // - stores fractional numbers. Sufficient for storing 15 decimal digits 

    float floatExmaple = 1.0443534f; //the digits are represented in binary except for the preiod. we use the "F" at the end to detail that we are storing a float value.
    double doubleExample = 1.73245463456345d; //like a float but double the space.
    double defaultDouble = 198271; //When referring decimal numbers, this is the default expectation and doesn't require a "d". for consistency, it is best to place it.
    decimal decimalExample = 1.248372628472727484927328m; //Highest form of number. typically used for currency. we use a "m" to detail that this value is meant for a decimal.

    System.Console.WriteLine("Float:" + 1.248372628472727484927328f);
    System.Console.WriteLine("Double: " + 1.248372628472727484927328d);
    System.Console.WriteLine("Decimal: " + 1.248372628472727484927328m);
    
    /*
    ! structs
        Data structures
    */

int age = 42;
DateTime = DateTime.Today;
System.Console.WriteLine(today);

DateTimeOffset TodayUTC = DateTimeOffset.Now;
System.Console.WriteLine(TodayUTC);

DateTime birthday = new DateTime(2024, 12, 24);
System.Console.WriteLine(birthday);

