using CRUD_EF.Data;
using CRUD_EF.Models;

namespace CRUD_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext dbContext = new ApplicationDbContext();

            Product product1 = new Product() { Name = "Product 1" ,Price= 999.9};
            Product product2 = new Product() { Name = "Product 2", Price = 500 };
            Product product3 = new Product() { Name = "Product 3", Price = 400 };

            Order order1 = new Order() { address = "Tulkarem", CreatedAt = DateTime.Now.AddHours(-1) };
            Order order2 = new Order() { address = "Nablus", CreatedAt = DateTime.Now.AddDays(2) };
            Order order3 = new Order() { address = "Jenin", CreatedAt = DateTime.Now.AddHours(3) };

            //Add Data to products table
            dbContext.Products.Add(product1);
            dbContext.Products.Add(product2);
            dbContext.Products.Add(product3);

            //Add Data to Orders table
            dbContext.Orders.Add(order1);
            dbContext.Orders.Add(order2);
            dbContext.Orders.Add(order3);

            //Gel All Products and Orders
           var products = dbContext.Products.ToList();
           var orders = dbContext.Orders.ToList();
            foreach( var item in products)
           {
               Console.WriteLine("Name : " + item.Name + ", The Price " + item.Price);
           }
           foreach (var item in orders)
           {
             Console.WriteLine(item.address);
           }

            //update product name
            // var product = dbContext.Products.First();
            /// product.Name = "Product 4";

            //update createdAt
            ///  var order = dbContext.Orders.First();
              ///order.CreatedAt = DateTime.Now;


            //remove product id= 2
              var product = dbContext.Products.First(p => p.Id  == 2);
               dbContext.Products.Remove(product);

            var order = dbContext.Orders.First(o => o.Id == 3);
            dbContext.Orders.Remove(order);

            dbContext.SaveChanges();



        }
    }
}
