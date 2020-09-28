using System;
namespace Macek_mandatoryAssignment2
{
    public class CarStock
    {
        string carType;

        private string adminName = "admin";
        private string adminPwd = "Listen20";

        Menu menu = new Menu();

        

        public void Login(string userName, string password, int xprice, int yprice, int stockX, int stockY)
        {
            // assigning values 
            menu.XPrice = xprice;
            menu.XPrice = yprice;
            menu.TotalInStockX = stockX;
            menu.TotalInStockY = stockY;

            if ((userName == adminName) & (password == adminPwd))
            {
                menu.callMenu();
            }

            else
            {
                Console.WriteLine("Incorrect login name and/or password. \nYou are not authorized to access this service");
            }
        }
    }
}