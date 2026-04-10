//short user_input = Convert.ToInt16(Console.ReadLine());

//switch (user_input)
//{
//    case 5:
//        Console.WriteLine("Number is 5");
//        break;
//    case 15:
//        Console.WriteLine("Number is 15");
//        break;
//    default:
//        Console.WriteLine("Number is unrecognized");
//        break;
//}

//for (float i = 10; i >= 1; i--)
//{
//    Console.WriteLine("Element: {0}", i);
//}

//byte i = 10;
//while (i >= 1)
//{
//    Console.WriteLine("Element {0}", i);
//    i--;
//}

//bool x = true;
//while (x)
//{
//    string end = Console.ReadLine();
//    if (end == "end")
//        x = false;
//}

//byte i = 100;
//do
//{
//    Console.WriteLine("Element:" + i);
//} while (i < 10);

//for (short i = 0; i < 10; i++)
//{
//    if (i > 5)
//        break;
//    Console.WriteLine("El: " + i);

//}

//for (short i = 0; i < 10; i++)
//{
//    if (i % 2 == 0)
//        continue;
//    Console.WriteLine("El: " + i);

//}

//byte[] nums = new byte[5];
//nums[0] = 250;
//nums[1] = 50;
//nums[2] = 20;
//nums[3] = 100;
//nums[4] = 25;

//string[] w = new string[] { "John", "Bob", "Alex" };
//w[1] = "Josh";

//for (byte i = 0; i < nums.Length; i++)
//    Console.WriteLine("El: " + nums[i]);


Console.WriteLine("Task 1");
Console.WriteLine("01 Sum of elements:");
int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach (int n in numbers)
    sum += n;

Console.WriteLine("Sum = " + sum);
Console.WriteLine();

Console.WriteLine("Task 2");
Console.WriteLine("02 Min & Max:");
int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

int min = temps[0];
int max = temps[0];

foreach (int t in temps)
{
    min = Math.Min(min, t);
    max = Math.Max(max, t);
}

Console.WriteLine($"Min = {min}, Max = {max}");
Console.WriteLine();

Console.WriteLine("Task 3");
Console.WriteLine("03 Reverse array:");
string[] words = { "apple", "banana", "cherry", "date" };

Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));
Console.WriteLine();

Console.WriteLine("Task 4");
Console.WriteLine("04 Even & Odd:");
int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

int even = 0, odd = 0;

foreach (int d in data)
{
    if (d % 2 == 0) even++;
    else odd++;
}

Console.WriteLine($"Even = {even}, Odd = {odd}");
Console.WriteLine();

