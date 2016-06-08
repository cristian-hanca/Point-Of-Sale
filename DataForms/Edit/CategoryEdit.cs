using System.Data.Entity;
using System.Data.Entity.Migrations;
using DababaseConnection;
using DataForms.Base;
using DataForms.Create;
using Models;

namespace DataForms.Edit
{
    public sealed class CategoryEdit : EditForm<Category>
    {
        public CategoryEdit(DataContext context, Category item) : base(context, item)
        {
        }

        public CategoryEdit SetName(string name)
        {
            Item.Name = name;
            return this;
        }

        public CategoryEdit SetParentCategory(Category parentCategory)
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
