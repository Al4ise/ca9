public class CurrencyConverter
{
    private static double conversionRate = 0.51129; // Conversion rate from BGN to EUR as of Feb 2024

    public static double ConvertToEUR(double bgn)
    {
        return Math.Round(bgn * conversionRate, 2);
    }

    public static double ConvertToBGN(double eur)
    {
        return Math.Round(eur / conversionRate, 2);
    }
}

public class IOOperations
{
    public static void StartConversion()
    {
        Console.WriteLine("Enter '1' to convert from BGN to EUR, '2' to convert from EUR to BGN:");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Enter amount in BGN:");
            double bgn = double.Parse(Console.ReadLine());
            Console.WriteLine($"{bgn} BGN is equal to {CurrencyConverter.ConvertToEUR(bgn)} EUR");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter amount in EUR:");
            double eur = double.Parse(Console.ReadLine());
            Console.WriteLine($"{eur} EUR is equal to {CurrencyConverter.ConvertToBGN(eur)} BGN");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter '1' or '2'.");
            StartConversion();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IOOperations.StartConversion();
    }
}
