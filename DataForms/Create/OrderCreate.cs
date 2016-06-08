using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DababaseConnection;
using DataForms.Base;
using DataForms.Edit;
using Models;

namespace DataForms.Create
{
    public class OrderCreate : DataForm<Order>
    {
        private readonly Order _item;
        private readonly List<OrderItem> _items;
        private readonly DateTime _dateTime;

        public OrderCreate(DataContext context, DateTime dateTime) : base(context)
        {
            _item = new Order();
            _items = new List<OrderItem>();
            _dateTime = dateTime;
        }

        public OrderCreate SetCustomer(Customer customer)
        {
            _item.Customer = customer;
            return this;
        }

        public OrderCreate SetCurrency(Currency currency)
        {
            _item.Currency = currency;
            return this;
        }

        public OrderCreate AddItem(OrderItem item)
        {
            _items.Add(item);
            return this;
        }

        public OrderCreate AddItemRange(IEnumerable<OrderItem> item)
        {
            _items.AddRange(item);
            return this;
        }

        public override Order Execute()
        {
            _context.Orders.Add(_item);
            _context.SaveChanges();

            _items.ForEach(x => x.Order = _item);
            _context.OrderItems.AddRange(_items);
            _context.SaveChanges();

            new OrderEdit(_context, _item)
                .SetDateTime(_dateTime)
                .SetStatus(OrderStatus.Created)
                .Execute();
            
            return _item;
        }
    }
}
