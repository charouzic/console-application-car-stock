using System;

namespace Macek_mandatoryAssignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int xprice = 120000;
            int yprice = 75000;
            int stockX = 100;
            int stockY = 12;

            // creating object and filling it with variables
            CarStock carStock = new CarStock();

            Console.Write("Please provide username to access the BrandX system: ");
            string userName = Console.ReadLine();
            Console.Write("Please provide password: ");
            string pwd = Console.ReadLine();

            // calling function that checks the login details
            carStock.Login(userName, pwd, xprice, yprice, stockX, stockY);
        }
    }
}

/* I had issue with writing the code in a way that I can give the user option to
   have multiple attempts to log into the program. Also what I found a little bit
   tricky was to assign the values to stock size and price in the main function
   since I wanted to make the functions hidden as private one otherwise the login
   functionality wouldn't make any sense.
   Also what I found difficult is to write the code, methods and classes in a way
   that they are reusable as much as possible. 
*/