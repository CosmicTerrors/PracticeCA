using System;

namespace PracticeCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;    //Prints out Currencies with Euro Symbol
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1.Calculate Quote");
            Console.WriteLine("2.Print Statistics");
            Console.WriteLine("3.Exit");

            Console.Write("\nEnter Choice : ");
            int userOption = int.Parse(Console.ReadLine());
            loopMenu(userOption);
        }

        static private void calcPremium()
        {
            const double basicPremium = 0.03;   // Constant 3% basic premium
            const double addPremium = 0.10;     // Constant 10% additional premium if conditions are met
            double premiumQuote;

            Console.Write("\nEnter Vehicle Value: ");
            int vehicleValue = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Gender: ");
            string userGender = Console.ReadLine().ToLower();
            Console.Write("\nEnter Age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Penalty Points: ");
            int penaltyPoints = int.Parse(Console.ReadLine());

            premiumQuote = vehicleValue * basicPremium;        // Calculate The Basic Premium

            if (userGender == "male" && userAge >= 18 && userAge <= 25)
            {
                premiumQuote += premiumQuote * addPremium;      // Add Extra charge depending on the condition
            }

            switch (penaltyPoints)          // Add extra charges depending on the penalty points
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
                    premiumQuote += 300;
                    break;
                case 11:
                case 12:
                    premiumQuote += 400;
                    break;
                default:
                    Console.WriteLine("No Quote Possible");
                    break;
            }

            Console.WriteLine("\nYour Premium Quote is : {0:c2}", premiumQuote);
        }

        static private void printStats()
        {
            Console.WriteLine("{0, -10} {1,-10}", "Gender", "Age");
        }

        static private void loopMenu(int userChoice)   // Loops The Menu Program
        {
            int exitSignal = 0;
            while (exitSignal != 3)
            {
                switch (userChoice)
                {
                    case 1:
                        calcPremium();     // Calls the Calculate Method
                        break;
                    case 2:
                        printStats();     // Calls the Print Method
                        break;
                    case 3:
                        exitSignal = 3;   // Stops the Loop and exits out
                        break;
                    default:
                        Console.WriteLine("\nError!");
                        exitSignal = 3;
                        break;
                }
            }
        }
    }
}
