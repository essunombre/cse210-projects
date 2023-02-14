using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1.SetCity("Salt Lake City");
        address1.SetStreet("20 N street");
        address1.SetCountry("United States");
        address1.SetState("Utah");
        address1.SetInternational(true);

        Customer customer1 = new Customer();
        customer1.SetName("Ronal McDonald");
        customer1.SetAddress(address1);

        Product product1C1 = new Product();
        product1C1.SetName("Realme 6pro");
        product1C1.SetId("REA658");
        product1C1.SetPrice(225);
        product1C1.SetQuantity(2);

        Product product2C1 = new Product();
        product2C1.SetName("Nintendo Switch");
        product2C1.SetId("NSA522");
        product1C1.SetPrice(350);
        product2C1.SetQuantity(10);

        Product product3C1 = new Product();
        product3C1.SetName("iPphone 14");
        product3C1.SetId("IP2006");
        product3C1.SetPrice(600);
        product3C1.SetQuantity(3);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.SetProduct(product1C1);
        order1.SetProduct(product2C1);
        order1.SetProduct(product3C1);

        //2
        Address address2 = new Address();
        address2.SetCity("Carrera 58c # 152B - 22");
        address2.SetStreet("Colina Campestre");
        address2.SetCountry("Colombia");
        address2.SetState("Bogota");
        address2.SetInternational(false);
        address2.Display();

        Customer customer2 = new Customer();
        customer2.SetName("Jose David");
        customer2.SetAddress(address2);

        Product product1C2 = new Product();
        product1C2.SetName("Hunk160");
        product1C2.SetId("HU456");
        product1C2.SetPrice(1000);
        product1C2.SetQuantity(1);
        Console.WriteLine(product1C2.CalculatePrice());

        Product product2C2 = new Product();
        product2C2.SetName("Boxer 100");
        product2C2.SetId("GAMINEAMEPICAME");
        product2C2.SetPrice(10);
        product2C2.SetQuantity(3);
        Console.WriteLine(product2C2.CalculatePrice());

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.SetProduct(product1C2);
        order2.SetProduct(product2C2);

        List<Order> ordenes = new List<Order>();
        ordenes.Add(order1);
        ordenes.Add(order2);

        foreach(Order orden in ordenes)
        {
            orden.GetShippingLabel();
            Console.WriteLine("");
            orden.ShowPackingLabel();
            Console.WriteLine("");
            Console.WriteLine(orden.GetTotalPrice());
            Console.WriteLine("");                
        }
    }
}//If it is returning (since it is a void) I must use the ConsoleWriteLine