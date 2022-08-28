using System;
namespace Program3
{
    class CalculatorProgram
    {
        static void Calculator()
        {
            while (true)
            {
                var value1 = inputDouble("Enter the first operand");
                var value2 = inputDouble("Enter the second operand");
                var choice = inputString("Enter the choice of operator +, - ,X or / \nOr '0' to exit ");


                switch (choice)
                {
                    case "+":
                        Console.WriteLine($"The added value is {value1 + value2}");
                        break;

                    case "-":
                        Console.WriteLine($"The Subtracted value is {value1 - value2}");
                        break;
                    case "X":
                        Console.WriteLine($"The Multiplied value is {value1 * value2}");
                        break;
                    case "/":
                        Console.WriteLine($"The Divided value is {value1 / value2}");
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
        static double inputDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
        static string inputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Calculator();
        }

    }
}

