using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

const string GOODBYEMESSAGE = "Goodbye!";

/**
int firstNumber = 10;
int secondNumber = 5;
++firstNumber;
--secondNumber;
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

Console.WriteLine(firstNumber + secondNumber);
Console.WriteLine(firstNumber - secondNumber);
Console.WriteLine(firstNumber * secondNumber);
Console.WriteLine(firstNumber / secondNumber);

Console.WriteLine("Hello");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[C]hange a TODO");
Console.WriteLine("[A]dd a new TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");
*/

/**
 * This is a simple TODO list application that allows users to manage their tasks.
 * Users can see all TODOs, change a TODO, add a new TODO, remove a TODO, or exit the application.
 * The application will continue to prompt the user for input until they choose to exit.
 */

/**
var word = "ABC";
var number = 5;
*/

//Console.WriteLine("Input user choice:");
//var userChoice = Console.ReadLine();
//Console.WriteLine("User input: " + userChoice);
//userChoice = "ABC";

var userChoice ="";

var menu = new List<string>
{
    "[S]ee all TODOs",
    "[C]hange a TODO",
    "[A]dd a new TODO",
    "[R]emove a TODO",
    "[E]xit"
};



do
{

    PrintMenu(menu);

    userChoice = Console.ReadKey(true).KeyChar.ToString();

    if (null != userChoice && userChoice.Length != 0)
    {

        switch (char.ToUpper(userChoice[0]))
        {
            case 'S':
                Console.WriteLine("See all TODOs");
                break;
            case 'C':
                Console.WriteLine("Change a TODO");
                break;
            case 'A':
                Console.WriteLine("Add a new TODO");
                break;
            case 'R':
                Console.WriteLine("Remove a TODO");
                break;
            case 'E':
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    } else
    {
        userChoice = "User choice can't be null";
        Console.WriteLine(userChoice);

    }

    
}

while (char.ToUpper(userChoice[0]) != 'E');

Console.WriteLine(GOODBYEMESSAGE);

void PrintMenu(List<string> menu)
{
    foreach (var item in menu)
    {
        Console.WriteLine(item);
    }
}

decimal Add(decimal a, decimal b)
{
    return a + b;
}

bool IsEven(string input)
{
    return input.Length > 15;
}

//your code goes here
int AbsoluetOfSum(int a, int b)
{
    int c = a + b;
    if (c >= 0)
    {
        return c;
    }

    return -c;
}