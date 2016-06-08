using System.Data.Entity;
using DababaseConnection;
using DataForms.Base;
using DataForms.Create;
using Models;

namespace DataForms.Edit
{
    public class ProductEdit : EditForm<Product>
    {
        public ProductEdit(DataContext context, Product item) : base(context, item)
        {
        }

        public ProductEdit SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public ProductEdit SetCategory(Category category)
        {
            Item.Category = category;
            return this;
        }

        public ProductEdit SetVat(decimal vat)
        {
            Item.Vat = vat;
            return this;
        }

        public ProductEdit SetPrice(decimal price)
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
