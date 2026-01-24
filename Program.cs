namespace RestaurantOrderingSystemMiniApp
{
    // Main Program
    public class Program
    {
        static void Main(string[] args)
        {
            // Create menu items
            MenuItem item1 = new MenuItem();
            item1.Id = 1;
            item1.Name = "Pizza";
            item1.Price = 12.99m;
            item1.Category = "Main Course";

            MenuItem item2 = new MenuItem();
            item2.Id = 2;
            item2.Name = "Coca Cola";
            item2.Price = 2.50m;
            item2.Category = "Drink";

            // Create order items
            OrderItem orderItem1 = new OrderItem();
            orderItem1.MenuItem = item1;
            orderItem1.Count = 2;

            OrderItem orderItem2 = new OrderItem();
            orderItem2.MenuItem = item2;
            orderItem2.Count = 1;

            // Create order
            Order order = new Order();
            order.Id = 1;
            order.OrderItems = new List<OrderItem>();
            order.OrderItems.Add(orderItem1);
            order.OrderItems.Add(orderItem2);
            order.Date = DateTime.Now;

            // Calculate total
            order.TotalAmount = 0;
            foreach (OrderItem item in order.OrderItems)
            {
                order.TotalAmount += item.MenuItem.Price * item.Count;
            }

            // Display order
            Console.WriteLine("Order ID: " + order.Id);
            Console.WriteLine("Date: " + order.Date);
            Console.WriteLine("\nItems:");

            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine(item.MenuItem.Name + " x" + item.Count + " = $" + (item.MenuItem.Price * item.Count));
            }

            Console.WriteLine("\nTotal: $" + order.TotalAmount);
        }
    }
}

