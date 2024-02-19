public class Validator : IValidator
{
    public double IsValidNumber(string inp)
    {
        while (true)
        {
            //Console.WriteLine("Enter your number:");
            if (double.TryParse(inp, out double number))
            {
                return number;
            }
            Console.WriteLine("Invalid number !! Please enter a valid number:");
            inp = Console.ReadLine();
        }
    }
    public string IsValidOperator(string operation)
    {
        while (true)
        {
            //Console.WriteLine("Enter symbol of function (*, +, -, /, %, ^, sqrt):");
            if (operation == "*" || operation == "+" || operation == "-" || operation == "/" || operation == "%" || operation == "^" || operation == "sqrt")
            {
                return operation;
            }
            else
            {
                Console.WriteLine("Invalid operator! Please use operators listed above :");
                operation = Console.ReadLine();
                
            }
        }
    }
}
