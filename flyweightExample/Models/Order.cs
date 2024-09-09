using System.Collections.Generic;

namespace flyweightExample.Models
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
