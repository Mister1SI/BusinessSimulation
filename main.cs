using System;

class MainClass {
  public static void Main (string[] args) {
    string name, companyName, res;
    float workerCost = 100000, wage = 10;
    double companyValue = 750000, personalProfit = 45000, envCosts = 20000;
    int month = 1, workers = 10000;
    bool wageChange = true, workerChange = true;
    Console.WriteLine("Welcome to the business simulator.\n==========\nPlease enter your name:");
    name = Console.ReadLine();
    Console.WriteLine("Please enter your company name:");
    companyName = Console.ReadLine();
    Console.WriteLine("Thank you. Press enter to begin.");
    Console.ReadKey();
    while (true) {
    Console.WriteLine("==========\n\nStart of month " + month + "\nCost of workers: $" + workerCost + "\nEnvironment costs: $" + envCosts + "\nCompany Value: $" + companyValue + "\nYour profit per month: $" + personalProfit);
    Console.WriteLine("\nAmount of workers: " + workers);
    Console.WriteLine("\nChange workers wage?(current wage: " + wage + ")(y or n or stop)");
    res = Console.ReadLine();
    if (res == "y") {
      Console.WriteLine("Change to what?");
      while (wageChange) {
        try {
          wage = float.Parse(Console.ReadLine());
          workerCost = workers * wage;
          Console.WriteLine("Changed wage to " + wage + ". Current worker costs: $" + workerCost + "\nCurrent workers: " + workers);
          wageChange = false;
        } catch (Exception e) {
          Console.WriteLine("That's not a valid in-range number. Change to what?");
        }
      }
    } else if (res == "stop") {
      break;
    }
    Console.WriteLine("Change amount of workers?(y or n or stop)");
    res = Console.ReadLine();
    if (res == "y") {
      Console.WriteLine("Change to what?");
      while (workerChange) {
        try {
          workers = Convert.ToInt32(Console.ReadLine());
          workerCost = workers * wage;
          Console.WriteLine("Changed workers to " + workers + ". Current worker costs: " + workerCost);
          workerChange = false;
        } catch (Exception e) {
          Console.WriteLine("That's not a valid in-range number. Chnage to what?");
        }
      }
    } else if (res == "stop") {
      break;
    }
   month++; 
  }
}
}