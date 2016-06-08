using System.Data.Entity;
using DababaseConnection;
using DataForms.Base;
using Models;

namespace DataForms.Create
{
    public class CustomerCreate : InsertForm<Customer>
    {
        public CustomerCreate(DataContext context) : base(context)
        {
        }

        public CustomerCreate SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public CustomerCreate SetLastName(string lastName)
        {
            Item.LastName = lastName;
            return this;
        }

        public CustomerCreate SetCnp(string cnp)
        {
            // Validation could go here.
            Item.Cnp = cnp;
            return this;
        }

        public CustomerCreate SetPhone(string phone)
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
