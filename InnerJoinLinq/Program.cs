using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoinLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>
            {
                new Product {ProductID = 1, ProductName = "Mobile"},
                new Product {ProductID = 2, ProductName = "Charger"},
                new Product {ProductID = 3, ProductName = "Pocket"},
                new Product {ProductID = 4, ProductName = "Tablet"},
                new Product {ProductID = 5, ProductName = "LapTop"},
            };

            List<Order> ProductOrders = new List<Order>
            {
                new Order {OrderID = 1, ProductID = 1, PaymentMethod = "Cheque"},
                new Order {OrderID = 2, ProductID = 5, PaymentMethod = "Credit"},
                new Order {OrderID = 3, ProductID = 1, PaymentMethod = "Cash"},
                new Order {OrderID = 4, ProductID = 3, PaymentMethod = "Cheque"},
                new Order {OrderID = 5, ProductID = 3, PaymentMethod = "Cheque"},
                new Order {OrderID = 6, ProductID = 4, PaymentMethod = "Cash"}
            };

            var OrderforProducts =
                from product in ProductList
                join order in ProductOrders
                on product.ProductID equals order.ProductID
                select new
                {
                    product.ProductID,
                    Name = product.ProductName,
                    order.PaymentMethod
                };

            foreach (var item in OrderforProducts)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}