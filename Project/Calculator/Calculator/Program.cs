using System;

class Program
{
    static void Main()
    {
        int option;
        double num1, num2, result;
        string again;

        do
        {
            Console.WriteLine("---Calculator---");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Select option (1 to 4): ");
            option = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine()!);

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }

            Console.Write("\nDo you want to calculate again? (y/n): ");
            again = Console.ReadLine()!;

        }while(again == "y" || again == "Y");

        Console.WriteLine("Calculator closed, Sir.");
    }
}
