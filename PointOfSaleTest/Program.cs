using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DababaseConnection;
using DataForms.Create;
using DataForms.Edit;
using Models;

namespace PointOfSaleTest
{
    class Program
    {
        private static DataContext _context;

        static void Main(string[] args)
        {
            _context = new DataContext();
            TestCategories();
        }

        static void TestCategories()
        {
            // List all Categories by Name
            List<Category> categories = _context.Categories.OrderBy(x => x.Name).ToList();

            // Create a new Category
            Category main = new CategoryCreate(_context)
                .SetName("New Category")
                .SetParentCategory(null)
                .Execute();

            // Create a new Sub Category
            Category sub = new CategoryCreate(_context)
                .SetName("Sub Category")
                .SetParentCategory(main)
                .Execute();

            // Edit the Category
            new CategoryEdit(_context, main)
                .SetName("Main Category")
                .Execute();

            // Delete the Sub Category
            _context.Categories.Remove(sub);
            _context.SaveChanges();

            categories = _context.Categories.OrderBy(x => x.Name).ToList();
            categories = null; // Place to put a break-point.
        }

    }
}
