using System;

namespace Macek_mandatoryAssignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            // creating object and filling it with variables
            CarStock carStock = new CarStock();

            carStock.XPrice = 120000;
            carStock.YPrice = 75000;
            carStock.TotalInStockX = 100;
            carStock.TotalInStockY = 19;

            // calling function that checks the login details
            carStock.Login();
        }
    }
}

/* 
Initially I put the code together using if else statements but then I replaced
them in the Login method for while loop which gives better flexibility.
Moreover, I tried to make it as private as possible due to login functionality
so the user cannot access the features of the program without having the correct
login details.
*/
