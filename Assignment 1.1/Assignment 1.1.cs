/*
 * Create a console application in C# to store and print
 * personal details of a person like name, age and address
 * on console screen. Make use of appropriate variables.
*/
static void function1()
{
    Console.WriteLine("Personal Details");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Age: ");
    string age = Console.ReadLine();
    Console.Write("Address: ");
    string address = Console.ReadLine();
    Console.WriteLine($"{name} ({age}) lives in {address}");
}

/*
 * Write a C# program to print the sum of two numbers.
 * Get the input from user.
 */
static void function2()
{
    Console.WriteLine("Addition");
    Console.Write("num1: ");
    string num1 = Console.ReadLine();
    Console.Write("num2: ");
    string num2 = Console.ReadLine();
    double sum = Convert.ToDouble(num1)+Convert.ToDouble(num2);
    Console.WriteLine($"{num1} + {num2} = {sum}");
}

/*
 * Write a C# program to print the result of
 * dividing two numbers. Print the quotient and
 * remainder as well. Get the input from the user.
 */
static void function3()
{
    Console.WriteLine("Division");
    Console.Write("num1: ");
    string num1 = Console.ReadLine();
    Console.Write("num2: ");
    string num2 = Console.ReadLine();

    int quotient = Convert.ToInt32(num1)/Convert.ToInt32(num2);
    int remainder = Convert.ToInt32(num1) % Convert.ToInt32(num2);
    Console.WriteLine($"{num1}/{num2} = {quotient}...{remainder}");
}

string input = "initialized";
while(input!="quit")
{
    Console.Write("Assignment 1.1 Menu (Choose 1-3): ");
    input = Console.ReadLine();
    if (input == "1")
    {
        function1();
    }
    else if (input == "2")
    {
        function2();
    }
    else if (input == "3")
    {
        function3();
    }
    else if (input == "quit")
    {
        Console.WriteLine("Ending program...");
    } else
    {
        Console.WriteLine("Invalid option");
    }
}


