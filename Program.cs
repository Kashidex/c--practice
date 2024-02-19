namespace tutoo;

class Program
{
    static void Main(string[] args)
    {
        // Line for naming the window
        Console.Title = "Dex's Toolbox";
        // Console customisation like text and background color
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WindowHeight = 40;
        
        Console.WriteLine("Greetings. Please insert username:");
        // Inserting user's input to a variable
        var username = Console.ReadLine();
        // Using the variable to reply
        Console.WriteLine($"Hello, {username}.");
        Console.ReadKey();
        
        // Asking for the desired operation
        Console.WriteLine("[1] - Addition\n[2] - Substraction\n[3] - Multiplication\n[4] - Division\n\nPlease write the number of the operation you choose: ");
        int userCalcInput;
        userCalcInput = Convert.ToInt32(Console.ReadLine());

        // Creating variables for the calculation
        int num01;
        int num02;
        int result = 0;

        // Getting the user input for the numbers
        Console.Write("Please enter the first number: ");
        num01 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        num02 = Convert.ToInt32(Console.ReadLine());

        // Depending on the operation choice, making the right calculation
        if (userCalcInput == 1){
            result = num01 + num02;
        }
        if (userCalcInput == 2){
            result = num01 - num02;
        }
        if (userCalcInput == 3){
            result = num01 * num02;
        }
        if (userCalcInput == 4){
            result = num01 / num02;
        }
        
        // Printing out the calculation
        Console.WriteLine("Your result is: " + result);

        // I'm writing 2's powers from 0 to 14 because why not
        for (int i = 0; i < 15; i++){
            Console.WriteLine(Math.Pow(2, i));
        }

        // Hitting a key will close the terminal
        Console.ReadKey();
    }
}
