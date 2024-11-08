namespace Generic_Collections
{
    internal class Restaurant
    {
        private List<MenuItem> _menu = new List<MenuItem>();
        private Queue<Order> _orders = new Queue<Order>();

        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            foreach (var menuItem in _menu)
            {
                // Display each menu item's ID and details
                Console.WriteLine($"{menuItem.Id}. {menuItem.ToString()}");
            }
        }

        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order); // Add a new order to the queue
        }

        public void HandleOrder()
        {
            if (_orders.Count > 0)
            {
                var order = _orders.Dequeue(); // Remove the next order from the queue
                Console.WriteLine($"Order {order.OrderId} färdig.");
            }
            else
            {
                // Message if there are no orders to handle
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }

        public void ShowOrders()
        {
            if (_orders.Count > 0)
            {
                Console.WriteLine("Aktuella beställningar");
                foreach (var order in _orders)
                {
                    // Display each order using its ToString method
                    Console.WriteLine(order);
                }
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }

        public void ShowNextOrder()
        {
            if (_orders.Count > 0)
            {
                // Peek at the next order without removing it from the queue
                Console.Write("Nästa order i kön:");
                Console.WriteLine(_orders.Peek());
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }

        public void ShowOrdersCount()
        {
            if (_orders.Count > 0)
            {
                // Show the total number of orders in the queue
                Console.WriteLine($"Det är {_orders.Count} i kön.");
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }
    }
}
