using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DababaseConnection;
using Models;

namespace DataForms
{
    public abstract class DataForm<T> where T : IDataModel
    {

        protected readonly DataContext _context;

        public DataForm(DataContext context)
        {
            _context = context;
        }

        public abstract T Execute();

    }
}
