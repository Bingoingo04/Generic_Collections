namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant bingo = new Restaurant();

            MenuItem carbonara = new MenuItem(1, "Carbonara", 120m);
            MenuItem hamburger = new MenuItem(2, "Hamburgare", 120m);
            MenuItem garlicBread = new MenuItem(3, "Vitlöks Bröd", 45m);
            MenuItem pepsimax = new MenuItem(4, "Pepsi Max", 20m);

            bingo.AddToMenu(carbonara);
            bingo.AddToMenu(hamburger);
            bingo.AddToMenu(garlicBread);
            bingo.AddToMenu(pepsimax);

            Console.WriteLine("----------------");

            bingo.ShowMenu();

            Console.WriteLine("----------------");

            Order order1 = new Order(new List<MenuItem>() {carbonara, pepsimax }, 5);
            bingo.CreateOrder(order1);            
            Order order2 = new Order(new List<MenuItem>() {hamburger, garlicBread, pepsimax }, 5);
            bingo.CreateOrder(order2);            
            Order order3 = new Order(new List<MenuItem>() {carbonara, hamburger, pepsimax, pepsimax }, 5);
            bingo.CreateOrder(order3);

            Console.WriteLine("----------------");

            bingo.ShowOrders();

            Console.WriteLine("----------------");

            bingo.ShowOrdersCount();

            Console.WriteLine();

            bingo.ShowNextOrder();

            Console.WriteLine();
            bingo.HandleOrder();
            Console.WriteLine();
            bingo.ShowOrdersCount();

            Console.WriteLine("----------------");

            Order order4 = new Order(new List<MenuItem>() { hamburger, pepsimax }, 5);
            bingo.CreateOrder(order4);

            Console.WriteLine();
            bingo.ShowOrdersCount();
            Console.WriteLine();
            bingo.HandleOrder();
            bingo.HandleOrder();
            Console.WriteLine();
            bingo.ShowOrdersCount();

            Console.WriteLine("----------------");

            bingo.ShowNextOrder();
            Console.WriteLine();
            bingo.HandleOrder();
            Console.WriteLine();
            bingo.ShowOrdersCount();
        }
    }
}
