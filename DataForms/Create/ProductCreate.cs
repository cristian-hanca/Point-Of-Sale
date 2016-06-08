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
    public class ProductCreate : InsertForm<Product>
    {
        public ProductCreate(DataContext context) : base(context)
        {
        }

        public ProductCreate SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public ProductCreate SetCategory(Category category)
        {
            Item.Category = category;
            return this;
        }

        public ProductCreate SetVat(decimal vat)
        {
            Item.Vat = vat;
            return this;
        }

        public ProductCreate SetPrice(decimal price)
        {
            Item.Price = price;
            return this;
        }

        protected override DbSet<Product> GetDbSet()
        {
            return _context.Products;
        }
    }
}
