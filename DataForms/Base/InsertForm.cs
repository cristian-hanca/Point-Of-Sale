using System.Data.Entity;
using DababaseConnection;
using Models;

namespace DataForms.Base
{
    public abstract class InsertForm<T> : DataForm<T> where T : class, IDataModel, new()
    {
        protected readonly T Item;

        public InsertForm(DataContext context) : base(context)
        {
            Item = new T();
        }

        protected abstract DbSet<T> GetDbSet();

        public override T Execute()
        {
            GetDbSet().Add(Item);
            _context.SaveChanges();
            return Item;
        }
    }
}
