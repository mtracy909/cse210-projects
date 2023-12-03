using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //First Order
        Address address1 = new Address("175 W 5th S", "Rexburg", "Idaho", "USA");
        Customer michael = new Customer("Michael Tracy", address1);
        List<Product> products1 = new List<Product>();
        Product socks = new Product("Sock", "14a68f", 4.99, 2);
        products1.Add(socks);
        Product jacket = new Product("Jacket", "83d42n", 19.99, 1);
        products1.Add(jacket);
        Order order1 = new Order(michael, products1);
        Console.WriteLine("Order total: $" + order1.GetOrderTotal() + "\n");
        Console.WriteLine(order1.GetPackingLabels() + "\n");
        Console.WriteLine(order1.GetShippingLabel() + "\n");

        //Second Order
        Address address2 = new Address("28 Boulevard de Normandie", "Forbach", "Lorraine", "France");
        Customer john = new Customer("Louis Frenchman", address2);
        List<Product> products2 = new List<Product>();
        Product baguettes = new Product("Baguette", "64k89d", 5.99, 3);
        products2.Add(baguettes);
        Product nutella = new Product("Nutella", "28i93w", 8.99, 1);
        products2.Add(nutella);
        Order order2 = new Order(john, products2);
        Console.WriteLine("Order total: $" + order2.GetOrderTotal() + "\n");
        Console.WriteLine(order2.GetPackingLabels() + "\n");
        Console.WriteLine(order2.GetShippingLabel());
    }
}