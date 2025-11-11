// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

class Program
{
     static void Main()
    {
        CultureInfo bdculture = new CultureInfo("bn-BD");

        Console.WriteLine("===Mortgage calculator Bangladesh===");

        double Salary = 0;
        double creditScore = 0;
        bool criminalRecord = false;
        double loan = 0;

        

        while (true)
        {
            Console.WriteLine("Enter your monthly salary:");
            string input = (Console.ReadLine() ?? string.Empty.Trim());

            if (double.TryParse(input, out Salary))



            break;
            else
                Console.WriteLine("Invalid input! please enter a numeric number");
        }
        while (true)
        {
            Console.WriteLine("Enter your credit score:");
            string input = (Console.ReadLine() ?? string.Empty.Trim());
            if (double.TryParse(input, out creditScore))
                break;
            else
                Console.WriteLine("Invalid input! please enter a numeric number");

        }
        while (!criminalRecord)
        {
            Console.WriteLine("Enter your criminal record (true/false): ");
            
            if (!criminalRecord)
                
                break;
            else
                Console.WriteLine("You have a criminal record");
        }
        //bool eligible = true;
        while (true)
        {
            if (loan <= 2 * Salary && !criminalRecord)
                Console.WriteLine("Enter your loan amount: ");
            else
                Console.WriteLine("You are not eligible for loan");
        }
        Console.Write("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        double monthlyPayment = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months))
                               / (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - principal;

        // Set Bangladeshi Taka currency format
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

    }
}

