namespace Generic_Collections
{
    public class Order
    {
        static int orderIdCounter = 1; 

        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public int OrderId => _orderId; // Read-only property to access the order ID.

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            Console.WriteLine($"Beställning nr {orderIdCounter} har lagts till.");
            _orderId = orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Custom ToString method to generate a detailed string representation of the order, 
        // including item names, total price, and table number.
        public override string ToString()
        {
            string orderPrint = "";
            decimal totalPrice = 0;
            orderPrint += $"Order {_orderId}:\n";
            foreach (var item in _orderItems)
            {
                orderPrint += $"1 st {item.Name}\n";
                totalPrice += item.Price;
            }
            orderPrint += $"Summa: {totalPrice:C}\n";
            orderPrint += $"Till bord nummer {_tableNumber}";
            return orderPrint;
        }
    }
}
