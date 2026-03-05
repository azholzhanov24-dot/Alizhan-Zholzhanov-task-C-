Console.WriteLine("Ex 1:");

Console.WriteLine("Enter first number");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int b1 = Convert.ToInt32(Console.ReadLine());

if (a1 > b1)
{
    Console.WriteLine("first number is greater than the second");
}
else if (b1 > a1)
{
    Console.WriteLine("second number is greater than the first");
}
else
{
    Console.WriteLine("numbers are equal");
}


Console.WriteLine("Ex 2:");

Console.WriteLine("Enter number");
int a2 = Convert.ToInt32(Console.ReadLine());

if (a2 > 5 && a2 < 10)
{
    Console.WriteLine("The number is greater than 5 and less than 10");
}
else
{
    Console.WriteLine("Unknown number");
}


Console.WriteLine("Ex 3:");

Console.WriteLine("Enter number");
int a3 = Convert.ToInt32(Console.ReadLine());

if (a3 == 5 || a3 == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else
{
    Console.WriteLine("Unknown number");
}


Console.WriteLine("Ex 4:");

Console.WriteLine("Enter deposit");
double a4 = Convert.ToDouble(Console.ReadLine());
if (a4 < 100)
{
    a4 = a4 + (a4 * 5 / 100);
    Console.WriteLine(a4);
}
else if (100 <= a4 && a4 <= 200)
{
    a4 = a4 + (a4 * 7 / 100);
    Console.WriteLine(a4);
}
else
{
    a4 = a4 + (a4 * 10 / 100);
    Console.WriteLine(a4);
}


Console.WriteLine("Ex 5:");

Console.WriteLine("Enter deposit");
double a5 = Convert.ToDouble(Console.ReadLine());
if (a5 < 100)
{
    a5 = a5 + (a5 * 5 / 100) + 15;
    Console.WriteLine(a5);
}
else if (100 <= a5 && a5 <= 200)
{
    a5 = a5 + (a5 * 7 / 100) + 15;
    Console.WriteLine(a5);
}
else
{
    a5 = a5 + (a5 * 10 / 100) + 15;
    Console.WriteLine(a5);
}


Console.WriteLine("Ex 6:");

Console.WriteLine("Choose operation: 1 is +, 2 is -, 3 is *");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("Plus");
        break;

    case 2:
        Console.WriteLine("Minus");
        break;

    case 3:
        Console.WriteLine("Multiplication");
        break;

    default:
        Console.WriteLine("Unknown operation");
        break;
}


Console.WriteLine("Ex 7:");

Console.WriteLine("Choose operation: 1 is +, 2 is -, 3 is *");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter first number:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int y2 = Convert.ToInt32(Console.ReadLine());

switch (y)
{
    case 1:
        Console.WriteLine(y1 + y2);
        break;

    case 2:
        Console.WriteLine(y1 - y2);
        break;

    case 3:
        Console.WriteLine(y1 * y2);
        break;

    default:
        Console.WriteLine("Unknown operation");
        break;
}