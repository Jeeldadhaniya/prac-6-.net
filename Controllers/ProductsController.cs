
using Practical_6.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Practical_6.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> P_ALL = GetProductData();
            return View("Products", P_ALL);
        }

        // GET: Products/Details/101
        public ActionResult Details(int id)
        {
            List<Product> P_ALL = GetProductData();

            Product p1 = P_ALL.FirstOrDefault(x => x.ProductId == id);

            if (p1 == null)
            {
                return HttpNotFound();
            }

            return View("View", p1);
        }

        private List<Product> GetProductData()
        {
            List<Product> pTemp = new List<Product>();

            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            // Product 1: iPhone Fold
            p1.ProductId = 101;
            p1.ProductName = "Iphone Fold";
            p1.ProductPrice = 299900;
            p1.ProductCategory = "Mobile";
            p1.ImageUrl = Url.Content("~/Content/Images/iPhone Fold.jpg");

            // Product 2: MacBook Pro
            p2.ProductId = 102;
            p2.ProductName = "MacBook Pro";
            p2.ProductPrice = 239900;
            p2.ProductCategory = "Laptop";
            p2.ImageUrl = Url.Content("~/Content/Images/MacBook Pro.jpg");

            // Product 3: Apple Series 12
            p3.ProductId = 103;
            p3.ProductName = "Apple Series 12";
            p3.ProductPrice = 56900;
            p3.ProductCategory = "Watch";
            p3.ImageUrl = Url.Content("~/Content/Images/Apple Series 12.jpg");

            pTemp.Add(p1);
            pTemp.Add(p2);
            pTemp.Add(p3);

            return pTemp;
        }
    }
}
