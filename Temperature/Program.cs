Console.WriteLine("Would you like to convert your temperature to Farenheit or Celcius? (F/C):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter temperature:");
int temp = Int32.Parse(Console.ReadLine());


switch (userOperator)
{
    case 'F':
        ConvertToFarenheit(temp, 9/5);
        break;
    case 'C':
        ConvertToCelsius(temp, 32);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

static void ConvertToCelsius(int a, int b)
{
    Console.WriteLine($"{(a - b) / 1.8}");
}

static void ConvertToFarenheit(int a, int b)
{
    Console.WriteLine($"{a * b + 32}");
}