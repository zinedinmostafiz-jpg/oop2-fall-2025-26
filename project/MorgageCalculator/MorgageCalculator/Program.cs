// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;

long p = Console.ReadLine("Enter total amount:");
long r = Console.ReadLine("Enter interest rate:");
int n = Console.ReadLine("Enter number of payments:");

long monthlyInterest = r / (100 * 12);
int numberofPayment   = n * 12;
long m = r * Math.Pow(1 + monthlyInterest, numberofPayment) / Math.Pow(1 + monthlyInterest, numberofPayment) - 1;
Console.WriteLine("Total monthly morgage payment:"{ m});
class main
{
    static void main()
    {
        cultureinfo bdculture = new cultureinfo("bn-bd");
        Console.WriteLine("Total monthly morgage payment:"ToString("c"{ m}));
        Console.WriteLine(ToString("c"{ p}));

    }
        


}

