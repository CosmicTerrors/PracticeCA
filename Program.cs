using System;

namespace PracticeCA
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitSignal = 0;
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Calculate Quote");
            Console.WriteLine("2. Print Statistics");
            Console.WriteLine("3.Exit");

            Console.WriteLine("\nEnter Choice : ");
            int userOption = int.Parse(Console.ReadLine());

            while (exitSignal != 3)
            {
                switch (userOption)
                {
                    case 1:
                        calcPremium();
                        break;
                    case 2:
                        printStats();
                        break;
                    case 3:
                        exitSignal = 3;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }

        static private void calcPremium()
        {
            const double basicPremium = 0.3;
            const double addPremium = 0.10;
            double premiumQuote;

            Console.Write("Enter Vehicle Value: ");
            int vehicleValue = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Gender: ");
            string userGender = Console.ReadLine().ToLower();
            Console.Write("\nEnter Age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Penalty Points: ");
            int penaltyPoints = int.Parse(Console.ReadLine());

            premiumQuote = vehicleValue * basicPremium;

            if (userGender == "male" && userAge >= 18 && userAge <= 25)
            {
                premiumQuote += premiumQuote * addPremium;
            }

            switch (penaltyPoints)
            {
                case 0:
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    premiumQuote += 100;
                    break;
                case 5:
                case 6:
                case 7:
                    premiumQuote += 200;
                    break;
                case 8:
                case 9:
                case 10:
                    premiumQuote 
                default:
                    Console.WriteLine("No Quote Possible");
                    break;
            }
        }

        static private void printStats()
        {

        }
    }
}
