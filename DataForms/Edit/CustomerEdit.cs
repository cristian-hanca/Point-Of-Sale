using System.Data.Entity;
using DababaseConnection;
using DataForms.Base;
using Models;

namespace DataForms.Edit
{
    public class CustomerEdit : EditForm<Customer>
    {
        public CustomerEdit(DataContext context, Customer item) : base(context, item)
        {
        }

        public CustomerEdit SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public CustomerEdit SetLastName(string lastName)
        {
            Item.LastName = lastName;
            return this;
        }

        public CustomerEdit SetPhone(string phone)
        {
            Item.Phone = phone;
            return this;
        }

        protected override DbSet<Customer> GetDbSet()
        {
            return _context.Customers;
        }
    }
}
