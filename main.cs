using System;

class MainClass {
  public static void Main (string[] args) {
    string name, companyName, res;
    float workerCost = 100000, wage = 10;
    double companyValue = 750000, personalProfit = 45000, envCosts = 20000;
    int month = 1, workers = 10000;
    Console.WriteLine("Welcome to the business simulator.\n==========\nPlease enter your name:");
    name = Console.ReadLine();
    Console.WriteLine("Please enter your company name:");
    companyName = Console.ReadLine();
    Console.WriteLine("Thank you. Press enter to begin.");
    Console.ReadKey();
    Console.WriteLine("==========\n\nStart of month 1\nCost of workers: $" + workerCost + "\nEnvironment costs: $" + envCosts + "\nCompany Value: $" + companyValue + "\nYour profit per month: $" + personalProfit);
    Console.WriteLine("\nAmount of workers: " + workers);
    Console.WriteLine("\nChange workers wage?(current wage: " + wage + ")(y or n)");
    res = Console.ReadLine();
    if (res == "y") {
      Console.WriteLine("Change to what?");
      wage = (float)Console.ReadLine();
      Console.WriteLine("Changed wage to " + wage + ".");
    }
  }
}