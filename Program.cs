// See https://aka.ms/new-console-template for more information
// The reason I am using do while loop is for the code to run through the do loop before looking at the while condition
do
{
    try
    {
        Console.Clear();
        Console.Write("Enter a number: ");// I used Write and not WriteLine because write does not insert a new line at the end of the output
        double num = Convert.ToDouble(Console.ReadLine()); // I used double so as to get a decimal point

        Console.Write("Enter an operator: ");
        string op = Console.ReadLine();// op in this case stands for operation and I left it blank because the operator can change based on the given parameters

        Console.Write("Enter a number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Result: ");
        // if else if statement is used so as to be able to use the operators
        if (op == "+")
        {
            Console.WriteLine(num + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num * num2);
        }
        else if (op == "/")
        {
            Console.WriteLine(num / num2);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error:{ex.Message}");
    }
    // when the operation is over, you have the option to continue or off the calculator
    Console.WriteLine("Would you like to continue?: (Y = yes, N = no)");
} while (Console.ReadLine().ToUpper() == "Y");
Console.WriteLine("BYE!");// the while condition tells the calculator that when no is entered it should display BYE!

