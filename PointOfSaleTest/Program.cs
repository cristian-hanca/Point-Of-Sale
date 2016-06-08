using System.Collections.Generic;
using System.Linq;
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
            TestProducts();
        }

        static void TestCategories()
        {
            // List all Categories by Name
            List<Category> list = _context.Categories.OrderBy(x => x.Name).ToList();

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

            list = _context.Categories.OrderBy(x => x.Name).ToList();
            list = null; // Place to put a break-point.
        }

        static void TestProducts()
        {
            // Get Category.
            Category category = _context.Categories.First(x => x.Name.Equals("Main Category"));

            // List all Products by Name
            List<Product> list = _context.Products.OrderBy(x => x.Name).ToList();

            // Create a new Product
            Product prod1 = new ProductCreate(_context)
                .SetCategory(category)
                .SetName("Product 1")
                .SetVat(9)
                .SetPrice(10)
                .Execute();

            // Create another Product
            Product prod2 = new ProductCreate(_context)
                .SetCategory(category)
                .SetName("Product 2")
                .SetVat(18)
                .SetPrice(100)
                .Execute();

            // Edit the first Product
            new ProductEdit(_context, prod1)
                .SetName("Awesome Product")
                .Execute();

            // Delete the second Product
            _context.Products.Remove(prod2);
            _context.SaveChanges();

            list = _context.Products.OrderBy(x => x.Name).ToList();
            list = null; // Place to put a break-point.
        }

    }
}
