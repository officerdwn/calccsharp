public class Calculator
{
    public static void Main(string[] args)
    {

        string firstArg = args[0];
        string secondArg = args[1];
        string thirdArg = args[2];
        char op = secondArg[0];
        double result = 0;

        if (!double.TryParse(firstArg, out double num1) || !double.TryParse(thirdArg, out double num2))
        {
            Console.WriteLine("Error: Please provide valid numbers for the first and third arguments.");
            return;
        }

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    break;
                }
                else
                {
                    Console.WriteLine("no div by 0");
                    return;
                }
            default:
                Console.WriteLine("Bad op");
                return;
        }
        Console.WriteLine($"Result {num1} {op} {num2} = {result}");
        return;

    }
}