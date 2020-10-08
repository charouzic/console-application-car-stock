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
        
        // method checking correct login details - if wrong no access
        public void Login()
        {
            while(true)
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
                }
            }
            
        }

        public void callMenu()
        {
            while (true)
            {
            Console.WriteLine("************ Here are your options ************");
            Console.WriteLine("Please select the action:");
            Console.WriteLine("1. Show stock account");
            Console.WriteLine("2. Show total value of all cars in stock");
            Console.WriteLine("3. Register one car sold");
            Console.WriteLine("4. Get stock status");

            int menuAction = int.Parse(Console.ReadLine());
            switch (menuAction)
                {
                    case 1:
                        StockAccount();
                        break;

                    case 2:
                        Console.WriteLine($"Total value of Stock: {TotalValue()}");
                        break;

                    case 3:
                        Console.Write("Please provide the type of car sold (CarX or  CarY): ");
                        string carType = Console.ReadLine();
                        CarSold(carType);
                        break;

                    case 4:
                        Console.WriteLine($"Stock status: {StockStatus()}");
                        break;

                    default:
                        Console.WriteLine("Incorect option choice");
                        callMenu();
                        break;
                }
            }
        }
            
        
        // method returning number of cars in each stock
        private void StockAccount()
        {
            Console.WriteLine($"Number of Cars X in stock: {TotalInStockX}");
            Console.WriteLine($"Number of Cars Y in stock: {TotalInStockY}");
        }

        // method calculating total value of stock in USD based on number of cars and prices
        private int TotalValue()
        {
            int xStock = XPrice * TotalInStockX;
            int yStock = YPrice * TotalInStockY;
            int result = xStock + yStock;
            return result;
        }

        // method returning stock status based on number of cars in stock
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

        // mehtod allowing user to change number of cars in stock caused by selling
        private void CarSold(string carType)
        {
            switch (carType)
            {
                case "CarX":
                    TotalInStockX = TotalInStockX - 1;
                    Console.WriteLine($"Number of Car X left: {TotalInStockX}");
                    break;

                case "CarY":
                    TotalInStockY = TotalInStockY - 1;
                    Console.WriteLine($"Number of Car Y left: {TotalInStockY}");
                    break;

                default:
                    Console.WriteLine("Unknown car type");
                    break;
            }
        }
    }
}
