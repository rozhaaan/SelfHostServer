using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "Order 1", Category = "Groceries", Price = 1},
            new Order { Id = 2, Name = "Order 2", Category = "Toys", Price = 3},
            new Order { Id = 3, Name = "Order 3", Category = "Hardware", Price = 16},
        };

        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        { 
            return orders; 
        }
    }


}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}