using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DababaseConnection;
using DataForms.Base;
using Models;

namespace DataForms.Create
{
    public class OrderItemCreate
    {
        private readonly OrderItem _item;

        public OrderItemCreate()
        {
            _item = new OrderItem();
        }

        public OrderItemCreate SetProduct(Product product)
        {
            _item.Product = product;
            return this;
        }

        public OrderItemCreate SetQuantity(int quantity)
        {
            _item.Quantity = quantity;
            return this;
        }

        public OrderItemCreate SetAlterPrice(decimal alterPrice)
        {
            _item.AlterPrice = alterPrice;
            return this;
        }

        public OrderItem Create()
        {
            return _item;
        }
    }
}
