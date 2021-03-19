using System;
using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        string name, companyName, res;
        float workerCost = 100000, wage = 10;
        double companyValue = 11110237.19, personalProfit, envCosts = 20000, revenue = 195792.64;
        int month = 1, workers = 1000, workerChangeNum, workerChangeIn;
        bool wageChange = true, workerChange = true, envChange = true;
        personalProfit = revenue * 0.01;
        Console.WriteLine("Welcome to the business simulator.\n==========\nPlease enter your name:");
        name = Console.ReadLine();
        Console.WriteLine("Please enter your company name:");
        companyName = Console.ReadLine();
        Console.WriteLine("Thank you. Press enter to begin.");
        Console.ReadKey();
        while (true)
        {
            Console.WriteLine("==========\n\nStart of month " + month + "\nCost of workers: $" + workerCost + "\nEnvironment costs: $" + envCosts + "\nCompany Value: $" + companyValue + "\nYour profit per month: $" + personalProfit);
            Console.WriteLine("\nAmount of workers: " + workers);
            Console.WriteLine("\nChange workers wage?(current wage: " + wage + ")(y or n or stop)");
            res = Console.ReadLine();
            if (res == "y")
            {
                Console.WriteLine("Change to what?");
                while (wageChange)
                {
                    try
                    {
                        wage = float.Parse(Console.ReadLine());
                        workerCost = workers * (wage * 200);
                        Console.WriteLine("Changed wage to " + wage + ". Current worker costs: $" + workerCost + "\nCurrent workers: " + workers);
                        wageChange = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a valid in-range number. Change to what?");
                    }
                }
            }
            else if (res == "stop")
            {
                break;
            }
            Console.WriteLine("Change amount of workers?(y or n or stop)");
            res = Console.ReadLine();
            if (res == "y")
            {
                Console.WriteLine("Change to what?");
                while (workerChange)
                {
                    try
                    {
                        workerChangeIn = Convert.ToInt32(Console.ReadLine());
                        workerChangeNum = workers - workerChangeIn;
                        if (workerChangeNum < workers)
                        {
                            revenue = revenue - (workerChangeNum * 10);
                        }
                        companyValue = companyValue - (workerChangeNum - (companyValue * 0.0001));
                        workers = workerChangeNum;
                        workerCost = workers *(wage * 200);
                        Console.WriteLine("Changed workers to " + workers + ". Current worker costs: " + workerCost);
                        workerChange = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a valid in-range number. Chnage to what?");
                    }
                }
            }
            Console.WriteLine("Change environment preservance costs?(y or n or stop)");
            res = Console.ReadLine();
            if (res == "y")
            {
                Console.WriteLine("Change to what?");
                while (envChange)
                {
                    try
                    {
                        envCosts = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Changed environment preservance costs to " + envCosts + ".");
                        envChange = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a valid in-range number. Chnage to what?");
                    }
                }
            }
            else if (res == "stop")
            {
                break;
            }
            if (wage <= 6)
            {
                workers = workers - ((Math.Abs(Convert.ToInt32(wage * 100)) + 600) / 20);
                Console.WriteLine("You lost some workers because your wage was too low!");
            }
            if (revenue < -10000)
            {
                Console.WriteLine("You went out of business!");
                break;
            }
            personalProfit = revenue * 0.01;
            companyValue = companyValue + revenue - workerCost - envCosts - personalProfit;
            month++;
        }
    }
}