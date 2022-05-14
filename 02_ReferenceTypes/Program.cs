/*
! Value Types vs Reference Types 
    - value Types: have a specific size, and stored in stack memory.
    -Reference Types: have a variable size, and stored in heap memory.
*/

//! strings
string someString;
string initialized = "this is intialized";
string firstName = "Mike";
string lastName = "Hern";

string fullName = firstName + ' ' + lastName;
System.Console.WriteLine(fullName);

//* interpolation
string interpolatedFullName = $"{firstName} {lastName}";
System.Console.WriteLine(interpolatedFullName);

/*
!Collections
A string is technically a collection (of character)
*/

//* Array
char firstLetter = firstName [0];
System.Console.WriteLine(firstLetter);

string extraItem = "another string";

//                          0       1        2      3           4       5               6
string [] stringArray = {"hello", "world", "why", "is it", "always", "hello World?", extraItem};
System.Console.WriteLine(stringArray[1]);

/* 
we define the type with the square brackets. the curly brackets will detail the information within that array. arrays do have a fixed size determined on how they are created.

Targeting index within an array, we always start with position zero.
*/

System.Console.WriteLine(stringArray [6]);
int lengthValue = stringArray.Length;
System.Console.WriteLine(lengthValue);
System.Console.WriteLine(stringArray[stringArray.Length - 1]);

//* List
List<string> listOfStrings = new List<string>();
listOfStrings.Add("Hello");
listOfStrings.Add("World");

/*
* a list is part of a class that is built into c# which allos us various methods to manipulate it.
*/

List<int> listOfInts;

/*
* Queue
    -first in/first out
*/

Queue<string> firstInFirstOut = new Queue<string>();
firstInFirstOut.Enqueue("I'm first");
firstInFirstOut.Enqueue("I'm next");
System.Console.WriteLine(firstInFirstOut.Peek()); //Peek() is a method that allos us to view what item is first in queue.
firstInFirstOut.Dequeue(); // we are using this method to remove the item currently in the first position.
System.Console.WriteLine(firstInFirstOut.Peek()); //the second string was shown as the first was removed.

/*
* dictionaries
    a collection where we are assigning a key to a value pair.
*/
Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(21, "legal drinking age");
keyAndValue.Add(18, "legal voting age");
keyAndValue.Add(19, "legal voting age");
System.Console.WriteLine(keyAndValue[21]); // we can target a key just like we target an index value in an array.
// the values can be the same; however you cannot use the same key for different values.

Dictionary<string, string> stringDictionary = new Dictionary<string, string>();
stringDictionary.Add("triangle", "the set of all points in a plane defined by the area within three points.");