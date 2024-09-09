using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noFlyweightExample.Models
{
    public class Order
    {
        private readonly List<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }

        public void Add(OrderItem item)
        {
            _items.Add(item);
        }
    }
}
