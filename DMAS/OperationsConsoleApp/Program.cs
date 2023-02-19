using Operation;

char inputKey = GetOperationDetails();
int firstNumber = GetFirstNumber();
int secondNumber = GetSecondNumber();
PerformArithmeticOperation(inputKey, firstNumber, secondNumber);
Console.ReadKey();

static char GetOperationDetails()
{
    Console.WriteLine("Enter input 1.Add 2.Subtract 3.Multiply 4.Divide");
    var inputKey = Console.ReadKey().KeyChar;
    Console.WriteLine();
    return inputKey;
}

static int GetFirstNumber()
{
    Console.WriteLine("Input the first number");
    var firstNumberKey = Console.ReadKey().KeyChar;
    Console.WriteLine();
    int firstNumber = 0;
    int.TryParse(firstNumberKey.ToString(), out firstNumber);
    return firstNumber;
}

static int GetSecondNumber()
{
    Console.WriteLine("Input the second number");
    var secondNumberKey = Console.ReadKey().KeyChar;
    Console.WriteLine();
    int secondNumber = 0;
    int.TryParse(secondNumberKey.ToString(), out secondNumber);
    return secondNumber;
}

static void PerformArithmeticOperation(char inputKey, int firstNumber, int secondNumber)
{
    int operation = 0;
    int.TryParse(inputKey.ToString(), out operation);
    BasicOperation op = new BasicOperation();
    int result = 0;
    switch (operation)
    {
        case 1:
            result = op.Add(firstNumber, secondNumber);
            Console.WriteLine($"The sum of two numbers is {result}");
            break;
        case 2:
            result = op.Sub(firstNumber, secondNumber);
            Console.WriteLine($"The difference of two numbers is {result}");
            break;
        case 3:
            result = op.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"The product of two numbers is {result}");
            break;
        case 4:
            result = op.Divide(firstNumber, secondNumber);
            Console.WriteLine($"The quotient of two numbers is {result}");
            break;
        default:
            break;
    }
}