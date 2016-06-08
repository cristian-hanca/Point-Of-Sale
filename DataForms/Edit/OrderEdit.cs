using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DababaseConnection;
using DataForms.Base;
using DataForms.Create;
using Models;

namespace DataForms.Edit
{
    public sealed class OrderEdit : InsertForm<OrderEvent>
    {

        public OrderEdit(DataContext context, Order order) : base(context)
        {
            Item.Order = order;
        }

        public OrderEdit SetDateTime(DateTime dateTime)
        {
            Item.DateTime = dateTime;
            return this;
        }

        public OrderEdit SetStatus(OrderStatus status)
        {
            if (Item.Order.LatestEvent != null)
            {
                OrderStatus crtStatus = Item.Order.LatestEvent.Status;
                if (crtStatus == OrderStatus.Payed ||
                    crtStatus == OrderStatus.Canceled)
                {
                    throw new ArgumentOutOfRangeException(nameof(status), "Order already in a Final State");
                }
                if (crtStatus != OrderStatus.Created && status == OrderStatus.Created)
                {
                    throw new ArgumentOutOfRangeException(nameof(status), "Cannot go back in Status Order");
                }
            }
            Item.Status = status;
            return this;
        }

        protected override DbSet<OrderEvent> GetDbSet()
        {
            return _context.OrderEvents;
        }
    }
}
