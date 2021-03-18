using System;

class MainClass {
  public static void Main (string[] args) {
    string name, companyName;
    float workerCost = 100000;
    double companyValue = 750000, personalProfit = 45000, envCosts = 20000;
    int month = 1;
    Console.WriteLine("Welcome to the business simulator.\n==========\nPlease enter your name:");
    name = Console.ReadLine();
    Console.WriteLine("Please enter your company name:");
    companyName = Console.ReadLine();
    Console.WriteLine("Thank you. Press enter to begin.");
    Console.ReadKey();
    Console.WriteLine("==========\n\nStart of month 1\nCost of workers: $" + workerCost + "\nEnvironment costs: $" + envCosts + "\nCompany Value: $" + companyValue + "\nYour profit per month: $" + personalProfit);
  }
}