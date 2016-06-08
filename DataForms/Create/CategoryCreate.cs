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
    public class CategoryCreate : InsertForm<Category>
    {
        public CategoryCreate(DataContext context) : base(context)
        {
        }

        public CategoryCreate SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public CategoryCreate SetParentCategory(Category parentCategory)
        {
            Item.ParentCategory = parentCategory;
            return this;
        }

        protected override DbSet<Category> GetDbSet()
        {
            return _context.Categories;
        }
    }
}
