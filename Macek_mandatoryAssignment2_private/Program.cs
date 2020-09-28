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
            carStock.TotalInStockX = 10;
            carStock.TotalInStockY = 19;

            // calling function that checks the login details
            carStock.Login();
        }
    }
}
