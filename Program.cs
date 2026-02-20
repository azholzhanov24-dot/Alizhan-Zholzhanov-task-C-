using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter product name:");
        string productName = Console.ReadLine(); //1

        Console.WriteLine("Enter quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine()); //2

        Console.WriteLine("Enter price:");
        double price = Convert.ToDouble(Console.ReadLine()); //3

        Console.WriteLine("Enter discount percent:");
        int discountPercent = Convert.ToInt32(Console.ReadLine()); //4

        Console.WriteLine("Is delivery (true/false):");
        bool isExpress = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Enter distance in km:");
        double distance = Convert.ToDouble(Console.ReadLine()); //6

        Console.WriteLine("Enter payment method card or cash:");
        string payment = Console.ReadLine(); //7

        double totalPrice = quantity * price;
        double discountAmount = totalPrice * discountPercent / 100;
        double finalPrice = totalPrice - discountAmount + distance;

        Console.WriteLine($"Price without discount: {totalPrice}"); //1
        Console.WriteLine($"Discount: {discountAmount}"); //2
        Console.WriteLine($"Final Price: {finalPrice}"); //3
    }
}
