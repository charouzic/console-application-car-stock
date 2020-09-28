using System;
namespace Macek_mandatoryAssignment2
{
    public class CarStock
    {
        public int XPrice { get; set; }
        public int YPrice { get; set; }
        public int TotalInStockX { get; set; }
        public int TotalInStockY { get; set; }

        private string adminName = "admin";
        private string adminPwd = "Listen20";
        

        public void Login()
        {
            Console.Write("Please provide username to access the BrandX system: ");
            string userName = Console.ReadLine();
            Console.Write("Please provide password: ");
            string pwd = Console.ReadLine();

            if ((userName == adminName) & (pwd == adminPwd))
            {
                callMenu();
            }

            else
            {
                Console.WriteLine("Incorrect login name and/or password");
                Console.WriteLine("Try again? Press 1, for exit press any other number");
                int logAgain = int.Parse(Console.ReadLine());

                if (logAgain == 1)
                {
                    Login();
                }
            }
        }

        public void callMenu()
        {
            Console.WriteLine("************ Here are your options ************");
            Console.WriteLine("Please select the action:");
            Console.WriteLine("1. Show stock account");
            Console.WriteLine("2. Show total value of all cars in stock");
            Console.WriteLine("3. Register one car sold");
            Console.WriteLine("4. Get stock status");

            int menuAction = int.Parse(Console.ReadLine());

            if (menuAction == 1)
            {
                StockAccount();
            }

            if (menuAction == 2)
            {
                Console.WriteLine($"Total value of Stock: {TotalValue()}");
            }

            if (menuAction == 3)
            {
                Console.Write("Please provide the type of car sold (CarX or  CarY): ");
                string carType = Console.ReadLine();
                CarSold(carType);
            }

            if (menuAction == 4)
            {
                Console.WriteLine($"Stock status: {StockStatus()}");
            }

            if (menuAction > 4 || menuAction < 1)
            {
                Console.WriteLine("That is not an option");
            }

            Console.WriteLine("For returning to the menu press 1, otherwise press any other number");
            int again = int.Parse(Console.ReadLine());

            if (again == 1)
            {
                callMenu();
            }
            else
            {
                Console.WriteLine("Thank you for using the software, hope to see you soon");
            }
        }

        private void StockAccount()
        {
            Console.WriteLine($"Number of Cars X in stock: {TotalInStockX}");
            Console.WriteLine($"Number of Cars Y in stock: {TotalInStockY}");
        }

        private int TotalValue()
        {
            int xStock = XPrice * TotalInStockX;
            int yStock = YPrice * TotalInStockY;
            int result = xStock + yStock;
            return result;
        }

        private string StockStatus()
        {
            int stockNumber = TotalInStockX + TotalInStockY;

            if (stockNumber < 10)
            {
                return "Very Low";
            }

            if (stockNumber <= 25)
            {
                return "Low";
            }

            else if (stockNumber <= 100)
            {
                return "Normal";
            }

            else
            {
                return "Over";
            }
        }

        private void CarSold(string carType)
        {
            if (carType == "CarX")
            {
                TotalInStockX = TotalInStockX - 1;
                Console.WriteLine($"Number of Car X left: {TotalInStockX}");
            }

            else if (carType == "CarY")
            {
                TotalInStockY = TotalInStockY - 1;
                Console.WriteLine($"Number of Car Y left: {TotalInStockY}");
            }
            else
            {
                Console.WriteLine("Unknown car type");
            }
        }
    }
}
