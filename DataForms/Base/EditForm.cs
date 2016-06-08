using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DababaseConnection;
using DataForms;
using Models;

namespace DataForms.Base
{
    public abstract class EditForm<T> : DataForm<T> where T : class, IDataModel, new()
    {
        protected readonly T Item;

        public EditForm(DataContext context, T item) : base(context)
        {
            Item = item;
        }

        protected abstract DbSet<T> GetDbSet();

        public override T Execute()
        {
            GetDbSet().AddOrUpdate(Item);
            _context.SaveChanges();
            return Item;
        }
    }
}
