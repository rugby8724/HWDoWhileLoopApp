
bool exitProgram = false;

do
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();
    if (name.ToLower() == "tim")
    {
        Console.WriteLine("Welcome Professor Tim");
    }
    else
    {
        Console.WriteLine($"Welcome to the class {name}");
    }
    Console.WriteLine("Press E if you would like to exit the program, else press enter to continue");
    string exitResponse = Console.ReadLine();
    if (exitResponse.ToLower() == "e")
    {
        exitProgram = true;
    }

} while (!exitProgram);
