class Program
{
    static void Main(string[] args)
    {

        do
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Substract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Divide");
            Console.Write("Enter an option: ");

            try
            {
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid input");
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            Console.WriteLine("Would you like to continue? (Y = yes, N = no): ");

        } while (Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("Thanks for using the calculator!");

        Console.ReadKey();


    }

}
