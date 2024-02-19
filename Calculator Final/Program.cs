class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("_-_-_-_    Simple Calculator    _-_-_-_-_");

        string value;

        ICalculator calculator = new MomoCalculator();
        IValidator validator = new Validator();

        do
        {
            //double numb1, num2;
            //string symbol;
            Console.WriteLine("Enter the first number: ");
            string inp1 = Console.ReadLine();
            double numb1 = validator.IsValidNumber(inp1);

            Console.WriteLine("Enter the second number: ");
            string inp2 = Console.ReadLine();
            double num2 = validator.IsValidNumber(inp2);

            Console.WriteLine("Enter your operation (*,+,-,%,^,%,sqrt) : ");
            string operation = Console.ReadLine();
            string symbol = validator.IsValidOperator(operation);

            double result = 0;

            switch (symbol)
            {
                case "*":
                    result = calculator.Multiply(numb1, num2);
                    break;

                case "+":
                    result = calculator.Add(numb1, num2);
                    break;

                case "-":
                    result = calculator.Subtract(numb1, num2);
                    break;

                case "/":
                    result = calculator.Divide(numb1, num2);
                    break;

                case "%":
                    result = calculator.Reminder(numb1, num2);
                    break;

                case "^":
                    result = calculator.Power(numb1, num2);
                    break;

                case "sqrt":
                    result = calculator.Sqrt(numb1);
                    break;
            }
            Console.WriteLine($"Result of {numb1} {symbol} {num2} is: {result}");
            Console.Write("\nDo you want to continue? (y or n): ");
            value = Console.ReadLine();

        } while (value == "y" || value == "Y");
    }
}
